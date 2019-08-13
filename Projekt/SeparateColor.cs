using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace RoP_RaEd
{
    class SeparateColor : INotifyPropertyChanged
    {
        private byte _a, _r, _g, _b;

        public event PropertyChangedEventHandler PropertyChanged;

        public byte A
        {
            get { return _a; }
            set 
            {
                _a = value; OnPropertyChanged();
            }
        }
        public byte R
        {
            get { return _r; } set { _r = value; OnPropertyChanged(); }
        }
        public byte G { get { return _g; } set { _g = value; OnPropertyChanged();  } }
        public byte B { get { return _b; } set { _b = value; OnPropertyChanged(); } }

        public SeparateColor(byte a, byte r, byte g, byte b)
        {
            A = a;
            R = r;
            G = g;
            B = b;
        }

        public SeparateColor(Color c)
        {
            A = c.A;
            R = c.R;
            G = c.G;
            B = c.B;
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public Color ToDefaultColor()
        {
            return Color.FromArgb(A, R, G, B);
        }
    }
}
