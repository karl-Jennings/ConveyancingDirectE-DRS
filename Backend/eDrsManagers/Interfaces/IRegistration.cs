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

        RequestLog CreateRegistration(DocumentReference viewModel);
        List<DocumentReference> GetRegistrations(string regType);
        DocumentReference GetRegistration(long regId);
        RequestLog UpdateRegistration(DocumentReferenceViewModel viewModel);
        bool DeleteRegistration(long regId);
        RegistrationType GetRegistrationType(long regType);
        dynamic GetPollResponse(long regId);
        bool AutomatePollRequest();
    }
}
