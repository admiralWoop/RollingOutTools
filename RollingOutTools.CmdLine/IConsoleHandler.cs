﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RollingOutTools.CmdLine
{
    public interface IConsoleHandler
    {
        void Write(string str, ConsoleColor? consoleColor);
        void WriteLine(string str, ConsoleColor? consoleColor);
        void WriteLine();
        string ReadLine();
        string ReadJson(string jsonPrototypeString);
    }
}
