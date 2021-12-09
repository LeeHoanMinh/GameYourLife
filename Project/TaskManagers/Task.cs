using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MainApp
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Task
    {
        private static readonly int[] paddingSizes = {7, 7, 40, 7, 7};
        public Action<int, int> taskDone;
        [JsonProperty] private int _taskID;
        public int TaskID {get{return _taskID;}}
        [JsonProperty] private int _expGet;
        [JsonProperty] private string _description;
        [JsonProperty] private int _diamondGet;
        [JsonProperty] private bool _isDone;
        public bool IsDone {get{return _isDone;}}

        [JsonConstructor]
        public Task(int id, int expGet, string description, int diamondGet, bool isDone)
        {
            _taskID = id;
            _expGet = expGet;
            _description = description;
            _diamondGet = diamondGet;
            _isDone = isDone;
        }
        
        
        public Task(string id, string expGet, string description, string diamondGet, string isDone)
        {
            _taskID = Int32.Parse(id);
            _expGet = Int32.Parse(expGet);
            _description = description;
            _diamondGet = Int32.Parse(diamondGet);
            _isDone = bool.Parse(isDone);
        }
        

        public void DoneTask()
        {
            if(!_isDone)
            {
                taskDone.Invoke(_expGet, _diamondGet);
                _isDone = true;
            }
            else Console.WriteLine("You have already done this task!!!");
        }
        public static void ShowTitle()
        {
            string[] output = {"ID", "Exp", "Description", "Gems", "Done"};
            ConsoleDisplay.PrintResultWithPadding(output, paddingSizes);
        }
        public void ShowTask()
        {
            string[] output = {_taskID.ToString(), _expGet.ToString(), _description, _diamondGet.ToString(), _isDone.ToString()};
            ConsoleDisplay.PrintResultWithPadding(output, paddingSizes);
        }
    }
}