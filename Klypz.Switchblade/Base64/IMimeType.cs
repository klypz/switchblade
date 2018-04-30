namespace Klypz.Switchblade.Base64
{
    public interface IMimeType
    {
        string Extension { get; }
        string Mime { get; }
        byte?[] ByteHeader { get; }
        int Offset { get; }
        byte?[] OtherIdentifier { get; }
    }
}
