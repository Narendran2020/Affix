using Affix.DataContracts.Entity;
using Affix.DataContracts.Repository;
using Affix.ServiceContract.Service_Objects;
using Affix.ServiceContract.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Affix.Services.Services
{
    
    public class OrganizationService : IOrganizationService
    {
        private readonly IOrganizationRepository _organizationRepository;
        private readonly IMapper _mapper;

        public OrganizationService(IOrganizationRepository  organizationrepository , IMapper mapper)
        {
            _organizationRepository = organizationrepository;
            _mapper = mapper;

        }
        public async Task<OrganizationServiceObject> CreateOrganizationAsync(OrganizationServiceObject organizationServiceObject, CancellationToken token)
        {
            var res = _mapper.Map<OrganizationEntity>(organizationServiceObject);
            var createdEntity = await _organizationRepository.CreateOrganizationAsync(res, token);
            return _mapper.Map<OrganizationServiceObject>(createdEntity);
        }

        public async Task DeleteOrganizationByIdAsync(int organizationId, CancellationToken token)
        {
            await _organizationRepository.DeleteOrganizationByIdAsync(organizationId, token);
        }

        public async Task<OrganizationServiceObject> UpdateOrganizationByIdAsync(OrganizationServiceObject organizationServiceObject, CancellationToken token)
        {
            var res = _mapper.Map<OrganizationEntity>(organizationServiceObject);
            var updatedEntity = await _organizationRepository.UpdateOrganizationByIdAsync(res, token);
            return _mapper.Map<OrganizationServiceObject>(updatedEntity);
        }
        public async Task<IEnumerable<OrganizationServiceObject>> GetOrganizationListAsync(CancellationToken token)
        {
            var serviceResult = await _organizationRepository.GetOrganizationListAsync(token);
            return _mapper.Map<IEnumerable<OrganizationServiceObject>>(serviceResult);
        }











        /*public async Task<ServiceResult<string>> UploadAsync(IFormCollection collection)
        {
            using (var client = new WebClient())
            {
                client.Credentials = new NetworkCredential();
                client.UploadFile("ftp://host/E:Natural images.zip", WebRequestMethods.Ftp.UploadFile, localFile);
            }

            var fileToUpload = collection.Files.First();
            //var uploadedPath = await this.UploadFileAsync(fileToUpload);

            
        }*/




        

        


    }
}
