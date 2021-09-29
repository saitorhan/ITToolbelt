using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ITToolbelt.Bll.Managers;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.EntityClass;
using ITToolbelt.Entity.Enum;
using ITToolbelt.Shared;
using ITToolbelt.WinForms.ExtensionMethods;

namespace ITToolbelt.WinForms.Forms.DBAForms
{
    public partial class FormIndexes : Form
    {
        private List<Index> indexes;
        private TreeNodeType backWorkerFlag;
        private readonly BackgroundWorker backgroundWorker;
        private TreeNode activeDatabaseNode;
        public FormIndexes()
        {
            InitializeComponent();
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;

            backWorkerFlag = TreeNodeType.Connection;
            toolStripProgressBarStatus.StartStopMarque();
            backgroundWorker.RunWorkerAsync();
        }

        private void RefreshConnections()
        {
            ConnectionManager connectionManager = new ConnectionManager(GlobalVariables.ConnectInfo);
            List<Connection> connections = connectionManager.GetConnections(false);

            foreach (Connection connection in connections)
            {
                TreeNode treeNode = new TreeNode
                {
                    Name = connection.ConnectionString,
                    Text = connection.Name,
                    Tag = new Tuple<TreeNodeType, DbServerType>(TreeNodeType.Connection, connection.DbServerTypeCode)
                };
                if (connection.ConnectionInfo == Resource._017)
                {
                    treeNode.BackColor = Color.Red;
                }
                if (treeViewConnections.InvokeRequired)
                {
                    treeViewConnections.Invoke(
                    new Action(delegate
                    {
                        treeViewConnections.Nodes.Add(treeNode);
                    }));
                }
                else
                {
                    treeViewConnections.Nodes.Add(treeNode);
                }
                
            }
        }

        private void treeViewConnections_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            activeDatabaseNode = null;
            TreeNode treeNode = e.Node;
            if (treeNode == null || treeNode.Tag == null || treeNode.BackColor == Color.Red)
            {
                return;
            }

            Tuple<TreeNodeType, DbServerType> treeNodeTag = treeNode.Tag as Tuple<TreeNodeType, DbServerType>;
            if (treeNodeTag == null)
            {
                return;
            }

            switch (treeNodeTag.Item1)
            {
                case TreeNodeType.Connection:
                    backWorkerFlag = TreeNodeType.Database;
                    toolStripProgressBarStatus.StartStopMarque();
                    backgroundWorker.RunWorkerAsync(argument: treeNode);
                    break;
                case TreeNodeType.Database:
                    backWorkerFlag = TreeNodeType.Table;
                    toolStripProgressBarStatus.StartStopMarque();
                    backgroundWorker.RunWorkerAsync(argument: treeNode);
                    break;
                case TreeNodeType.Table:
                    break;
                case TreeNodeType.Index:
                    break;
                default:
                    return;
            }
        }

        private void GetDatabases(TreeNode treeNode)
        {
            Tuple<TreeNodeType, DbServerType> treeNodeTag = treeNode.Tag as Tuple<TreeNodeType, DbServerType>;
            if (treeNodeTag == null)
            {
                return;
            }

            ConnectionManager connectionManager = new ConnectionManager(new ConnectInfo(treeNode.Name, treeNodeTag.Item2));
            List<Database> databases = connectionManager.GetDatabases();

            treeViewConnections.Invoke(
                new Action(delegate
                {
                    if (databases.Count > 0)
                    {
                        treeNode.Nodes.Clear();
                    }

                    foreach (Database database in databases)
                    {
                        SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder(treeNode.Name)
                        {
                            InitialCatalog = database.Name
                        };
                        TreeNode dbNode = new TreeNode
                        {
                            Name = connectionStringBuilder.ConnectionString,
                            Text = database.Name,
                            Tag = new Tuple<TreeNodeType, DbServerType>(TreeNodeType.Database, treeNodeTag.Item2)
                        };
                        if (database.State > 0)
                        {
                            dbNode.BackColor = Color.Red;
                        }
                        treeNode.Nodes.Add(dbNode);
                    }

                    treeNode.Expand();
                }));
        }

