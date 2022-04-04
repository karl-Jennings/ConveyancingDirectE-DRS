using eDrsDB.Models;
using eDrsManagers.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eDrsManagers.Interfaces
{
    public interface IAttachmentManager
    {
        byte[] GetAttachment(long requestId);
        object RespondToRequisition(long docRefId);
        object RespondToRequisitionByReference(string reference);
        object DirectRespondToRequisition(DocumentReferenceViewModel viewModel);
        Task<dynamic> CollectAttachmentResultsAsync(string AdditionalProviderFilter);
    }
}