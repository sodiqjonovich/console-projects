﻿using System;

namespace Restaurant.Helpers
{
    public class StatusHelper
    {
        public static void AcceptedMessage(string message)
        {
            if (OperatingSystem.IsWindows()) Console.Beep(500, 500);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void WrongMessage(string message)
        {
            if (OperatingSystem.IsWindows()) Console.Beep(1000, 500);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
