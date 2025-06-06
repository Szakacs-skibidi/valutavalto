﻿using System;

namespace ConsoleApp4
{
    public class Class1
    {
        public class ValutaÁtváltó
        {
            private const double HufToDollarRate = 300.0; 
            private const double HufToEurRate = 360.0;    

            public static double HufToDollar(double huf)
            {
                return huf / HufToDollarRate;
            }

            public static double HufToEur(double huf)
            {
                return huf / HufToEurRate;
            }

            public static double DollarToHuf(double dollar)
            {
                return dollar * HufToDollarRate;
            }

            public static double EurToHuf(double eur)
            {
                return eur * HufToEurRate;
            }
        }
    }
}
