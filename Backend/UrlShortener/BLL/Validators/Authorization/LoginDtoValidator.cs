using BLL.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Validators.Authorization
{
	public class LoginDtoValidator : AbstractValidator<LoginUserDto>
	{
		public LoginDtoValidator()
		{
			RuleFor(x => x.Password)
				.Cascade(CascadeMode.Stop)
				.NotEmpty()
				.WithMessage("Field '{PropertyName}' is empty")
				.MinimumLength(6)
				.WithMessage("Field '{PropertyName}' must be at least 6 characters");

			RuleFor(x => x.Email)
				.Cascade(CascadeMode.Stop)
				.NotEmpty()
				.WithMessage("Field '{PropertyName}' is empty")
				.EmailAddress()
				.WithMessage("Not valid email adress");
		}
	}
}
