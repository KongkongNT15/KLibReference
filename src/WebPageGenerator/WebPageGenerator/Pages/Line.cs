using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public sealed class Line : Text
    {
        public Line() : base(Environment.NewLine)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">この値に'\n'を付け足したものがValueになる</param>
        public Line(string value) : base(value + Environment.NewLine)
        {
        }
    }
}
