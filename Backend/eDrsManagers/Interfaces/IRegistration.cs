using eDrsManagers.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using eDrsDB.Models;
using LrApiManager.XMLClases;
using LrApiManager.XMLClases.Restriction;

namespace eDrsManagers.Interfaces
{
    public interface IRegistration
    {
        List<RegistrationType> GetRegistrationTypes();

        ApplicationResponse CreateRegistration(DocumentReference viewModel);
        List<DocumentReference> GetRegistrations(string regType);
        DocumentReference GetRegistration(long regId);
        ApplicationResponse UpdateRegistration(DocumentReference viewModel);
        bool DeleteRegistration(long regId);
        RegistrationType GetRegistrationType(long regType);
        dynamic GetPollResponse(long regId);
        bool AutomatePollRequest();
    }
}
