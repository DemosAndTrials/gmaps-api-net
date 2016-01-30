using System.Globalization;
using System.Runtime.Serialization;
using Windows.Foundation;

namespace WinStoreApp.Map
{
    [DataContract]
    public struct Size
    {
        public static readonly Size Empty = new Size();

        private int _width;
        private int _height;

        /** 
         * Create a new Size object from a point
         */
        public Size(Point pt)
        {
            _width = (int)pt.X;
            _height = (int)pt.Y;
        }

        /** 
         * Create a new Size object of the specified dimension
         */
        public Size(int width, int height)
        {
            this._width = width;
            this._height = height;
        }

        public static Size operator +(Size sz1, Size sz2)
        {
            return Add(sz1, sz2);
        }

        public static Size operator -(Size sz1, Size sz2)
        {
            return Subtract(sz1, sz2);
        }

        public static bool operator ==(Size sz1, Size sz2)
        {
            return sz1.Width == sz2.Width && sz1.Height == sz2.Height;
        }

        public static bool operator !=(Size sz1, Size sz2)
        {
            return !(sz1 == sz2);
        }

        public static explicit operator Point(Size size)
        {
            return new Point(size.Width, size.Height);
        }

        public bool IsEmpty
        {
            get
            {
                return _width == 0 && _height == 0;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public static Size Add(Size sz1, Size sz2)
        {
            return new Size(sz1.Width + sz2.Width, sz1.Height + sz2.Height);
        }

        public static Size Subtract(Size sz1, Size sz2)
        {
            return new Size(sz1.Width - sz2.Width, sz1.Height - sz2.Height);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Size))
                return false;

            Size comp = (Size)obj;
            // Note value types can't have derived classes, so we don't need to
            // check the types of the objects here.  -- [....], 2/21/2001
            return (comp._width == this._width) &&
                   (comp._height == this._height);
        }

        public override int GetHashCode()
        {
            return _width ^ _height;
        }

        public override string ToString()
        {
            return "{Width=" + _width.ToString(CultureInfo.CurrentCulture) + ", Height=" + _height.ToString(CultureInfo.CurrentCulture) + "}";
        }
    }

}
