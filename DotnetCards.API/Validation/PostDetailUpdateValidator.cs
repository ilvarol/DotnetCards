using DotnetCards.API.DTOs;
using DotnetCards.Core.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCards.API.Validation
{
    public class PostDetailUpdateValidator : AbstractValidator<PostDetailUpdateDto>
    {
        public PostDetailUpdateValidator()
        {
            RuleFor(pd => pd.PostText).NotEmpty().WithMessage("This field is required!");
        }
    }
}
