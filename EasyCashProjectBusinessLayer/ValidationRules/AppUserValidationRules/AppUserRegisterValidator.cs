using EasyCashProjectDtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashProjectBusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator: AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Parola alanı boş geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Parolayı doğrulayın");
            RuleFor(x => x.Name).NotEmpty().MaximumLength(20).WithMessage("İsim 20 karakterden fazla girilemez");
            RuleFor(x => x.Name).NotEmpty().MinimumLength(2).WithMessage("İsim 2 karakterden az girilemez");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Parolalar eşleşmiyor");
        }
    }
}
