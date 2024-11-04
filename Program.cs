using System;

namespace DelegateSpace
{

    class Program
    {
       
        public delegate int DelegateOne(string word1);
        public delegate string DelegateTwo(string var1, string var2);

        static void Main(string[] args)
        {
           
            string word1 = "Hello World!1!!";
            string var1 = "Go get ";
            string var2 = "the money";
            DelegateOne ReturnLength = (string word1) =>
            {
                Console.WriteLine("Your string: " + word1);
                Console.WriteLine("Length: " + word1.Length);
                return word1.Length;
            };
            ReturnLength(word1);
            DelegateTwo Concut = (string var1, string var2) => 
            {
                string result = var1 + var2;
                Console.WriteLine("Concatenated variables: " + result);
                return result;
            };
            Concut(var1, var2);

        }
    }

}