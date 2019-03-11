// NOTE: You'll need to create a container inside this class to store the todos
//  This container should only be accessible from within the class.


// NOTE: There are additional methods used in Program.cs that need
// to be added to this class
using System;
using System.Collections.Generic;
using System.Linq;

namespace Todos
{

    public class TodoList
    {


        public TodoList()
        {
            ToDoList = new List<Todo>();
        }
        // Add a new todo to the front of the todo list
        // add the appropriate code to complete this method

        public List<Todo> ToDoList { get; set; }
        public void AddTopPriorityTodo(Todo todo)
        {
            ToDoList.Insert(0, todo);
        }

        // Add a new todo to the end of the todo list
        public void AddLeastPriorityTodo(Todo todo)
        {
            ToDoList.Add(todo);
        }
        public void ListTodos()
        {
            foreach (Todo todo in ToDoList)
            {
                Console.WriteLine($"Todo: {todo.Text} IsComplete: {todo.IsComplete} Due: {todo.DueDate.ToShortDateString()}");
            }
        }

        public Todo GetElementAt(int index)
        {
            return ToDoList[index];
        }

        // For the GetTopPriorityTodo() method
        //  If the includeCompleted parameter is false AND
        //  ALL of the Todos are complete, you should return null;
        // add the appropriate code to complete this method
        public Todo GetTopPriorityTodo(bool includeCompleted)
        {
            foreach (Todo todo in ToDoList)
            {
                Todo highestPriority;

                if (includeCompleted == false){
                    highestPriority = ToDoList.Where(x => !x.IsComplete== true).OrderBy(y => y.DueDate).FirstOrDefault();
                }
                else{
                    highestPriority = ToDoList.OrderBy(x => x.DueDate).FirstOrDefault();
                }
            return highestPriority;
            }
        }
    }
}

