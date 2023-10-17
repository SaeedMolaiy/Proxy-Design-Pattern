namespace ProxyDesignPattern;

internal class ImageProxy : IImage
{
    private RealImage? _realImage;

    private readonly string _filename;

    public ImageProxy(string filename)
    {
        _filename = filename;
    }

    public void Display()
    {
        _realImage ??= new RealImage(_filename);

        _realImage.Display();
    }
}