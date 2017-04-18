using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TOkenizer
    {
        private int index = 0;
        private String str;
        public TOkenizer(String s) { str = s; }
        public Token getToken()
        {
            Token T = new Token();
            if (Char.IsDigit(str[index]))
            {
                T.Type = TokenType.enumeric;
                T.Value = str[index].ToString();
            }
            else
            {
                T.Type = TokenType.operation;
                T.Value = str[index].ToString();
            }
            index++;
            return T;
        }
        public bool is_finished() { return str.Length != index; }
        
    }
    enum TokenType { enumeric, operation };
    class Token
    {
        public String Value;
        public TokenType Type;
    }
    class Parser
    {
        public void main_calculator(string ss) {

            TOkenizer obj1 = new TOkenizer(ss);
            while (obj1.is_finished())
            {
                Token _res = obj1.getToken();
                Console.WriteLine(_res.Value);
            }
        }
    }
    
    class Program
    {
        static void Main()
        {
           string s = Console.ReadLine();
           Parser p = new Parser();
            p.main_calculator(s);
        }
    }
}
