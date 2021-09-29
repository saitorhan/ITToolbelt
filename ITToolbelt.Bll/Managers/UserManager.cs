using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
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
    public class UserManager
    {
        private IUserDal iUserDal;

        public UserManager(ConnectInfo connectInfo)
        {
            iUserDal = new NinjectModules(connectInfo).StandartKernel.Get<IUserDal>();
        }

        public List<User> GetAll()
        {
            List<User> users = iUserDal.GetAll();
            return users;
        }

        public Tuple<bool, List<string>> Add(User user)
        {
            List<string> messages = new List<string>();
            UserValidator userValidator = new UserValidator(iUserDal);
            ValidationResult validationResult = userValidator.Validate(user);
            if (!validationResult.IsValid)
            {
                IEnumerable<string> enumerable = validationResult.Errors.Select(m => m.ErrorMessage);
                messages.AddRange(enumerable);
                return new Tuple<bool, List<string>>(false, messages);
            }

            User add = iUserDal.Add(user);
            return new Tuple<bool, List<string>>(add != null, null);
        }
        public Tuple<bool, List<string>> Update(User user)
        {
            List<string> messages = new List<string>();
            UserValidator userValidator = new UserValidator(iUserDal);
            ValidationResult validationResult = userValidator.Validate(user);
            if (!validationResult.IsValid)
            {
                IEnumerable<string> enumerable = validationResult.Errors.Select(m => m.ErrorMessage);
                messages.AddRange(enumerable);
                return new Tuple<bool, List<string>>(false, messages);
            }

            User add = iUserDal.Update(user);
            return new Tuple<bool, List<string>>(add != null, null);
        }

        public Tuple<bool, List<string>> Delete(int userId)
        {
            bool result = iUserDal.Delete(userId);
            return new Tuple<bool, List<string>>(result, null);
        }

        public Tuple<bool, List<string>> SyncUsersWithAD(string domain = null, string userName = null, string password = null)
        {
            List<User> users = new List<User>();

            PrincipalContext principalContext;
            if (domain == null)
            {
                principalContext = new PrincipalContext(ContextType.Domain);
            }
            else
            {
                principalContext = new PrincipalContext(ContextType.Domain, domain, userName, password);
            }
            UserPrincipal userPrincipal = new UserPrincipal(principalContext);
            userPrincipal.Enabled = true;
            PrincipalSearcher principalSearcher = new PrincipalSearcher(userPrincipal);
            List<UserPrincipal> principalSearchResult = principalSearcher.FindAll().Cast<UserPrincipal>().OrderBy(u => u.SamAccountName).ToList();
            principalSearchResult.Where(u => u.EmailAddress != null).ToList().ForEach(psr =>
            {
                User user = new User();
                user.Firstname = psr.Name;
                user.Surname = psr.MiddleName;
                user.Mail = psr.EmailAddress;
                users.Add(user);
            });

            bool result = iUserDal.SyncUsersWithAd(users);
            return new Tuple<bool, List<string>>(result, null);
        }
    }
}