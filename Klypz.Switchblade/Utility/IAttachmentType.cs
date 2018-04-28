namespace Klypz.Switchblade.Utility
{
    public interface IAttachmentType
    {
        string MimeType { get; }

        string FriendlyName { get; }

        string Extension { get; }
    }

}
