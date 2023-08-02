using BLL.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Validators.Authorization
{
	public class RegistrationDtoValidator : AbstractValidator<RegistrationUserDto>
	{
		public RegistrationDtoValidator()
		{
			RuleFor(x => x.Name)
				.Cascade(CascadeMode.Stop)
				.NotEmpty()
				.WithMessage("Field '{PropertyName}' is empty");

			RuleFor(x => x.Password)
				.Cascade(CascadeMode.Stop)
				.NotEmpty()
				.WithMessage("Field '{PropertyName}' is empty")
				.MinimumLength(6)
				.WithMessage("Field '{PropertyName}' must be at least 6 characters");

			RuleFor(x => x.ConfirmPassword)
				.Cascade(CascadeMode.Stop)
				.Equal(x => x.Password)
				.WithMessage("Password dont confirmed");

			RuleFor(x => x.Email)
				.Cascade(CascadeMode.Stop)
				.NotEmpty()
				.WithMessage("Field '{PropertyName}' is empty")
				.EmailAddress()
				.WithMessage("Not valid email adress");
		}

	}
}
