using System;
using CommandLine;

namespace MainApp
{
    [Verb("player")]
    public class PlayerOptions
    {
        [Value(0)]
        public IEnumerable<string> Parameters { get; set; }
    }

    [Verb("task")]
    public class TaskOptions
    {
        [Value(0)]
        public IEnumerable<string> Parameters{ get; set; }
    }
}