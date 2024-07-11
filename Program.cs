using System;

namespace TaskManagerApp
{
    // creating the Program class
    class Program
    {
        static void Main(string[] args)
        {
            // creating a new TaskManager object  
            TaskManager taskManager = new TaskManager();
 	    
	    // creating int variable choice that will take user input 
	
            int choice;
            // Giving the user 5 choices and asking them to pick a choice
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

