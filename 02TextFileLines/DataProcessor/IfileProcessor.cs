﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor
{
    public interface IfileProcessor
    {

        string InputFilePath { get; }

        string OutputFilePath { get; }


        void Process();
    }
}
