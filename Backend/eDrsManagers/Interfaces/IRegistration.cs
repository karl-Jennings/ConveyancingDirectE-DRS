using eDrsManagers.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessGatewayModels;
using BusinessGatewayRepositories.EDRSApplication;
using eDrsDB.Models;
using LrApiManager.XMLClases;
using LrApiManager.XMLClases.Restriction;
using System.Threading.Tasks;

namespace eDrsManagers.Interfaces
{
    public interface IRegistration
    {
        List<RegistrationType> GetRegistrationTypes();
        Task<RequestLog> CreateRegistration(DocumentReferenceViewModel viewModel);
        List<DocumentReference> GetRegistrations(string regType);
        DocumentReference GetRegistration(long regId);
        DocumentReference GetRegistrationByReference(string refernce);
        RequestLog UpdateRegistration(DocumentReferenceViewModel viewModel);
        DocumentReference UpdateRegistrationForRequisition(DocumentReferenceViewModel viewModel);
        bool DeleteRegistration(long regId);
        RegistrationType GetRegistrationType(long regType);
        dynamic GetPollResponse(long docRefId);
        dynamic ApplicationPollRequest(long docRefId, int service);
        bool AutomatePollRequest();        
        dynamic GetRequisition(string AdditionalProviderFilter);
        dynamic GetFinalResult(long docRefId, int serviceId);
        Task<dynamic> CollectResultsAsync(string AdditionalProviderFilter);
        Task<dynamic> EarlyCompletionAsync(string AdditionalProviderFilter);
        Task<List<Outstanding>> CollectAllOutstandingsAsync(string AdditionalProviderFilter);
    }
}
