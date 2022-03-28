using System;
using System.Collections.Generic;

namespace StringLibrary{

        public class ExportaParaFsharp
    {   
        
        public float SomeNumber {get; set;}

        public List<string> NotesInTheScale(){

            return new List<string> {"Dó", "Ré", "Mi"};

        }
        public string UseDelegate
        (
            Func<int, string> d,
            int arg
        ){
            string s = d(arg);
            return $"The delegate returned {s}";
        }

    }
}

