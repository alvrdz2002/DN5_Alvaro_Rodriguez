﻿using System;
using System.Data;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = "This a string";
            int age = 35;
            DateTime now = DateTime.Now;

            double amount = 0;

            string string2 = text + " a second string " + age + now + amount;

            string string3 = string.Format("The age is {0}, the time is {1}, and te amount is {2}", age, now, amount);

            string string4 = $"The age is {age}, the time is {now}, and te amount is {amount}";

            char sampleChar = 'C';
            char[] arrayChar = string4.ToCharArray();

            amount = (double)10 / (double)3;

            DateTime dateTime = new DateTime(2000, 1, 1);

            var timeStamp1 = now - dateTime;
            //var otherText = "this is a text";

            Console.WriteLine(timeStamp1.TotalMilliseconds);

            Console.ReadKey();

        }
    }
}
