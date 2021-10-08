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
using ITToolbelt.Shared;
using Ninject;

namespace ITToolbelt.Bll.Managers
{
    public class ComputerManager
    {
        private IComputerDal iComputerDal;

        public ComputerManager(ConnectInfo connectInfo)
        {
            iComputerDal = new NinjectModules(connectInfo).StandartKernel.Get<IComputerDal>();
        }

        public List<Computer> GetAll()
        {
            return iComputerDal.GelAll().OrderBy(c => c.Name).ToList();
        }

        public List<Computer> GetUserComputers(int userId)
        {
            return iComputerDal.GetUserComputers(userId);
        }

        public Tuple<bool, List<string>> Add(Computer computer)
        {
            List<string> messages = new List<string>();
            ComputerValidator groupValidator = new ComputerValidator(iComputerDal);
            ValidationResult validationResult = groupValidator.Validate(computer);
            if (!validationResult.IsValid)
            {
                IEnumerable<string> enumerable = validationResult.Errors.Select(m => m.ErrorMessage);
                messages.AddRange(enumerable);
                return new Tuple<bool, List<string>>(false, messages);
            }

            Computer add = iComputerDal.Add(computer);
            return new Tuple<bool, List<string>>(add != null, null);
        }
        public Tuple<bool, List<string>> Update(Computer computer)
        {
            List<string> messages = new List<string>();
            ComputerValidator groupValidator = new ComputerValidator(iComputerDal);
            ValidationResult validationResult = groupValidator.Validate(computer);
            if (!validationResult.IsValid)
            {
                IEnumerable<string> enumerable = validationResult.Errors.Select(m => m.ErrorMessage);
                messages.AddRange(enumerable);
                return new Tuple<bool, List<string>>(false, messages);
            }

            computer.User = null;
            Computer add = iComputerDal.Update(computer);
            return new Tuple<bool, List<string>>(add != null, null);
        }

        public Tuple<bool, List<string>> Delete(int computerId)
        {
            bool result = iComputerDal.Delete(computerId);
            return new Tuple<bool, List<string>>(result, null);
        }

        public Tuple<bool, List<string>> SyncComputersWithAd(string domain = null, string userName = null, string password = null)
        {
            List<Computer> groups = new List<Computer>();

            var principalContext = domain == null ? new PrincipalContext(ContextType.Domain) : new PrincipalContext(ContextType.Domain, domain, userName, password);

            ComputerPrincipal groupPrincipal = new ComputerPrincipal(principalContext);
            PrincipalSearcher principalSearcher = new PrincipalSearcher(groupPrincipal);
            List<ComputerPrincipal> principalSearchResult;

            try
            {
                principalSearchResult = principalSearcher.FindAll().Cast<ComputerPrincipal>().OrderBy(u => u.Name).ToList();
            }
            catch (Exception exception)
            {
                List<string> errors = new List<string> { Resource._029, exception.Message };
                return new Tuple<bool, List<string>>(false, errors);
            }

            principalSearchResult.ForEach(psr =>
            {
                Computer user = new Computer
                {
                    Name = psr.Name,
                    Desc = psr.Description
                };
                groups.Add(user);
            });

            bool result = iComputerDal.SyncGroupsWithAd(groups);
            return new Tuple<bool, List<string>>(result, null);
        }

        public List<Computer> GetFreeComputers()
        {
            List<Computer> computers = iComputerDal.GetFreeComputers();
            return computers;
        }

        public Tuple<bool, List<string>> RemoveUserFromComputer(int computerId)
        {
            bool result = iComputerDal.RemoveUserFromComputer(computerId);

            return new Tuple<bool, List<string>>(result, null);
        }
    }
}