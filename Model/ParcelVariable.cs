namespace Parcels.Models
{
    public class ParcelVariable
    {
        private int _weight;
        private int _length;
        private int _width;
        private int _height;
        private double _price;

        public void SetWeight(string weight)
        {
            _weight = int.Parse(weight);
        }
        public void SetLength(string length)
        {
            _length = int.Parse(length);
        }
        public void SetWidth(string width)
        {
            _width = int.Parse(width);
        }
        public void SetHeight(string height)
        {
            _height = int.Parse(height);
        }
        public void SetPrice()
        {
            _price = (_length*_width*_height) + (_weight * 0.25);
        }

        public int GetWeight()
        {
            return _weight;
        }
        public int GetLength()
        {
            return _length;
        }

        public int GetWidth()
        {
            return _width;
        }

        public int GetHeight()
        {
            return _height;
        }

        public double GetPrice()
        {
            return _price;
        }

    }
}
