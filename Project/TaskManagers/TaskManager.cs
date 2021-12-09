using System;
using CommandLine;
namespace MainApp
{
    public class TaskManager
    {
        public List<Task> tasks;
        public Action<Task> taskAdded;
        public TaskManager()
        {
            if(File.Exists(Enums.TaskInfoDirectory))
            {
                tasks = JSONSaveLoad.ReadFromJsonFile<List<Task>>(Enums.TaskInfoDirectory);
            }
            else 
            {
                tasks = new List<Task>();
                JSONSaveLoad.WriteToJsonFile<List<Task>>(Enums.TaskInfoDirectory, tasks);
            }
        }

        public void SaveTaskData()
        {
            JSONSaveLoad.WriteToJsonFile<List<Task>>(Enums.TaskInfoDirectory, tasks);
        }

        public void ShowTask(bool onlyUncompletedTask)
        {
            Task.ShowTitle();
            foreach (Task task in tasks)
                if((!onlyUncompletedTask) || (!task.IsDone))
            {
                task.ShowTask();
            }
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
            taskAdded.Invoke(task);
        }

        public void RemoveTask(int id)
        {
            tasks.RemoveAll(element => (element.TaskID == id));
        }

        public void CompleteTask(int id)
        {
            foreach(Task task in tasks)
                if(task.TaskID == id)
            {
                task.DoneTask();
            }
        }
        public void ReceiveCommand(TaskOptions opts)
        {
            Parser.Default.ParseArguments<AddOptions, ShowOptions, RemoveOptions, CompleteOptions>(opts.Parameters)
                .WithParsed<AddOptions>(AddTaskBaseOnCmd)
                .WithParsed<ShowOptions>(ShowTaskBaseOnCmd)
                .WithParsed<RemoveOptions>(RemoveOptionBaseOnCmd)
                .WithParsed<CompleteOptions>(CompleteOptionBaseOnCmd);
        }

        private void AddTaskBaseOnCmd(AddOptions opts)
        {
            Task task = new Task(opts.Id, opts.Exp, string.Join(' ',opts.Description), opts.Gem, opts.isDone);
            this.AddTask(task);
        }
        private void ShowTaskBaseOnCmd(ShowOptions opts)
        {
            this.ShowTask(opts.OnlyShowUncompletedTask);
        }

        private void RemoveOptionBaseOnCmd(RemoveOptions opts)
        {
            this.RemoveTask(opts.ID);
        }

        private void CompleteOptionBaseOnCmd(CompleteOptions opts)
        {
            
            this.CompleteTask(opts.ID);
        }
    }
}