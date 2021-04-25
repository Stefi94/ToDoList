using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public static class CheckText
    {
        static string checkText(string text)
        {
            
            text = text.Trim();
            char[] illegalChar = { ':', ' ', '"', };
            if (string.IsNullOrEmpty(text))
            { }
            return text;
        }
    }
}
