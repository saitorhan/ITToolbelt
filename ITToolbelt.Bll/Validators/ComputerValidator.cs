using FluentValidation;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.Db;
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

            RuleFor(u => new { u.Id, u.Name }).Must((u) => GroupnameUnique(u.Id, u.Name)).WithMessage(Resource._032);
        }
        private bool GroupnameUnique(int id, string name)
        {
            bool b = IcomputerDal.Get(id, name);
            return b;
        }
    }
}