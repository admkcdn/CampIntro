﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using GenericsIntro;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
          MyList<string> list = new MyList<string>();
            list.Add("Engin");
        }
    }
}