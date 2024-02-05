using Cars.Application.Dtos.BrandDtos;
using Cars.Application.Features.BrandFeatures.CreateBrand;
using Cars.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Features.ModelFeatures.CreateModel
{
    public class CreateModelValidator : AbstractValidator<CreateModelQuery>
    {
        public CreateModelValidator()
        {
            RuleFor(q => q.createModelDto.Name)
                .NotNull().WithMessage("Cannot be null")
                .NotEmpty().WithMessage("{Name} Cannot be empty");

            RuleFor(dto => dto.createModelDto.ManufactureStartDate)
                .NotEmpty().WithMessage("Manufacture start date is required.")
                .GreaterThan(1700).WithMessage($"Manufacture start date must be greater than BrandCreatedYear.");
           
            RuleFor(dto => dto.createModelDto.ManufactureEndDate)
                .NotEmpty().WithMessage("Manufacture end date is required.")
                .GreaterThan(dto => dto.createModelDto.ManufactureStartDate).WithMessage("End date must be greater than or equal to start date.");
        }
    }
}
