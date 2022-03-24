using System;
using System.Collections.Generic;
using Task;

namespace ManagerTask
{
    /// <summary>
    /// Clasa Manager va crea o lista cu toate sarcinile
    /// si metodele de adaugare si stergere a sarcinilor.
    /// </summary>
    public sealed class ManageClass
    {
        static ManageClass _instance = null;

        /// <summary>
        /// Lista ce va contine sarcinile.
        /// /// </summary>
        public List<TaskClass> listTask;

       
        public int nr;

      
        /// <summary>
        /// Constructorul clasei ManageClass ce va instantia lista de sarcini.
        /// /// </summary>
        private ManageClass()
        {
            nr = 5;
            listTask = new List<TaskClass>();
        }

        /// <summary>
        /// Metoda ce impune clasei ManageTask sa fie instantiata o singura data (SingleTon).
        /// </summary>
        public static ManageClass Instance()
        {
            if (_instance == null)
                _instance = new ManageClass();
            return _instance;
        }

        /// <summary>
        /// Metoda ce va adauga sacina in lista de sarcini.
        /// /// </summary>

        public string AddTask(TaskClass t)
        {
            if (Contains(t))
            {
                /// <summary>
                /// In cazul in care sarcina exista in lista, aceasta nu va fi adaugata a doua oara.
                /// /// </summary>
                return "Exista deja";

            }
            listTask.Add(t);
            return "task adaugat";
        }

        /// <summary>
        /// Metoda ce va sterge sarcina din lista de sarcini.
        /// /// </summary>
        public string DeleteTask(TaskClass t)
        {
            for (int i = 0; i < listTask.Count; i++)
            {
                /// <summary>
                /// Conditie ce verifica daca sarcina ce se doreste a fi stearsa exista in lista de sarcini.
                /// /// </summary>
                if (t.TaskName == listTask[i].TaskName)
                {
                    listTask.RemoveAt(i);
                    return "Task Sters";
                }
            }
            return "Task inexistent";
        }

        /// <summary>
        /// Metoda ce va cauta o sarcina in lista de sarcini.
        /// /// </summary>
        public bool Contains(TaskClass t)
        {
            for (int i = 0; i < listTask.Count; i++)
            {
                if (t.TaskName == listTask[i].TaskName)
                    return true;
            }
            return false;
        }
    }
}
