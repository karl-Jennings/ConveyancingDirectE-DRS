namespace eDrsManagers.Interfaces
{
    public interface IAttachmentManager
    {
        byte[] GetAttachment(long requestId);

        object ReplyAttachments(long docRefId);
    }
}