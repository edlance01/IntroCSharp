﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviation
{
    public interface ILogger
    {
        void Log(string message);
        void LogWarning(string message);
    }

}
