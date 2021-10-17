using System.Collections.Generic;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.Enum;

namespace ITToolbelt.Dal.Abstract
{
    public interface IMetadataDal
    {
        List<Metadata> GetList(MetadataType type);
        Metadata Add(Metadata metadata);
        Metadata Update(Metadata metadata);
        bool Delete(int id);
        bool IsUnique(Metadata metadata);
    }
}