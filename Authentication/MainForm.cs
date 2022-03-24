
/**************************************************************************
 *                                                                        *
 *  File:        CommandGraph.cs                                          *
 *  Copyright:   (c) 2021, Petrov Sergiu                        *
 *  E-mail:     sergiu.petrov@student.tuiasi.ro                           *
 *  Website:     https://github.com/petrov-sergiu/Proiect_IP              *
 *  Description:  A graph full of commands ready to be used.              *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ManagerTask;
using Task;
using System.Xml.Linq;
using System.Linq;

namespace Authentication
{   /// <summary>
    /// Clasa pentru instantierea panoului in care vor fi afisate sarcinile.
    /// </summary>
    public partial class MainForm : Form
    {
        public ManageClass _manageTask;
        public DrawTask _asd;
        public string userName = "";
        /// <summary>
        /// Constructorul de initializare a componentelor.
        /// </summary>
        /// <param name="numUtil">Numele utilizatorului logat.</param>
        public MainForm(string numUtil)
        {
            InitializeComponent();
            _manageTask = ManageClass.Instance();
            CitireTaskFisier();
            userName = numUtil;
            _asd = new DrawTask();
            UpdateTask();
            labelAut.Text = "Autentificat: " + userName;
        }
        /// <summary>
        /// Functie de citire a sarcinilor dintr-un fisier XML.
        /// </summary>
        private void CitireTaskFisier()
        {
            XDocument fisier = new XDocument();
            try
            {
                fisier = XDocument.Load(Application.StartupPath.ToString() + @"\taskuri.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            var all = from x in fisier.Descendants("task")
                      select new
                      {
                          //salvam datele din XML
                          XMLname = x.Element("name").Value,
                          XMLdetail = x.Element("details").Value,
                          XMLpath = x.Element("pathImage").Value,
                          XMLstatus = x.Element("status").Value,
                          XMLstartDate = x.Element("starTime").Value,
                          XMLendDate = x.Element("endTime").Value,
                          XMLuserName = x.Element("userName").Value
                      };
            foreach (var x in all)
            {
                StatusTask status = StatusTask.TODO;
                switch (x.XMLstatus)
                {
                    case "TODO":
                        status = StatusTask.TODO;
                        break;
                    case "DOING":
                        status = StatusTask.DOING;
                        break;
                    case "DONE":
                        status = StatusTask.DONE;
                        break;
                }

                _manageTask.AddTask(new TaskClass(x.XMLname, x.XMLdetail, x.XMLpath, DateTime.Parse(x.XMLstartDate), DateTime.Parse(x.XMLendDate), status, x.XMLuserName));
            }
        }
        /// <summary>
        /// Buton pentru modificarea unei sarcini.
        /// </summary>
        private void ButtonModifyClick(object sender, EventArgs e)
        {
            Control ac = this.ActiveControl;
            Button p = (Button)sender;
         

            ModifyTask(int.Parse(p.Name));
            UpdateTask();

        }
        /// <summary>
        /// Functia de modificare a unei sarcini.
        /// </summary>
        /// <param name="n">Numarul sarcinii in lista</param>
        private void ModifyTask(int n)
        {
            TaskClass s = null;
            for (int i = 0; i < _manageTask.listTask.Count; i++)
            {
                if (i == n)
                {
                    s = _manageTask.listTask[i];
                    break;
                }
            }
            FormTask f = new FormTask(s);
            f.numeUtil = userName;
            f.ShowDialog();
            if (f.newTask.TaskName != "")
            {
                for (int i = 0; i < _manageTask.listTask.Count; i++)
                {
                    if (i == n)
                    {
                        _manageTask.listTask[i].TaskName = f.newTask.TaskName;
                        _manageTask.listTask[i].TaskEndTime = f.newTask.TaskEndTime;
                        _manageTask.listTask[i].TaskDetails = f.newTask.TaskDetails;
                        _manageTask.listTask[i].TaskPathImage = f.newTask.TaskPathImage;
                        _manageTask.listTask[i].TaskStartTime = f.newTask.TaskStartTime;
                        _manageTask.listTask[i].TasProgress = f.newTask.TasProgress;
                        _manageTask.listTask[i].TaskUserName = f.newTask.TaskUserName;
                        break;
                    }
                }
                ModificaTaskFisier(s, f.newTask);
                UpdateTask();
            }
        }
        /// <summary>
        /// Functie pentru scrierea sarcinii modificate in fisier.
        /// </summary>
        /// <param name="oldTask">Sarcina veche.</param>
        /// <param name="newTask">Sarcina noua.</param>
        private void ModificaTaskFisier(TaskClass oldTask, TaskClass newTask)
        {
            XDocument fisier = new XDocument();
            try
            {
                fisier = XDocument.Load(Application.StartupPath.ToString() + @"\taskuri.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            var q = from node in fisier.Descendants("task")
                    let attr = node.Element("name")
                    where attr != null && (string)attr.Value == oldTask.TaskName
                    select node;
            //q.ToList().
            foreach (var z in q)
            {
                z.Element("name").Value = newTask.TaskName;
                z.Element("status").Value = newTask.TasProgress.ToString();
                z.Element("details").Value = newTask.TaskDetails;
                z.Element("pathImage").Value = newTask.TaskPathImage;
                z.Element("starTime").Value = newTask.TaskStartTime.ToString();
                z.Element("endTime").Value = newTask.TaskEndTime.ToString();
                z.Element("userName").Value = newTask.TaskUserName;
            }
            try
            {
                fisier.Save(Application.StartupPath.ToString() + @"/taskuri.xml");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Buton de stergere a unei saricni.
        /// </summary>
        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            Control ac = this.ActiveControl;
            Button p = (Button)sender;
            
            DeleteTast(int.Parse(p.Name));
            UpdateTask();

        }

        /// <summary>
        /// Functie de stergere a unei sarcini.
        /// </summary>
        /// <param name="n">Numarul sarcinii din lista.</param>
        private void DeleteTast(int n)
        {
            TaskClass s = null;
            for (int i = 0; i < _manageTask.listTask.Count; i++)
            {
                if (i == n)
                {
                    s = _manageTask.listTask[i];
                    _manageTask.listTask.RemoveAt(i);
                    
                    break;
                }
            }
            if (s != null)
            {
                XDocument fisier = new XDocument();
                try
                {
                    fisier = XDocument.Load(Application.StartupPath.ToString() + @"\taskuri.xml");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                var q = from node in fisier.Descendants("task")
                        let attr = node.Element("name")
                        where attr != null && (string)attr.Value == s.TaskName
                        select node;
                q.ToList().ForEach(x => x.Remove());
                try
                {
                    fisier.Save(Application.StartupPath.ToString() + @"/taskuri.xml");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        /// <summary>
        /// Functie de reimprospatare a panoului pe care sunt afisate sarcinile.
        /// </summary>
        public void UpdateTask()
        {
            if (_asd != null)
            {
                foreach (Panel pan in _asd.panels)
                {
                    Controls.Remove(pan);
                }
            }
            _asd = new DrawTask(_manageTask, ButtonDeleteClick, ButtonModifyClick, userName);
            
            foreach (Panel pan in _asd.panels)
            {
                Controls.Add(pan);
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Butonul de redirectionare catre spre panoul FormTask.
        /// </summary>
        private void ButtonAddTask_Click(object sender, EventArgs e)
        {
            FormTask f = new FormTask();
            f.numeUtil = userName;
            f.ShowDialog();
            if (f.newTask.TaskName != "")
            {
                _manageTask.AddTask(f.newTask);
                adaugareTaskFisier();
            }
            UpdateTask();
        }
        /// <summary>
        /// Functie de salvare a unei sarcini in fisier.
        /// </summary>
        private void adaugareTaskFisier()
        {
            XDocument doc = new XDocument(new XElement("Taskuri"));
            try
            {
                doc = XDocument.Load(Application.StartupPath.ToString() + @"/taskuri.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                doc = new XDocument();
            }

            XElement xml = new XElement("task",
                           new XElement("name", _manageTask.listTask[_manageTask.listTask.Count - 1].TaskName),
                           new XElement("details", _manageTask.listTask[_manageTask.listTask.Count - 1].TaskDetails),
                           new XElement("pathImage", _manageTask.listTask[_manageTask.listTask.Count - 1].TaskPathImage),
                           new XElement("status", _manageTask.listTask[_manageTask.listTask.Count - 1].TasProgress),
                           new XElement("starTime", _manageTask.listTask[_manageTask.listTask.Count - 1].TaskStartTime),
                           new XElement("endTime", _manageTask.listTask[_manageTask.listTask.Count - 1].TaskEndTime),
                           new XElement("userName", _manageTask.listTask[_manageTask.listTask.Count - 1].TaskUserName));

            if (doc.Descendants().Count() > 0)
            {
                doc.Descendants().First().Add(xml);
            }
            else
            {
                doc.Add(xml);
            }

            try
            {
                doc.Save(Application.StartupPath.ToString() + @"/taskuri.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Butonul de delogare prezent pe panoul in care sunt afisate sarcinile.
        /// </summary>
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            new FormAuth().Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
