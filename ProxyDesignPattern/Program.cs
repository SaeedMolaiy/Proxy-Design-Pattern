using ProxyDesignPattern;

IImage image = new ImageProxy("large_image.jpg");

// The image is loaded and displayed when needed
image.Display();

// It won't load the image again, just displays it
image.Display();

Console.ReadKey();