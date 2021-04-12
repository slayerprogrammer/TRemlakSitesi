using EmlakSitesi.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.Business.ValidationRules.FluentValidation
{
    public class UyeValidator : AbstractValidator<Uye>
    {
        public UyeValidator()
        {
            RuleFor(m => m.AdSoyad).NotEmpty();
            RuleFor(m => m.Email).NotEmpty();
            RuleFor(m => m.Sifre).NotEmpty();
            RuleFor(m => m.SifreTekrar).NotEmpty();
            RuleFor(m => m.Email).EmailAddress();
        }
    }
}
