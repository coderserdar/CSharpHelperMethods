using System;
using System.Globalization;
using System.Text;
using static System.String;

namespace CSharpHelperMethods.Library
{
    /// <summary>
    /// Alfa numerik sıralama için hazırlanmış bir metod
    /// </summary>
    public static class SiralamaIslemleri
    {
        private enum ChunkType { Alphanumeric, Numeric }

        private static bool InChunk(char ch, char otherCh)
        {
            var type = ChunkType.Alphanumeric;

            if (char.IsDigit(otherCh))
            {
                type = ChunkType.Numeric;
            }

            return (type != ChunkType.Alphanumeric || !char.IsDigit(ch)) && (type != ChunkType.Numeric || char.IsDigit(ch));
        }

        public static int Compare(string x, string y)
        {
            if (IsNullOrEmpty(x) || IsNullOrEmpty(y)) return 0;
            var thisMarker = 0;
            var thatMarker = 0;

            while (thisMarker < x.Length || thatMarker < y.Length)
            {
                if (thisMarker >= x.Length)
                {
                    return -1;
                }
                if (thatMarker >= y.Length)
                {
                    return 1;
                }

                var thisCh = x[thisMarker];
                var thatCh = y[thatMarker];

                var thisChunk = new StringBuilder();
                var thatChunk = new StringBuilder();

                while (thisMarker < x.Length && (thisChunk.Length == 0 || InChunk(thisCh, thisChunk[0])))
                {
                    thisChunk.Append(thisCh);
                    thisMarker++;

                    if (thisMarker < x.Length)
                    {
                        thisCh = x[thisMarker];
                    }
                }

                while (thatMarker < y.Length && (thatChunk.Length == 0 || InChunk(thatCh, thatChunk[0])))
                {
                    thatChunk.Append(thatCh);
                    thatMarker++;

                    if (thatMarker < y.Length)
                    {
                        thatCh = y[thatMarker];
                    }
                }

                var result = 0;
                // If both chunks contain numeric characters, sort them numerically
                if (char.IsDigit(thisChunk[0]) && char.IsDigit(thatChunk[0]))
                {
                    var thisNumericChunk = Convert.ToInt64(thisChunk.ToString());
                    var thatNumericChunk = Convert.ToInt64(thatChunk.ToString());

                    if (thisNumericChunk < thatNumericChunk)
                    {
                        result = -1;
                    }

                    if (thisNumericChunk > thatNumericChunk)
                    {
                        result = 1;
                    }
                }
                else
                {
                    var ci = new CultureInfo("tr-TR");
                    result = String.Compare(thisChunk.ToString(), thatChunk.ToString(), true,
                        ci);
                    //result = thisChunk.ToString().CompareTo(thatChunk.ToString());
                }

                if (result == 0) continue;
                return result;
            }
            return 0;
        }
    }
}
