using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface ICodeChecker
    {
        bool CheckCodeSyntax(string code, string language);
    }
}
