using System;
namespace MainApp
{
    public class TaskManager
    {
        public List<Task> tasks;
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

        public void ShowTask()
        {
            Task.ShowTitle();
            foreach (Task task in tasks)
            {
                task.ShowTask();
            }
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
        }
    }
}