using Affix.DataContracts.Entity;
using Affix.ServiceContract.Service_Objects;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Affix.Services.Configuration
{
    public sealed class AutomappingProfile : Profile
    {
        public AutomappingProfile()
        {
            this.CreateMapForCatalogue();
            this.CreateMapForAffix();
            this.CreateMapForOrganization();
            this.CreateMapForCountry();
            this.CreateMapForState();
        }
        private void CreateMapForCatalogue()
        {
            this.CreateMap<CatalogueServiceObject, CatalogueEntity>()
            .ForMember(CatalogueEntity => CatalogueEntity.Status, opt => opt.MapFrom(x => true));
            this.CreateMap<CatalogueEntity, CatalogueServiceObject>();
        }
         private void CreateMapForAffix()
        {
            this.CreateMap<AffixServiceObject, AffixEntity>()
              .ForMember(AffixEntity => AffixEntity.Status, opt => opt.MapFrom(x => true));
            this.CreateMap<AffixEntity, AffixServiceObject>();
        }
        private void CreateMapForOrganization()
        {
            this.CreateMap<OrganizationServiceObject, OrganizationEntity>()
             .ForMember(OrganizationEntity => OrganizationEntity.Status, opt => opt.MapFrom(x => true));
            this.CreateMap<OrganizationEntity, OrganizationServiceObject>();

           /* this.CreateMap<AppointmentScheduleServiceObject, AppointmentscheduleEntity>()
            .ForMember(AppointmentscheduleEntity => AppointmentscheduleEntity.Status, opt => opt.MapFrom(x => true));
            this.CreateMap<AppointmentscheduleEntity, AppointmentScheduleServiceObject>();*/
        }
        private void CreateMapForCountry()
        {
            this.CreateMap<CountryServiceObject, CountryEntity>()
               .ForMember(CountryEntity => CountryEntity.Status, opt => opt.MapFrom(x => true));
            this.CreateMap<CountryEntity, CountryServiceObject>();
        }
        private void CreateMapForState()
        {
            this.CreateMap<StateServiceObject, StateEntity>()
                 .ForMember(StateEntity => StateEntity.Status, opt => opt.MapFrom(x => true));
            this.CreateMap<StateEntity, StateServiceObject>();
        }

        
    }
}
