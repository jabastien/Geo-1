﻿using System;

namespace Geo.Geomagnetism.Models
{
    public class Wmm1985 : IGeomagneticModel
    {
        public GeomagnetismSource Source { get { return  GeomagnetismSource.Wmm; } }
        public DateTime ValidFrom { get { return new DateTime(1985, 1, 1);} }
        public DateTime ValidTo { get { return new DateTime(1990, 1, 1); } }

        public double[,] MainCoefficientsG
        {
            get
            {
                return new[,]
                {
                    { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                    { -29879.8, -1903.3, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { -2070.6, 3040.8, 1696.7, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 1303.9, -2203, 1241.7, 839.4, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 933.8, 781.8, 359, -424.5, 164.5, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                    { -216.4, 353, 254.3, -93.7, -157.5, -45.2, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 53.2, 63.8, 51.3, -188.4, 3.3, 20.3, -101.7, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 76.9, -60.7, 0.7, 25.4, -8.1, 6.9, 7, -4.4, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 18.4, 5.1, 1.2, -12, -9.1, 0.1, 4.7, 6.5, -9.5, 0.0, 0.0, 0.0, 0.0 }, 
                    { 5.7, 10.9, 0.9, -12.2, 9.5, -3.3, -1, 6.5, 1.5, -4.8, 0.0, 0.0, 0.0 }, 
                    { -3.4, -4.7, 2.5, -5.5, -2.1, 4.6, 3.2, 0.6, 1.9, 2.8, -0.2, 0.0, 0.0 }, 
                    { 2.3, -0.8, -2, 2.1, 0.2, -0.4, -0.4, 1.6, 1.5, -0.7, 2.3, 3.5, 0.0 }, 
                    { -1.8, 0.0, 0.1, -0.3, 0.5, 0.5, -0.6, -0.4, 0.0, -0.5, 0.0, 0.7, -0.2 }
                };
            }
        }

        public double[,] MainCoefficientsH
        {
            get
            {
                return new[,]
                {
                    { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                    { 0.0, 5490.5, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 0.0, -2189.1, -312, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 0.0, -310.3, 282.6, -299.2, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 0.0, 227.2, -246.7, 72.5, -299.1, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 0.0, 43.4, 148.2, -154.8, -71.8, 91.5, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 0.0, -12.3, 87.9, 67.8, -51.1, -4, 20.8, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 0.0, -80.1, -25.9, -0.9, 21.6, 18.5, -20, -7.7, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 0.0, 3.8, -20.2, 5, -24.2, 12.2, 7.6, -16.3, -10.9, 0.0, 0.0, 0.0, 0.0 }, 
                    { 0.0, -20.8, 15.8, 9, -5, -6.4, 9.1, 9.9, -5.8, 2.3, 0.0, 0.0, 0.0 }, 
                    { 0.0, 1.2, 0.4, 2.5, 5.6, -4.4, -0.5, -1.6, 3.7, -0.5, -6.1, 0.0, 0.0 }, 
                    { 0.0, 1.3, 2, -1.1, -2.8, 0.7, -0.1, -2.4, -0.4, -1.5, -1.5, 0.7, 0.0 },
                    { 0.0, 0.3, 0.6, 2.5, -1.7, 0.3, 0.2, -0.1, 0.1, 0.1, -1.4, 0.4, 0.7 }
                };
            }
        }

        public double[,] SecularCoefficientsG
        {
            get
            {
                return new[,]
                {
                    { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                    { 21.9, 10.6, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { -11.2, 1.8, 9.3, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 8.3, -2, -0.6, 2.4, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { -1.2, 0.1, -9.7, -1.7, -9.3, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 1.4, -0.5, -1.2, -2.2, 0.9, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 3.1, 0.0, 1.8, -0.2, -0.4, 2.4, 1.8, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { -0.1, -0.8, -1.2, 1.1, 0.0, 0.6, -1.8, -1.2, 0.0, 0.0, 0.0, 0.0, 0.0 },
                    { 0.2, 0.0, 0.7, 0.1, 0.2, -0.3, -0.1, 0.2, -2.2, 0.0, 0.0, 0.0, 0.0 }, 
                    { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }
                };
            }
        }

        public double[,] SecularCoefficientsH
        {
            get
            {
                return new[,]
                {
                    { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                    { 0.0, -31.5, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 0.0, -9.7, -19.9, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 0.0, 6.1, 1.3, -13, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                    { 0.0, 1.3, 3.6, 2.5, 0.6, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 0.0, -0.9, 0.6, 0.3, 2.4, -1.4, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 0.0, 0.7, -2.1, -1.4, -4.3, -0.7, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 0.0, 0.0, 1.2, 2, 2.6, 0.9, 0.8, 0.4, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 0.0, -0.6, -1.5, 0.1, -1.1, 0.4, -2, 0.9, 1.5, 0.0, 0.0, 0.0, 0.0 }, 
                    { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 
                    { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }
                };
            }
        }
    }
}