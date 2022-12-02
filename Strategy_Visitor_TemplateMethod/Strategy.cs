interface ICompression
{
    void CompressFolder(string compressedArchiveFileName);
}

class RarCompression : ICompression
{
    public void CompressFolder(string compressedArchiveFileName)
    {
        Console.WriteLine($"Folder is compressed using Rar approach: {compressedArchiveFileName}.rar file is created");
    }
}

class ZipCompression : ICompression
{
    public void CompressFolder(string compressedArchiveFileName)
    {
        Console.WriteLine($"Folder is compressed using Zip approach: {compressedArchiveFileName}.zip file is created");
    }
}

class CompressionContext
{
    ICompression Compression;

    public CompressionContext(ICompression Compression)
        => this.Compression = Compression;
    public void SetStrategy(ICompression Compression)
        => this.Compression = Compression;
    public void CreateArchive(string compressedArchiveFileName)
        => Compression.CompressFolder(compressedArchiveFileName);
}