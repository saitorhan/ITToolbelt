using FluentValidation;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.Db;
using ITToolbelt.Shared;

namespace ITToolbelt.Bll.Validators
{
    public class ApplicationValidator : AbstractValidator<Application>
    {
        private readonly IApplicationDal iApplicationDal;

        public ApplicationValidator(IApplicationDal iApplicationDal)
        {
            this.iApplicationDal = iApplicationDal;



            RuleFor(x => x.Name).NotEmpty().WithMessage(Resource._034);
            RuleFor(x => x.Publisher).NotEmpty().WithMessage(Resource._036);
            RuleFor(x => x.Version).NotEmpty().WithMessage(Resource._037);
            RuleFor(x => x.BuiltType).NotEmpty().WithMessage(Resource._038);

            RuleFor(u => u.Name).MaximumLength(100).WithMessage(Resource._035);
            RuleFor(u => u.Publisher).MaximumLength(100).WithMessage(Resource._039);
            RuleFor(u => u.Version).MaximumLength(40).WithMessage(Resource._040);

            RuleFor(u => u.BuiltType).Must(CheckBuiltType).WithMessage(Resource._041);
        }

        private bool CheckBuiltType(string builtType)
        {
            return builtType == "64 Bit" || builtType == "32 Bit";
        }
    }
}