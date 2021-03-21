using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class ProgramHelper : ProgramConverter, ICodeChecker
    {
        public bool CheckCodeSyntax(string code, string language) => true;
    }
}
