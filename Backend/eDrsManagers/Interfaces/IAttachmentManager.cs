using eDrsManagers.ViewModels;

namespace eDrsManagers.Interfaces
{
    public interface IAttachmentManager
    {
        byte[] GetAttachment(long requestId);
        object RespondToRequisition(long docRefId);
        object RespondToRequisitionByReference(string reference);
        object DirectRespondToRequisition(DocumentReferenceViewModel viewModel);
        dynamic CollectAttachmentResults(long docRefId);
    }
}