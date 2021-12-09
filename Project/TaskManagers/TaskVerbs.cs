using System;
using CommandLine;

namespace MainApp
{
    [Verb("add")]
    public class AddOptions 
    {
        [Value(0)]
        public int Id {get;set;}
        [Value(1)]
        public int Exp {get;set;}
        [Option('d')]
        public IEnumerable<string> Description { get; set; }
        [Option('g')]
        public int Gem {get; set;}
        [Value(2)]
        public bool isDone{get; set;}
    }
    [Verb("show")]
    public class ShowOptions
    {
        [Option('i')]
        public bool OnlyShowUncompletedTask{get; set;}
    }
    [Verb("remove")]
    public class RemoveOptions
    {
        [Value(0)]
        public int ID{get; set;}
    }

    [Verb("complete")]
    public class CompleteOptions
    {
        [Value(0)]
        public int ID{get; set;}
    }
}