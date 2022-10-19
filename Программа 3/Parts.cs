using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Программа_3
{


    public  class Part1
    {
        public static readonly List<string> _list = new();
        public static List<string> Poem
        {
            get
            {
                return _list;
            }
        }

        public static void AddPoem(ImmutableList<string> list)
        {
            Poem.AddRange(list);
        }

    }
    public class Part2
    {
        public static readonly List<string> _list = new();
        public static List<string> Poem
        {
            get
            {
                return _list;
            }
        }

        public static void AddPoem(ImmutableList<string> list)
        {
            Poem.AddRange(list);
        }
    }

    public class Part3
    {
        public static readonly List<string> _list = new();
        public static List<string> Poem
        {
            get
            {
                return _list;
            }
        }

        public static void AddPoem(ImmutableList<string> list)
        {
            Poem.AddRange(list);
        }
    }




    //class Part3
    //{
    //    private static readonly List<string> _list = new List<string>();
    //    public static ImmutableList<string> Poem
    //    {
    //        get
    //        {
    //            return _list.ToImmutableList();
    //        }
    //    }

    //    public static void AddPoem(ImmutableList<string> list)
    //    {
    //        Poem.AddRange(list);
    //    }
    //}
    //class Part4
    //{
    //    private static readonly List<string> _list = new List<string>();
    //    public static ImmutableList<string> Poem
    //    {
    //        get
    //        {
    //            return _list.ToImmutableList();
    //        }
    //    }

    //    public static void AddPoem(ImmutableList<string> list)
    //    {
    //        Poem.AddRange(list);
    //    }
    //}
    //class Part5
    //{
    //    private static readonly List<string> _list = new List<string>();
    //    public static ImmutableList<string> Poem
    //    {
    //        get
    //        {
    //            return _list.ToImmutableList();
    //        }
    //    }

    //    public static void AddPoem(ImmutableList<string> list)
    //    {
    //        Poem.AddRange(list);
    //    }
    //}
    //class Part6
    //{
    //    private static readonly List<string> _list = new List<string>();
    //    public static ImmutableList<string> Poem
    //    {
    //        get
    //        {
    //            return _list.ToImmutableList();
    //        }
    //    }

    //    public static void AddPoem(ImmutableList<string> list)
    //    {
    //        Poem.AddRange(list);
    //    }
    //}

    //class Part7
    //{
    //    private static readonly List<string> _list = new List<string>();
    //    public static ImmutableList<string> Poem
    //    {
    //        get
    //        {
    //            return _list.ToImmutableList();
    //        }
    //    }

    //    public static void AddPoem(ImmutableList<string> list)
    //    {
    //        Poem.AddRange(list);
    //    }
    //}
    //class Part8
    //{
    //    private static readonly List<string> _list = new List<string>();
    //    public static ImmutableList<string> Poem
    //    {
    //        get
    //        {
    //            return _list.ToImmutableList();
    //        }
    //    }

    //    public static void AddPoem(ImmutableList<string> list)
    //    {
    //        Poem.AddRange(list);
    //    }
    //}
    //class Part9
    //{
    //    private static readonly List<string> _list = new List<string>();
    //    public static ImmutableList<string> Poem
    //    {
    //        get
    //        {
    //            return _list.ToImmutableList();
    //        }
    //    }

    //    public static void AddPoem(ImmutableList<string> list)
    //    {
    //        Poem.AddRange(list);
    //    }
    //}
}
