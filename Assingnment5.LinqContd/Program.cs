using System;
using System.Linq;
using System.Collections.Generic;

namespace Assingnment5.linqContd
{
    public class Program
    {
        static void Main()
        {



            //QUESTION 1

            string[] contains = {  "abstract", "add*", "alias*", "as", "ascending*",
             "async*", "await*", "base","bool", "break",
             "by*", "byte", "case", "catch", "char", "checked",
             "class", "const", "continue", "decimal", "default",
             "delegate", "descending*", "do", "double",
             "dynamic*", "else", "enum", "event", "equals*",
             "explicit", "extern", "false", "finally", "fixed",
             "from*", "float", "for", "foreach", "get*", "global*",
             "group*", "goto", "if", "implicit", "in", "int",
             "into*", "interface", "internal", "is", "lock", "long",
             "join*", "let*", "nameof*", "namespace", "new", "null",
             "object", "on*", "operator", "orderby*", "out",
             "override", "params", "partial*", "private", "protected",
             "public", "readonly", "ref", "remove*", "return", "sbyte",
             "sealed", "select*", "set*", "short", "sizeof",
             "stackalloc", "static", "string", "struct", "switch",
             "this", "throw", "true", "try", "typeof", "uint", "ulong",
             "unsafe", "ushort", "using", "value*", "var*", "virtual",
             "unchecked", "void", "volatile", "where*", "while", "yield*" };


            var lowercase = contains.Where(x => x.Contains("e"))
                                      .OrderBy(x => x);
            Console.WriteLine("WORDS WITH e:");
            foreach(var item in lowercase)
            {

                Console.WriteLine(item);
            }

            Console.WriteLine("\n");
            Console.WriteLine("LAST WORD IN SORTED LIST");
            var obtain = lowercase.Last();
            Console.WriteLine(obtain);

            Console.WriteLine("\n");
            Console.WriteLine("WORDS THAT CONTAIN *");
            var wordswith = contains.Where((x) => x.Contains("*"))
                                    .OrderBy(x => x);
            foreach(var item in wordswith)
            {
                Console.WriteLine(item);
            }








            Console.WriteLine("\n");







            //QUESTION 2
            var employeelist = Employee.GetEmployees();

            //People with LastName starts with D

            var lastNameStartWithD = employeelist.Where(x => x.LastName.StartsWith("D"));

            foreach (var item in lastNameStartWithD)
            {
                Console.WriteLine( $"Last Name: {item.LastName}");
            }

            Console.WriteLine("\n");
            //First person older than 40 in Descending Order

            var olderthan40 = employeelist.Where(x => x.Age > 40)
                                           .OrderByDescending(x => x.FirstName);


            foreach (var item in olderthan40)
            {
                Console.WriteLine( $"First Name: {item.FirstName}   Last Name: {item.LastName}  Age: {item.Age}");
            }

            Console.WriteLine("\n");


            //QUESTION 3
            string[] nonempty = { "plane", "ferry", "car", "bike" };

            var contain = nonempty.OrderBy(x => x);

            foreach (var item in contain)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");

            var wordContains = nonempty.First();
            Console.WriteLine(wordContains);
            



















        }  


    }




}


        


