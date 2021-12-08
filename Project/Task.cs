using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MainApp
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Task
    {
        private static readonly int[] OutputSizes = {7, 7, 40, 7, 7};
        [JsonProperty] private int _taskID;
        [JsonProperty] private int _expGet;
        [JsonProperty] private string _description;
        [JsonProperty] private int _diamondGet;
        [JsonProperty] private bool _isDone;

        
        public Task(int id, int expGet, string description, int diamondGet, bool isDone)
        {
            _taskID = id;
            _expGet = expGet;
            _description = description;
            _diamondGet = diamondGet;
            _isDone = isDone;
        }
        
        public static void ShowTitle()
        {
            string[] output = {"ID", "Exp", "Description", "Gems", "Done"};
            PrintResultWithPadding(output);
        }
        public void ShowTask()
        {
            string[] output = {_taskID.ToString(), _expGet.ToString(), _description, _diamondGet.ToString(), _isDone.ToString()};
            PrintResultWithPadding(output);
        }

        private static void PrintResultWithPadding(string[] datas)
        {
            if(datas.Length != OutputSizes.Length)
            {
                Console.WriteLine("Error: Padding array size is different from element parametes");
                return;
            }
            for (int i = 0;i < datas.Length;i++)
            {
                Console.Write(datas[i].PadRight(OutputSizes[i]));
            }
            Console.WriteLine();
        }

    }
}