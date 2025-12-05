using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public struct Color
    {
        public byte R;
        public byte G;
        public byte B;

        public Color()
        {
            R = 0;
            G = 0;
            B = 0;
        }

        public Color(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }

        public Color(string color)
        {
            if (color.Length != 7) throw new ArgumentException($"Colorの文字数は7である必要があります。\n文字数: {color.Length}");
            if (color[0] != '#') throw new ArgumentException($"開始文字は'#'である必要があります。\n初めの文字: {color[0]}");

            byte func(string num)
            {
                try
                {
                    return byte.Parse(num, System.Globalization.NumberStyles.HexNumber);
                }
                catch
                {
                    throw new ArgumentException($"数値の形式が適切ではありません。\n文字列: {color}");
                }
            }

            R = func(color[1..3]);
            G = func(color[3..5]);
            B = func(color[5..7]);
        }

        public readonly override string ToString()
        {
            return $"#{R:X2}{G:X2}{B:X2}";
        }
    }
}
