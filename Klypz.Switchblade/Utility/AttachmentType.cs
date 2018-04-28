namespace Klypz.Switchblade.Utility
{
    public sealed class AttachmentType1 : IAttachmentType
    {
        private static readonly AttachmentType1 unknownMime = new AttachmentType1("application/octet-stream", "Unknown", string.Empty);
        private static readonly AttachmentType1 photo = new AttachmentType1("image/png", "Photo", ".png");
        private static readonly AttachmentType1 video = new AttachmentType1("video/mp4", "Video", ".mp4");
        private static readonly AttachmentType1 document = new AttachmentType1("application/pdf", "Document", ".pdf");
        private static readonly AttachmentType1 unknown = new AttachmentType1(string.Empty, "Unknown", string.Empty);

        private readonly string mimeType;
        private readonly string friendlyName;
        private readonly string extension;

        // Possibly make this private if you only use the static predefined MIME types.
        public AttachmentType1(string mimeType, string friendlyName, string extension)
        {
            this.mimeType = mimeType;
            this.friendlyName = friendlyName;
            this.extension = extension;
        }

        #region Definitions
        public static IAttachmentType UnknownMime { get { return unknownMime; } }

        public static IAttachmentType Photo { get { return photo; } }

        public static IAttachmentType Video { get { return video; } }

        public static IAttachmentType Document { get { return document; } }

        public static IAttachmentType Unknown { get { return unknown; } }
        #endregion Definitions

        public string MimeType { get { return this.mimeType; } }

        public string FriendlyName { get { return this.friendlyName; } }

        public string Extension { get { return this.extension; } }
    }

}
