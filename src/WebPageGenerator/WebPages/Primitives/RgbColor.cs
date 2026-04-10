using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPages.Primitives
{
    public struct RgbColor
    {
        public static readonly RgbColor Black = new(0, 0, 0);
        public static readonly RgbColor White = new(255, 255, 255);

        public byte R;
        public byte G;
        public byte B;

        public RgbColor(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }

        public RgbColor() : this(0, 0, 0)
        {
        }

        public readonly override string ToString()
        {
            return $"#{R:X2}{G:X2}{B:X2}";
        }
    }
}
