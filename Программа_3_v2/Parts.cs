using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Immutable;
using System.Collections.ObjectModel;

namespace Программа_3_v2
{
    public class Part1
    {
        private static readonly List<string> _poem = new();
        public static ImmutableList<string> Poem
        {
            get
            {
                return _poem.ToImmutableList();
            }
        }
        public static void AddPart(List<string> list)
        {
            _poem.AddRange(list);
        }
    }
    public class Part2
    {
        private static readonly List<string> _poem = new();
        public static ImmutableList<string> Poem
        {
            get
            {
                return _poem.ToImmutableList();
            }
        }
        public static void AddPart(List<string> list)
        {
            _poem.AddRange(list);
        }
    }
    public class Part3
    {
        private static readonly List<string> _poem = new();
        public static ImmutableList<string> Poem
        {
            get
            {
                return _poem.ToImmutableList();
            }
        }
        public static void AddPart(List<string> list)
        {
            _poem.AddRange(list);
        }
    }
}
