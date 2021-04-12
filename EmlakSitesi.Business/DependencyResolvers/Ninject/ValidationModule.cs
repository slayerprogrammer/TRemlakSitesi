using EmlakSitesi.Business.ValidationRules.FluentValidation;
using EmlakSitesi.Entities;
using FluentValidation;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.Business.DependencyResolvers.Ninject
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Uye>>().To<UyeValidator>().InSingletonScope();
        }
    }
}
