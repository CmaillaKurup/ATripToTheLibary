﻿using System;
using System.Collections.Generic;

namespace ATripToTheLibary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Book> b = new List<Book>();
            
            b.Add(new Book(){Titel = "Asterix", Genre = "Children"});
            b.Add(new Book(){Titel = "I Østen Stiger Solen Op", Genre = "Religion"});
            b.Add(new Book(){Titel = "Romeo and Juliet", Genre = "Drama"});
            b.Add(new Book(){Titel = "Out of control", Genre = "Crime"});
            
            Console.WriteLine();
            foreach (Book aPart in b)
            {
                Console.WriteLine(aPart);
            }
                


            //Stack<BookManager> sbm = new Stack<BookManager>();
            //sbm.Push();

        }
    }
}