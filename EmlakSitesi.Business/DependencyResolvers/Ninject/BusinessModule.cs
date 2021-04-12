using EmlakSitesi.Business.Abstract;
using EmlakSitesi.Business.Abstract.EmlakHaberleri;
using EmlakSitesi.Business.Abstract.GunlukKiralik;
using EmlakSitesi.Business.Abstract.Kiralik;
using EmlakSitesi.Business.Abstract.Projeler;
using EmlakSitesi.Business.Abstract.Satilik;
using EmlakSitesi.Business.Concrete;
using EmlakSitesi.Business.Concrete.EmlakHaberleri;
using EmlakSitesi.Business.Concrete.GunlukKiralik;
using EmlakSitesi.Business.Concrete.Kiralik;
using EmlakSitesi.Business.Concrete.Projeler;
using EmlakSitesi.Business.Concrete.Satilik;
using EmlakSitesi.DataAccess.Abstract;
using EmlakSitesi.DataAccess.Abstract.EmlakHaberleri;
using EmlakSitesi.DataAccess.Abstract.GunlukKiralik;
using EmlakSitesi.DataAccess.Abstract.Kiralik;
using EmlakSitesi.DataAccess.Abstract.Projeler;
using EmlakSitesi.DataAccess.Abstract.Satilik;
using EmlakSitesi.DataAccess.Concrete.EntityFramework;
using EmlakSitesi.DataAccess.Concrete.EntityFramework.EmlakHaberleri;
using EmlakSitesi.DataAccess.Concrete.EntityFramework.GunlukKiralik;
using EmlakSitesi.DataAccess.Concrete.EntityFramework.Kiralik;
using EmlakSitesi.DataAccess.Concrete.EntityFramework.Projeler;
using EmlakSitesi.DataAccess.Concrete.EntityFramework.Satilik;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IUyeService>().To<UyeManager>().InSingletonScope();
            Bind<IUyeDal>().To<EfUyeDal>().InSingletonScope();

            Bind<IAdminService>().To<AdminManager>().InSingletonScope();
            Bind<IAdminDal>().To<EfAdminDal>().InSingletonScope();

            Bind<IIlanBilgileriService>().To<IlanBilgileriManager>().InSingletonScope();
            Bind<IIlanBilgileriDal>().To<EfIlanBilgileriDal>().InSingletonScope();

            Bind<ISatilikDaireService>().To<SatilikDaireManager>().InSingletonScope();
            Bind<ISatilikDaireDal>().To<EfSatilikDaireDal>().InSingletonScope();
            Bind<ISatilikRezidansService>().To<SatilikRezidansManager>().InSingletonScope();
            Bind<ISatilikRezidansDal>().To<EfSatilikRezidansDal>().InSingletonScope();
            Bind<ISatilikVillaService>().To<SatilikVillaManager>().InSingletonScope();
            Bind<ISatilikVillaDal>().To<EfSatilikVillaDal>().InSingletonScope();
            Bind<ISatilikYazlikService>().To<SatilikYazlikManager>().InSingletonScope();
            Bind<ISatilikYazlikDal>().To<EfSatilikYazlikDal>().InSingletonScope();

            Bind<IKiralikDaireService>().To<KiralikDaireManager>().InSingletonScope();
            Bind<IKiralikDaireDal>().To<EfKiralikDaireDal>().InSingletonScope();
            Bind<IKiralikRezidansService>().To<KiralikRezidansManager>().InSingletonScope();
            Bind<IKiralikRezidansDal>().To<EfKiralikRezidansDal>().InSingletonScope();
            Bind<IKiralikVillaService>().To<KiralikVillaManager>().InSingletonScope();
            Bind<IKiralikVillaDal>().To<EfKiralikVillaDal>().InSingletonScope();
            Bind<IKiralikYazlikService>().To<KiralikYazlikManager>().InSingletonScope();
            Bind<IKiralikYazlikDal>().To<EfKiralikYazlikDal>().InSingletonScope();

            Bind<IGunlukKiralikDaireService>().To<GunlukKiralikDaireManager>().InSingletonScope();
            Bind<IGunlukKiralikDaireDal>().To<EfGunlukKiralikDaireDal>().InSingletonScope();
            Bind<IGunlukKiralikRezidansService>().To<GunlukKiralikRezidansManager>().InSingletonScope();
            Bind<IGunlukKiralikRezidansDal>().To<EfGunlukKiralikRezidansDal>().InSingletonScope();
            Bind<IGunlukKiralikVillaService>().To<GunlukKiralikVillaManager>().InSingletonScope();
            Bind<IGunlukKiralikVillaDal>().To<EfGunlukKiralikVillaDal>().InSingletonScope();

            Bind<IProjeKonutService>().To<ProjeKonutManager>().InSingletonScope();
            Bind<IProjeKonutDal>().To<EfProjeKonutDal>().InSingletonScope();
            Bind<IProjeEmlakKonutService>().To<ProjeEmlakKonutManager>().InSingletonScope();
            Bind<IProjeEmlakKonutDal>().To<EfProjeEmlakKonutDal>().InSingletonScope();
            Bind<IProjeTokiService>().To<ProjeTokiManager>().InSingletonScope();
            Bind<IProjeTokiDal>().To<EfProjeTokiDal>().InSingletonScope();

            Bind<IEmlakHaberService>().To<EmlakHaberManager>().InSingletonScope();
            Bind<IEmlakHaberDal>().To<EfEmlakHaberDal>().InSingletonScope();
        }
    }
}
