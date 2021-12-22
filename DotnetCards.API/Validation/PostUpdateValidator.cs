using DotnetCards.API.DTOs;
using DotnetCards.Core.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCards.API.Validation
{
    public class PostUpdateValidator : AbstractValidator<PostUpdateDto>
    {
        public PostUpdateValidator()
        {
            RuleFor(p => p.Title).NotEmpty().WithMessage("This field is required!");
            RuleFor(p => p.Title).MaximumLength(200).WithMessage("This field cannot higher than 200 character!");
        }
    }
}
