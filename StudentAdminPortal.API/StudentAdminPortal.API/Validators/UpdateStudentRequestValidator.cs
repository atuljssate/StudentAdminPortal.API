using FluentValidation;
using StudentAdminPortal.API.DomainModels;
using StudentAdminPortal.API.Repositories;

namespace StudentAdminPortal.API.Validators
{
    public class UpdateStudentRequestValidator: AbstractValidator<UpdateStudentRequest>
    {
        public UpdateStudentRequestValidator(IStudentRepository studentRepository)
        {
            RuleFor(model => model.FirstName).NotEmpty();
            RuleFor(model => model.LastName).NotEmpty();
            RuleFor(model => model.Email).NotEmpty().EmailAddress();
            RuleFor(model => model.DateOfBirth).NotEmpty();
            RuleFor(model => model.Mobile).GreaterThan(99999).LessThan(10000000000);
            RuleFor(model => model.GenderId).NotEmpty().Must(id =>
            {
                var gender = studentRepository.GetAllGendersAsync().Result.ToList()
                .FirstOrDefault(model => model.Id == id);
                if (gender != null)
                {
                    return true;
                }
                return false;

            }).WithMessage("Please select a valid Gender");
            RuleFor(model => model.PostalAddress).NotEmpty();
            RuleFor(model => model.PhysicalAddress).NotEmpty();

        }
    }
}
