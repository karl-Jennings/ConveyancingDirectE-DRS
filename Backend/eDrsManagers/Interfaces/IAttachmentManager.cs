namespace eDrsManagers.Interfaces
{
    public interface IAttachmentManager
    {
        byte[] GetAttachment(long requestId);

        object RespondToRequisition(long docRefId);
    }
}