using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;

namespace Программа_3
{
    class Program
    {

        //private static ImmutableList<string> immutableList = ImmutableList.Create<string>();


        private static ImmutableList<string>.Builder builder = ImmutableList.CreateBuilder<string>();


        static void Main()
        {
            builder.Add("1111");
            ImmutableList<string> list1 = builder.ToImmutable();

            Part1.AddPoem(list1);


            Part2.AddPoem(Part1.Poem);

            //Console.WriteLine(Part3._list);

            //Console.WriteLine(Part2.Poem.ToString());



            for (int i = 0; i<= Part2._list.Count - 1; i++)
            {
                Console.WriteLine(Part1._list[i]);

            }



            //Part2.AddPoem(Part1.Poem);
            //Part3.AddPoem(Part2.Poem);
            //Part4.AddPoem(Part3.Poem);
            //Part5.AddPoem(Part4.Poem);
            //Part6.AddPoem(Part5.Poem);
            //Part7.AddPoem(Part6.Poem);
            //Part8.AddPoem(Part7.Poem);
            //Part9.AddPoem(Part8.Poem);

        }
    }


}
