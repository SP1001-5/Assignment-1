using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todolist
{
    internal class ToDoList
    {
        public string Task { get; set; }
        public string Priority { get; set; }

        static ArrayList todoArray = new ArrayList();

        //adding tasks with priority into the arraylist
        public void AddTask(string usertask, string userpriority)
        {
            todoArray.Add(new ToDoList { Task = usertask, Priority = userpriority });
        }

        //show the task with priority
        public ArrayList DisplayingToDoList()
        {
            return todoArray;
        }


        //remove task from the arraylist
        public void RemoveTask(string usertask)
        {
            for(int i =0;i<todoArray.Count; i++)
            {
                //Console.WriteLine(item.Task);
                ToDoList item = (ToDoList)todoArray[i];
                if (item.Task == usertask)
                {
                    todoArray.RemoveAt(i);
                    break;
                    //todoArray.Remove(item.Priority);
                }
            }
        }
    }

    internal class Program
    {
            static void Main()
            {
                ToDoList toDoList = new ToDoList();
                int choice;
                do
                {
                    Console.WriteLine("Enter your Choice  1. Add Task   2. DisplayTask   3. RemoveTask");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            string uTask = Console.ReadLine();
                            string uPriority = Console.ReadLine();
                            toDoList.AddTask(uTask, uPriority);
                            Console.WriteLine("Added Task Successfully..");
                            break;
                        case 2:
                            ArrayList displayList = toDoList.DisplayingToDoList();

                            foreach (ToDoList item in displayList)
                            {
                                Console.WriteLine(item.Task + " " + item.Priority);
                            }
                            break;
                        case 3:
                            string removeTask = Console.ReadLine();
                            toDoList.RemoveTask(removeTask);
                            Console.WriteLine("Task Completed and Removed Successfully");
                            break;
                        default:
                            break;
                    }
                } while (choice <= 3);
            }
    }
}
