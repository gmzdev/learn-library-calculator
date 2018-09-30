﻿using CommonTypesLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutputLibrary
{
    public class InputService : IInputService
    {
        public string ReadCommand()
        {
            Console.Write("Operation: ");
            return Console.ReadLine();
        }

        public Arguments ReadArguments()
        {
            Console.Write("Value 1: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Value 2: ");
            int y = int.Parse(Console.ReadLine());

            return new Arguments()
            {
                X = x,
                Y = y
            };
        }
    }
}
