using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
namespace TelCo.ColorCoder
{
    /// data type defined to hold the two colors of clor pair
    /// </summary>
    internal class ColorPair
    {
        internal Color majorColor;
        internal Color minorColor;
        public static Color[] colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
        public static Color[] colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
        }
        public static void Colorcodemanual()
        {
            ColorPair testPair2;
            string format = "{0,-15} {1,-15} {2,-15}" + Environment.NewLine;
            var stringBuilder = new StringBuilder().AppendFormat(format, "Pair number", "Major color", "Minar color");
            for (int pairNumber = 1; pairNumber <= 25; pairNumber++)
            {
                testPair2 = GetColorFromPairNumber_Type.GetColorFromPairNumber(pairNumber);
                stringBuilder.AppendFormat(format, pairNumber, testPair2.majorColor.Name, testPair2.minorColor.Name);
            }
            Console.WriteLine(stringBuilder);
        }
    }
}
