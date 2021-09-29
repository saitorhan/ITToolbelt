using FluentValidation;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.Db;

namespace ITToolbelt.Bll.Validators
{
    public class GroupValidator : AbstractValidator<Group>
    {
        private readonly IGroupDal iGroupDal;

        public GroupValidator(IGroupDal iGroupDal)
        {
            this.iGroupDal = iGroupDal;
        }
    }
}