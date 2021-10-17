using System;
using FluentValidation;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.Enum;
using ITToolbelt.Shared;

namespace ITToolbelt.Bll.Validators
{
    public class MetadataValidator : AbstractValidator<Metadata>
    {
        private readonly IMetadataDal ImetadataDal;

        public MetadataValidator(IMetadataDal iComputerDal)
        {
            ImetadataDal = iComputerDal;



            RuleFor(x => x.Value).NotEmpty().WithMessage(Resource._046);

            RuleFor(u => u.Value).MaximumLength(500).WithMessage(Resource._047);

            RuleFor(u => u).Must(ComputernameUnique).WithMessage(Resource._048);
        }
        private bool ComputernameUnique(Metadata metadata)
        {
            bool result = ImetadataDal.IsUnique(metadata);
            return !result;
        }
    }
}