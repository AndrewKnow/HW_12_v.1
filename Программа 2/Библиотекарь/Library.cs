using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    public class Library
    {
        public static readonly ConcurrentDictionary<string, Percent> dictionary = new();
    }
}
