using System.Runtime.Remoting.Messaging;
using FluentValidation;
using ITToolbelt.Bll.ExternalLibraries;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.EntityClass;
using ITToolbelt.Shared;
using Microsoft.SqlServer.Management.Smo.Mail;
using Ninject;

namespace ITToolbelt.Bll.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        private IUserDal iUserDal;

        public UserValidator(IUserDal iUserDal)
        {
            this.iUserDal = iUserDal;

            RuleFor(x => x.Firstname).NotEmpty().WithMessage(Resource._001);
            RuleFor(x => x.Surname).NotEmpty().WithMessage(Resource._002);            
            RuleFor(x => x.Mail).NotEmpty().WithMessage(Resource._003);

            RuleFor(u => u.Firstname).MaximumLength(50).WithMessage(Resource._022);
            RuleFor(u => u.Surname).MaximumLength(50).WithMessage(Resource._023);
            RuleFor(u => u.Mail).MaximumLength(50).WithMessage(Resource._024);

            RuleFor(u => new {u.Id, u.Mail}).Must((u) => EmailUnique(u.Id, u.Mail)).WithMessage(Resource._025);
        }

        private bool EmailUnique(int id, string mail)
        {
            bool b = iUserDal.Get(id, mail);
            return b;
        }
    }
}
