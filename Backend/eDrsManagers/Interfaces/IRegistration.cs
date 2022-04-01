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
        Task<bool> AutomatePollRequest();
        dynamic GetAttachmentPollRequest(long docRefId, int serviceId);
        dynamic GetRequisition(string AdditionalProviderFilter);
        dynamic GetFinalResult(long docRefId, int serviceId);
        Task<dynamic> CollectResultsAsync(string AdditionalProviderFilter);
        Task<dynamic> EarlyCompletionAsync(string AdditionalProviderFilter);
        Task<dynamic> CollectAllOutstandingsAsync(string AdditionalProviderFilter);
        Task<dynamic> CorrespondencePollRequest(List<Outstanding> outstandings);
        Task<dynamic> ApplicationPollRequest(List<Outstanding> outstandings);
        Task<dynamic> EarlyCompletionPollRequest(List<Outstanding> outstandings);

    }
}
