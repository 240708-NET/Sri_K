using System;

namespace TaskManagerApp
{
    // creating the Program class
    class Program
    {
        static void Main(string[] args)
        {
            // 
            TaskManager taskManager = new TaskManager();

            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Task Manager");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Complete Task");
                Console.WriteLine("4. Delete Task");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        taskManager.AddTask();
                        break;
                    case 2:
                        taskManager.ViewTasks();
                        break;
                    case 3:
                        taskManager.CompleteTask();
                        break;
                    case 4:
                        taskManager.DeleteTask();
                        break;
                }

            } while (choice != 5);
        }
    }
}

