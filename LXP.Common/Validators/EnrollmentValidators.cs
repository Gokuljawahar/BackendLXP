namespace LXP.Common.Validator;

using FluentValidation;
using LXP.Common.ViewModels;

public class EnrollmentValidators : AbstractValidator<EnrollmentViewModel>
{
    public EnrollmentValidators()
    {
        this.RuleFor(enroll => enroll.CourseId).NotEmpty().WithMessage("Course Name is required");

        this.RuleFor(enroll => enroll.LearnerId).NotEmpty().WithMessage("Learner Name is required");

        this.RuleFor(enroll => enroll.EnrollmentDate)
            .NotEmpty()
            .WithMessage("Enrollment Date is required");
    }
}
