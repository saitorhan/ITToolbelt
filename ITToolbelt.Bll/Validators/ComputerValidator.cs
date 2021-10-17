using System;
using FluentValidation;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.Enum;
using ITToolbelt.Shared;

namespace ITToolbelt.Bll.Validators
{
    public class ComputerValidator : AbstractValidator<Computer>
    {
        private readonly IComputerDal IcomputerDal;

        public ComputerValidator(IComputerDal iComputerDal)
        {
            IcomputerDal = iComputerDal;



            RuleFor(x => x.Name).NotEmpty().WithMessage(Resource._001);

            RuleFor(u => u.Name).MaximumLength(50).WithMessage(Resource._022);
            RuleFor(u => u.Desc).MaximumLength(500).WithMessage(Resource._030);
            RuleFor(u => u.SerialNumber).MaximumLength(30).WithMessage(Resource._042);

            RuleFor(u => new { u.Id, u.Name }).Must((u) => ComputernameUnique(u.Id, u.Name, ComputerProperty.Name)).WithMessage(Resource._032);
            RuleFor(u => new { u.Id, u.SerialNumber }).Must((u) => ComputernameUnique(u.Id, u.SerialNumber, ComputerProperty.SerialNumber)).WithMessage(Resource._043);
        }
        private bool ComputernameUnique(int id, string name, ComputerProperty property)
        {
            if (property == ComputerProperty.SerialNumber && String.IsNullOrEmpty(name))
            {
                return true;
            }

            bool b = IcomputerDal.Get(id, name, property);
            return b;
        }
    }
}