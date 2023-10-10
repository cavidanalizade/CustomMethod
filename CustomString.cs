using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class CustomString
    {
        public static string str;


   
        public static void Lengthh(string str)
        {
            int length = 0;
            foreach (var item in str)
            {
                length++;
            }
            Console.WriteLine(length);
        }
        public static void StartWith( char x)
        {
            if (x == str[0])
            {
                Console.WriteLine("is equal");
            }
            else
            {
                Console.WriteLine("isn't equal");
            }

        }
        public static void IndexOf( string str ,char x) 
        { 
            for (int i = 0; i < str.Length; i++)
            {
                if ((char)str[i] == x)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void LastIndexOf(string str , char x)
        {
            for(int i = str.Length - 1; i >= 0; i--)
            {
                if ((char)str[i] == x)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static string Remove (string str , int x)
        {
            string newstr = " ";
            
            for (int i =0; i<x;i++)
            {
                newstr += str[i];
            }
            return newstr;
        }

        
        public static string Join(char seperator , params string [] strArray)
        {
        StringBuilder stringBuilder = new StringBuilder();
            for(int i=0; i<strArray.Length; i++)
            {
                stringBuilder.Append(seperator + strArray[i]);  
            }
            return stringBuilder.ToString();
        }



            
    }
}