        private void GetTables(TreeNode treeNode)
        {
            Tuple<TreeNodeType, DbServerType> treeNodeTag = treeNode.Tag as Tuple<TreeNodeType, DbServerType>;
            if (treeNodeTag == null)
            {
                return;
            }

            ConnectionManager connectionManager = new ConnectionManager(new ConnectInfo(treeNode.Name, treeNodeTag.Item2));
            List<Table> tables = connectionManager.GetTables();

            treeViewConnections.Invoke(
                new Action(delegate
                {
                    if (tables.Count > 0)
                    {
                        treeNode.Nodes.Clear();
                    }

                    foreach (Table table in tables)
                    {
                        TreeNode dbNode = new TreeNode
                        {
                            Name = table.TableName,
                            Text = $"[{table.SchemaName}].[{table.TableName}]",
                            Tag = TreeNodeType.Table
                        };
                        treeNode.Nodes.Add(dbNode);
                    }
                }));
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            TreeNode treeNode;
            switch (backWorkerFlag)
            {
                case TreeNodeType.Connection:
                    RefreshConnections();
                    break;
                case TreeNodeType.Database:
                    treeNode = e.Argument as TreeNode;
                    GetDatabases(treeNode);
                    break;
                case TreeNodeType.Table:
                    treeNode = e.Argument as TreeNode;
                    // GetTables(treeNode);
                    GetIndexes(treeNode);
                    break;
                case TreeNodeType.Index:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripProgressBarStatus.StartStopMarque();
        }

        private void GetIndexes(TreeNode treeNode)
        {
            activeDatabaseNode = treeNode;
            IndexManager indexManager = new IndexManager(new ConnectInfo(treeNode.Name, (treeNode.Tag as Tuple<TreeNodeType, DbServerType>).Item2));
            indexes = indexManager.GetIndexes();


            if (dataGridViewIndexes.InvokeRequired)
            {
                dataGridViewIndexes.Invoke(new Action(delegate
                {
                    indexBindingSource.DataSource = indexes;
                }));
            }
            else
            {
                indexBindingSource.DataSource = indexes;
            }

            // dataGridViewIndexes.Refresh();
        }

        private void dataGridViewIndexes_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridViewIndexes_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewIndexes.SelectedRows.Count == 0)
            {
                return;
            }

            foreach (DataGridViewRow selectedRow in dataGridViewIndexes.SelectedRows)
            {
                Index index = selectedRow.DataBoundItem as Index;
                if (index.State == Resource._007)
                {
                    buttonDisable.Enabled = true;
                    return;
                }
            }

            buttonDisable.Enabled = false;
        }

        private void buttonDisable_Click(object sender, EventArgs e)
        {
            if (dataGridViewIndexes.SelectedRows.Count == 0)
            {
                return;
            }

            IndexManager indexManager = new IndexManager(new ConnectInfo(activeDatabaseNode.Name, (activeDatabaseNode.Tag as Tuple<TreeNodeType, DbServerType>).Item2));
            List<Index> selectedIndexes = new List<Index>();
            foreach (DataGridViewRow selectedRow in dataGridViewIndexes.SelectedRows)
            {
                Index index = selectedRow.DataBoundItem as Index;
                selectedIndexes.Add(index);
            }

            List<Index> setIndexes = indexManager.SetDisable(selectedIndexes);

            List<Index> indices = setIndexes.Where(s => s.State == Resource._007).ToList();
            if (indices.Count == 0)
            {
                MessageBox.Show(Resource._011, Resource._012, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Resource._013, Resource._005, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGetColumns_Click(object sender, EventArgs e)
        {
            if (dataGridViewIndexes.SelectedRows.Count != 1 && dataGridViewIndexes.SelectedRows[0].Index < 0)
            {
                return;
            }

            Index index = dataGridViewIndexes.SelectedRows[0].DataBoundItem as Index;
            IndexManager indexManager = new IndexManager(new ConnectInfo(activeDatabaseNode.Name, (activeDatabaseNode.Tag as Tuple<TreeNodeType, DbServerType>).Item2));
            List<Column> columns = indexManager.GetColumns(index);


            listViewColumns.Items.Clear();
            listViewIncludes.Items.Clear();
            foreach (Column column in columns.Where(c => !c.IsInclude))
            {
                string[] row = { column.ColumnName, column.SortType, column.Type };
                listViewColumns.Items.Add(new ListViewItem(row));
            }

            foreach (Column column in columns.Where(c => c.IsInclude))
            {
                string[] columnStrings = new[] { column.ColumnName, column.Type };
                listViewIncludes.Items.Add(new ListViewItem(columnStrings));
            }
        }
    }
}
