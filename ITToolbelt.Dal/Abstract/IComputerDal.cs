using System.Collections.Generic;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.Enum;

namespace ITToolbelt.Dal.Abstract
{
    public interface IComputerDal
    {
        List<Computer> GelAll();
        Computer Add(Computer computer);
        Computer Update(Computer computer);

        bool Get(int id, string name, ComputerProperty property);
        bool Delete(int computerId);

        List<Computer> GetUserComputers(int userId);
        bool SyncGroupsWithAd(List<Computer> computers);
        List<Computer> GetFreeComputers();
        bool RemoveUserFromComputer(int computerId);
    }
}