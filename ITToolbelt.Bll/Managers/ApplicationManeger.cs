using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation.Results;
using ITToolbelt.Bll.ExternalLibraries;
using ITToolbelt.Bll.Validators;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.EntityClass;
using Ninject;

namespace ITToolbelt.Bll.Managers
{
    public class ApplicationManeger
    {
        private IApplicationDal iApplicationDal;

        public ApplicationManeger(ConnectInfo connectInfo)
        {
            iApplicationDal = new NinjectModules(connectInfo).StandartKernel.Get<IApplicationDal>();
        }

        public List<Application> GetAll()
        {
            return iApplicationDal.GelAll().OrderBy(a => a.Name).ThenBy(a => a.Version).ToList();
        }

        public Tuple<bool, List<string>> Add(Application application)
        {
            List<string> messages = new List<string>();
            ApplicationValidator groupValidator = new ApplicationValidator(iApplicationDal);
            ValidationResult validationResult = groupValidator.Validate(application);
            if (!validationResult.IsValid)
            {
                IEnumerable<string> enumerable = validationResult.Errors.Select(m => m.ErrorMessage);
                messages.AddRange(enumerable);
                return new Tuple<bool, List<string>>(false, messages);
            }

            Application add = iApplicationDal.Add(application);
            return new Tuple<bool, List<string>>(add != null, null);
        }
        public Tuple<bool, List<string>> Update(Application application)
        {
            List<string> messages = new List<string>();
            ApplicationValidator groupValidator = new ApplicationValidator(iApplicationDal);
            ValidationResult validationResult = groupValidator.Validate(application);
            if (!validationResult.IsValid)
            {
                IEnumerable<string> enumerable = validationResult.Errors.Select(m => m.ErrorMessage);
                messages.AddRange(enumerable);
                return new Tuple<bool, List<string>>(false, messages);
            }

            Application add = iApplicationDal.Update(application);
            return new Tuple<bool, List<string>>(add != null, null);
        }

        public Tuple<bool, List<string>> Delete(int appId)
        {
            bool result = iApplicationDal.Delete(appId);
            return new Tuple<bool, List<string>>(result, null);
        }

        public List<Group> GetApplicationGroups(int applicationId)
        {
            List<Group> groups = iApplicationDal.GetApplicationGroups(applicationId);
            return groups;
        }
    }
}