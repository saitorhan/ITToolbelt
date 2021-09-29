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
    public class GroupManager
    {
        private IGroupDal iGroupDal;

        public GroupManager(ConnectInfo connectInfo)
        {
            iGroupDal = new NinjectModules(connectInfo).StandartKernel.Get<IGroupDal>();
        }

        public List<Group> GetAll()
        {
            return iGroupDal.GelAll();
        }

        public List<Group> GetUserGroups(int userId)
        {
            return iGroupDal.GetUserGroups(userId);
        }

        public Tuple<bool, List<string>> Add(Group group)
        {
            List<string> messages = new List<string>();
            GroupValidator groupValidator = new GroupValidator(iGroupDal);
            ValidationResult validationResult = groupValidator.Validate(group);
            if (!validationResult.IsValid)
            {
                IEnumerable<string> enumerable = validationResult.Errors.Select(m => m.ErrorMessage);
                messages.AddRange(enumerable);
                return new Tuple<bool, List<string>>(false, messages);
            }

            Group add = iGroupDal.Add(group);
            return new Tuple<bool, List<string>>(add != null, null);
        }
        public Tuple<bool, List<string>> Update(Group group)
        {
            List<string> messages = new List<string>();
            GroupValidator groupValidator = new GroupValidator(iGroupDal);
            ValidationResult validationResult = groupValidator.Validate(group);
            if (!validationResult.IsValid)
            {
                IEnumerable<string> enumerable = validationResult.Errors.Select(m => m.ErrorMessage);
                messages.AddRange(enumerable);
                return new Tuple<bool, List<string>>(false, messages);
            }

            Group add = iGroupDal.Update(group);
            return new Tuple<bool, List<string>>(add != null, null);
        }

        public Tuple<bool, List<string>> Delete(int groupId)
        {
            bool result = iGroupDal.Delete(groupId);
            return new Tuple<bool, List<string>>(result, null);
        }
    }
}