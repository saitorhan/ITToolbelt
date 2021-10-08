using System.Collections.Generic;
using ITToolbelt.Entity.Db;

namespace ITToolbelt.Dal.Abstract
{
    public interface IComputerDal
    {
        List<Computer> GelAll();
        Computer Add(Computer computer);
        Computer Update(Computer computer);

        bool Get(int id, string name);
        bool Delete(int computerId);

        List<Computer> GetUserComputers(int userId);
        bool SyncGroupsWithAd(List<Computer> computers);
        List<Computer> GetFreeComputers();
    }
}