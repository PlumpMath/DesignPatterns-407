using System;

namespace ProxyPatternDemo
{
    public class ProxyImage : IImage
    {
        private readonly string _fileName;
        private RealImage _realImage;

        public ProxyImage(string fileName)
        {
            _fileName = fileName;
        }

        public void Display()
        {
            if (_realImage == null)
                _realImage = new RealImage(_fileName);
            _realImage.Display();
        }
    }
}