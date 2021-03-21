using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class ProgramConverter : IConvertible
    {
        public string ConvertToCSharp(string code) => "C# code.";

        public string ConvertToVB(string code) => "VB code.";
    }
}
