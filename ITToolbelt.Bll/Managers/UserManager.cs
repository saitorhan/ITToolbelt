﻿using System;
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

        public Tuple<bool, List<string>, User> Add(User user)
        {
            List<string> messages = new List<string>();
            UserValidator userValidator = new UserValidator(iUserDal);
            ValidationResult validationResult = userValidator.Validate(user);
            if (!validationResult.IsValid)
            {
                IEnumerable<string> enumerable = validationResult.Errors.Select(m => m.ErrorMessage);
                messages.AddRange(enumerable);
                return new Tuple<bool, List<string>, User>(false, messages, user);
            }

            User add = iUserDal.Add(user);
            return new Tuple<bool, List<string>, User>(add != null, null, add ?? user);
        }
    }
}