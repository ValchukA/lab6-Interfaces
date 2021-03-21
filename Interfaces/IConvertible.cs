using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IConvertible
    {
        string ConvertToCSharp(string code);

        string ConvertToVB(string code);
    }
}
