using Microsoft.AspNetCore.ResponseCompression;

namespace ResponseCompression.CompressionProviders;

public class CustomCompressionProvider : ICompressionProvider
{
    /// <inheritdoc />
    public string EncodingName => "CustomCompressionProvider";

    /// <inheritdoc />
    public bool SupportsFlush => true;

    /// <inheritdoc />
    public Stream CreateStream(Stream outputStream)
    {
        //a custom compression stream wrapper.
        return outputStream;
    }
}