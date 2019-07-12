﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var sing = Singleton.GetInstance();
            Console.WriteLine(sing.Date);
            Console.Read();
        }
    }
}
