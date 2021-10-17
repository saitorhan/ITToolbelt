using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation.Results;
using ITToolbelt.Bll.ExternalLibraries;
using ITToolbelt.Bll.Validators;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.EntityClass;
using ITToolbelt.Entity.Enum;
using Ninject;

namespace ITToolbelt.Bll.Managers
{
    public class MetadataManager
    {
        private readonly IMetadataDal iMetadataDal;

        public MetadataManager(ConnectInfo connectInfo)
        {
            iMetadataDal = new NinjectModules(connectInfo).StandartKernel.Get<IMetadataDal>();
        }

        public List<Metadata> GetAll(MetadataType type)
        {
            return iMetadataDal.GetList(type);
        }

        public Tuple<bool, List<string>> Add(Metadata metadata)
        {
            List<string> messages = new List<string>();
            MetadataValidator groupValidator = new MetadataValidator(iMetadataDal);
            ValidationResult validationResult = groupValidator.Validate(metadata);
            if (!validationResult.IsValid)
            {
                IEnumerable<string> enumerable = validationResult.Errors.Select(m => m.ErrorMessage);
                messages.AddRange(enumerable);
                return new Tuple<bool, List<string>>(false, messages);
            }

            Metadata add = iMetadataDal.Add(metadata);
            return new Tuple<bool, List<string>>(add != null, null);
        }
        public Tuple<bool, List<string>> Update(Metadata metadata)
        {
            List<string> messages = new List<string>();
            MetadataValidator groupValidator = new MetadataValidator(iMetadataDal);
            ValidationResult validationResult = groupValidator.Validate(metadata);
            if (!validationResult.IsValid)
            {
                IEnumerable<string> enumerable = validationResult.Errors.Select(m => m.ErrorMessage);
                messages.AddRange(enumerable);
                return new Tuple<bool, List<string>>(false, messages);
            }

            Metadata add = iMetadataDal.Update(metadata);
            return new Tuple<bool, List<string>>(add != null, null);
        }

        public Tuple<bool, List<string>> Delete(int id)
        {
            bool result = iMetadataDal.Delete(id);
            return new Tuple<bool, List<string>>(result, null);
        }
    }
}