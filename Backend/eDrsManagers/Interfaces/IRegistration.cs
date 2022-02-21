using eDrsManagers.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessGatewayModels;
using BusinessGatewayRepositories.EDRSApplication;
using eDrsDB.Models;
using LrApiManager.XMLClases;
using LrApiManager.XMLClases.Restriction;

namespace eDrsManagers.Interfaces
{
    public interface IRegistration
    {
        List<RegistrationType> GetRegistrationTypes();

        RequestLog CreateRegistration(DocumentReferenceViewModel viewModel);
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
        dynamic GetOutStandingPollRequest(long docRefId, int serviceId);
        dynamic GetRequisition(long docRefId, int serviceId);
        dynamic GetFinalResult(long docRefId, int serviceId);
    }
}
