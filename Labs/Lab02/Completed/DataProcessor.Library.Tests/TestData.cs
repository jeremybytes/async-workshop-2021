﻿using System.Collections.Generic;

namespace DataProcessor.Library.Tests
{
    public static class TestData
    {
        public static List<string> Data = new List<string>()
        {
            "1,John,Koenig,1975/10/17,6,",
            "INVALID RECORD FORMAT",
            "2,Dylan,Hunt,2000/10/02,8,",
            "3,Leela,Turanga,1999/3/28,8,{1} {0}",
            "4,John,Crichton,1999/03/19,7,",
            "20,Check,Date,0/2//,9,{1} {0}",
            "5,Dave,Lister,1988/02/15,9,",
            "BAD RECORD",
            "6,Laura,Roslin,2003/12/8,6,",
            "7,John,Sheridan,1994/01/26,6,",
            "8,Dante,Montana,2000/11/01,5,",
            "21,Check,Rating,2014/05/03,a,",
            "9,Isaac,Gampu,1977/09/10,4,",
        };

        public static List<string> GoodRecord =
            new List<string>() { "1,John,Koenig,1975/10/17,6," };

        public static List<string> BadRecord =
            new List<string>() { "BAD RECORD" };

        public static List<string> BadStartDate =
            new List<string>() { "Check,Date,0/2//,9,,{1} {0}" };

        public static List<string> BadRating =
            new List<string>() { "Check,Rating,2014/05/03,a," };

    }
}
