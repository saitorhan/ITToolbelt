﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.EntityClass;
using ITToolbelt.Entity.Enum;

namespace ITToolbelt.Dal.Contract.MsSql
{
    public class MsSqlMetadataDal : IMetadataDal
    {
        public MsSqlMetadataDal(ConnectInfo connectInfo)
        {
            ConnectInfo = connectInfo;
        }

        public ConnectInfo ConnectInfo { get; set; }
        public List<Metadata> GetList(MetadataType type)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                List<Metadata> metadatas = context.Metadatas.Where(m => m.MetadataType == type).OrderBy(m => m.Value).ToList();
                return metadatas;
            }
        }

        public Metadata Add(Metadata metadata)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                Metadata add = context.Metadatas.Add(metadata);
                return context.SaveChanges() ? add : null;
            }
        }

        public Metadata Update(Metadata metadata)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                context.Entry(metadata).State = EntityState.Modified;
                Metadata update = context.SaveChanges() ? metadata : null;

                return update;
            }
        }

        public bool Delete(int id)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                Metadata application = context.Metadatas.SingleOrDefault(u => u.Id == id);
                if (application == null)
                {
                    return false;
                }

                context.Metadatas.Remove(application);
                return context.SaveChanges();
            }
        }
    }
}