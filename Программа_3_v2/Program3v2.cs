using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;

namespace Программа_3_v2
{
    class Program3v2
    {
        private static readonly List<string> _myCollection = new List<string>() {};


        static void Main()
        {

            _myCollection.Add("Вот дом");
            _myCollection.Add("Который построил Джек.");
            Part1.AddPart(_myCollection);
            _myCollection.Clear();



            _myCollection.Add("А это пшеница,");
            _myCollection.Add("Которая в темном чулане хранится");
            _myCollection.Add("В доме,");
            _myCollection.Add("Который построил Джек.");

            Part2.AddPart(_myCollection);


            for (int i = 0; i < Part2.Poem.Count; i++)
            {

                Console.WriteLine(Part2.Poem[i]);

            }


            

            

        }
        //ImmutableListCreate("123");
        //ImmutableListCreate("456");



        //var immutableList = ImmutableList<string>.Empty;
        //var newImmutableList = immutableList;

        //for (int i = 0; i < 10; i++)
        //{
        //    switch (i)
        //    {
        //        case 0:
        //            newImmutableList = newImmutableList.Add("1");
        //            break;
        //        case 1:
        //            newImmutableList = newImmutableList.Add("2");
        //            break;
        //        case 2:
        //            newImmutableList = newImmutableList.Add("3");
        //            break;

        //    }   
        //}
        //Console.WriteLine(immutableList.Count);
        //Console.WriteLine(newImmutableList.Count);

        //public static ImmutableList<string> ImmutableListCreate(string text)
        //{
        //    return ImmutableList.Create(text);
        //}


    }
}
