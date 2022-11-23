﻿using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5; // 1 byte
            sbyte c = 5; // 1 byte

            short s = 5; // 2 byte
            ushort us = 5; // 2 byte

            Int16 i16 = 2; // 2 byte
            int i = 2; // 4 byte
            Int32 i32 = 2; // 4 byte
            Int64 i64 = 2; // 8 byte

            uint ui = 2; // 4 byte
            long l = 2; // 8 byte
            ulong ul = 2; // 8 byte

            float f = 5; // 4  byte
            double d = 5; // 8 byte
            decimal de = 5; // 16 byte

            char ch = '2'; // 2 byte
            string str = "Z"; // Sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 4.5;

            //// String

            string str1 = string.Empty;
            str1 = "ABC";
            string ad = "Yalçın";
            string soyad = "Özcan";
            string tamisim = ad + soyad;

            //// Integer

            int integer1 = 4;
            int integer2 = 56;

            int toplam = integer2 / integer1;

            //// Boolean

            bool bool1 = 10 < 1;

            //// Değişken dönüşümleri

            string str20 = "26";
            int int20 = 20;

            string yenideger = str20 + int20.ToString();
            Console.WriteLine(yenideger);

            int yenideger2 = Convert.ToInt32(str20) + int20;
            Console.WriteLine(yenideger2);

            //// Datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);
            string datetime2 = DateTime.Now.ToString("MM/dd/yyyy");
            Console.WriteLine(datetime2);
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
