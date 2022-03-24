
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
using Task;
using ManagerTask;

namespace Authentication
{
    /// <summary>
    /// Panoul de adaugare a unei sarcini.
    /// </summary>
    public partial class FormTask : Form
    {
        public string _path;
        public TaskClass newTask;
        public string numeUtil = "";
        /// <summary>
        /// Constructor pentru initializarea panoului.
        /// </summary>
        public FormTask()
        {
            InitializeComponent();
            comboBoxTaskStatus.Items.Add("TODO");
            comboBoxTaskStatus.Items.Add("DOING");
            comboBoxTaskStatus.Items.Add("DONE");
            AddButton.Enabled = true;
            ModifyButton.Enabled = false;
        }

        /// <summary>
        /// Constructor pentru initializarea panoului cu datale unei sarcini.
        /// </summary>
        /// <param name="t">Numele sarcinii</param>
        public FormTask(TaskClass t)
        {
            InitializeComponent();
            comboBoxTaskStatus.Items.Add("TODO");
            comboBoxTaskStatus.Items.Add("DOING");
            comboBoxTaskStatus.Items.Add("DONE");
            textBoxTaskName.Text = t.TaskName;
            dateTimePickerTaskStartDate.Value = t.TaskStartTime;
            dateTimePickerTaskFinishDate.Value = t.TaskEndTime;
            switch (t.TasProgress.ToString())
            {
                case "TODO":
                    comboBoxTaskStatus.SelectedIndex = 0;
                    break;
                case "DOING":
                    comboBoxTaskStatus.SelectedIndex = 1;
                    break;
                case "DONE":
                    comboBoxTaskStatus.SelectedIndex = 2;
                    break;
            }
            Image newImage = Image.FromFile("imagini/" + t.TaskPathImage);
            pictureBoxTaskPhoto.Image = (Image)(new Bitmap(newImage, new Size(135, 122)));
            AddButton.Enabled = false;
            ModifyButton.Enabled = true;
        }

        private void textBoxTaskName_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxTaskNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerTaskStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerTaskFinishDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxTaskPhoto_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTaskStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Buton de adaugare a unei sarcini.
        /// </summary>

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = textBoxTaskName.Text;
            DateTime startTime = dateTimePickerTaskStartDate.Value;
            DateTime endTime = dateTimePickerTaskFinishDate.Value;
            string description = richTextBoxTaskNote.Text;
            int statusIndex = comboBoxTaskStatus.SelectedIndex;
            StatusTask status;
            switch (statusIndex)
            {
                case 0:
                    status = StatusTask.TODO;
                    break;
                case 1:
                    status = StatusTask.DOING;
                    break;
                case 2:
                    status = StatusTask.DONE;
                    break;
                default:
                    MessageBox.Show("Adauga Status");
                    return;
            }

            if (name == "")
            {
                MessageBox.Show("Adauga Nume");
                return;
            }
            if (startTime == null)
            {
                MessageBox.Show("Adauga StartTime");
                return;
            }
            if (endTime == null)
            {
                MessageBox.Show("Adauga EndTime");
                return;
            }

            newTask = new TaskClass(name, description, _path, startTime, endTime, status, numeUtil);
            this.Close();
        }
        /// <summary>
        /// Buton de deschidere a panoului FormBrowse.
        /// </summary>
        private void BrowsePhoto_Click(object sender, EventArgs e)
        {
            FormBrowse f = new FormBrowse();
            f.ShowDialog();
            _path = f.path;
            if (_path != "")
            {
                Image newImage = Image.FromFile("imagini/" + _path);
                pictureBoxTaskPhoto.Image = (Image)(new Bitmap(newImage, new Size(135, 122)));
            }
            else
                pictureBoxTaskPhoto.Image = null;
        }

        /// <summary>
        /// Butonul de modificare a unei sarcini.
        /// </summary>
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            string name = textBoxTaskName.Text;
            DateTime startTime = dateTimePickerTaskStartDate.Value;
            DateTime endTime = dateTimePickerTaskFinishDate.Value;
            string description = richTextBoxTaskNote.Text;
            int statusIndex = comboBoxTaskStatus.SelectedIndex;
            StatusTask status;
            switch (statusIndex)
            {
                case 0:
                    status = StatusTask.TODO;
                    break;
                case 1:
                    status = StatusTask.DOING;
                    break;
                case 2:
                    status = StatusTask.DONE;
                    break;
                default:
                    MessageBox.Show("Adauga Status");
                    return;
            }

            if (name == "")
            {
                MessageBox.Show("Adauga Nume");
                return;
            }
            if (startTime == null)
            {
                MessageBox.Show("Adauga StartTime");
                return;
            }
            if (endTime == null)
            {
                MessageBox.Show("Adauga EndTime");
                return;
            }

            newTask = new TaskClass(name, description, _path, startTime, endTime, status, numeUtil);
            this.Close();
        }

        private void richTextBoxTaskNote_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
