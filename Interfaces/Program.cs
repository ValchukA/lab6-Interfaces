using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main()
        {
            List<ProgramConverter> converters = new List<ProgramConverter>
            {
                new ProgramConverter(),
                new ProgramHelper(),
                new ProgramHelper(),
                new ProgramConverter(),
                new ProgramHelper()
            };

            string code = "code";
            string language = "assembly";

            foreach (var converter in converters)
            {
                if (converter is ICodeChecker c)
                {
                    if (c.CheckCodeSyntax(code, language))
                    {
                        Console.WriteLine($"Code in {language}: {code}");
                        Console.WriteLine($"C#: {converter.ConvertToCSharp(code)}");
                        Console.WriteLine($"VB: {converter.ConvertToVB(code)}");
                    }
                }
            }
        }
    }
}
