using Cars.Application.Dtos.BrandDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Features.BrandFeatures.CreateBrand
{
    public class CreateBrandValidator : AbstractValidator<CreateBrandQuery>
    {
        public CreateBrandValidator() 
        {
            RuleFor(q => q.createBrandDto.Name)
                .NotNull().WithMessage("Cannot be null")
                .NotEmpty().WithMessage("{Name} Cannot be empty");
            RuleFor(q => q.createBrandDto.BrandCreatedYear)
                .GreaterThanOrEqualTo(1700).WithMessage("Error");
        }
    }
}
