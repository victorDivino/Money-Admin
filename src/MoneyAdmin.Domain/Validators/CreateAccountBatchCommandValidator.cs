﻿using FluentValidation;
using MoneyAdmin.Domain.Commands;

namespace MoneyAdmin.Domain.Validators
{
    class CreateAccountBatchCommandValidator : AbstractValidator<CreateAccountBatchCommand>
    {
        public CreateAccountBatchCommandValidator()
        {
            RuleFor(c => c.File).NotNull().WithMessage("The file must not be null");
        }
    }
}
