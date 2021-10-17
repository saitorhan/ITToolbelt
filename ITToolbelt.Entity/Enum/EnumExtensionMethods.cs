using System;
using ITToolbelt.Shared;

namespace ITToolbelt.Entity.Enum
{
    public static class EnumExtensionMethods
    {
        public static string ToString(this MetadataType metadataType)
        {
            switch (metadataType)
            {
                case MetadataType.Ram:
                    return "RAM";
                case MetadataType.DiskType:
                    return Resource._044;
                case MetadataType.DiskCapacity:
                    return Resource._045;
                default:
                    return String.Empty;
            }
        }
    }
}