using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiStudy.Utilities
{
    class RadianDegreeConverter
    {
        public double ConvertToDegree(int integralPart, int fractionalPart)
        {
            var us1 = (ushort)integralPart;
            var us2 = (ushort)fractionalPart;

            uint binary32Bit = (uint)((us1 << 16) | us2);
            float degree = BitConverter.ToSingle(BitConverter.GetBytes(binary32Bit), 0);
            return (double)degree;
        }

        public double ConvertToRadian(int integralPart, int fractionalPart)
        {
            var us1 = (ushort)integralPart;
            var us2 = (ushort)fractionalPart;

            double radian = ConvertToDegree(us1, us2) * Math.PI / 180;
            return radian;
        }
    }
}
