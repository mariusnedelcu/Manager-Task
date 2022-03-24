
/**************************************************************************
 *                                                                        *
 *  File:        CommandGraph.cs                                          *
 *  Copyright:   (c) 2021, Petrov Sergiu                                  *
 *  E-mail:     sergiu.petrov@tuiasi.ro                                   *
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
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using ManagerTask;
using Task;
namespace Authentication
{
    /// <summary>
    /// Clasa DrawTask creeaza dinamic panourile si toate atributele pentru a reprezenta o sarcina.
    /// </summary>
    public class DrawTask
    {
        public Panel panel;
        public List<Panel> panels;
        public int nr;
        /// <summary>
        /// Constructorul implicit al clasei DrawTask.
        /// </summary>
        public DrawTask()
        {
            panels = new List<Panel> { };
            nr = 5;
        }

        /// <summary>
        /// Constructorul care creeaza elementele panoului.
        /// </summary>
        /// <param name="_manageTask">Transmite lista cu sarcini.</param> 
        /// <param name="ButtonDeleteClick">Buton care sterge o sarcina atunci cand este apasat.</param>
        /// <param name="ButtonModifyClick">Buton care modifica o sarcina atunci cand este apasat.</param>
        /// <param name="nameUser">Autorul sarcinii.</param>
        public DrawTask(ManageClass _manageTask, EventHandler ButtonDeleteClick, EventHandler ButtonModifyClick, string nameUser)
        {
            int width = 0;
            int heightToDo = 145;
            int heightDoing = 145;
            int heightDone = 145;
            int widthToDo = 40;
            int widthDoing = 320;
            int widthDone = 600;
            int height = 145;
            panels = new List<Panel> { };
            int i = 0;
            ///Creaza o caseta pentru fiecare sarcina salvata.
            foreach (TaskClass t in _manageTask.listTask)
            {
                if (t.TasProgress == StatusTask.TODO)
                    width = widthToDo;
                if (t.TasProgress == StatusTask.DOING)
                    width = widthDoing;
                if (t.TasProgress == StatusTask.DONE)
                    width = widthDone;
                if (t.TasProgress == StatusTask.TODO)
                    height = heightToDo;
                if (t.TasProgress == StatusTask.DOING)
                    height = heightDoing;
                if (t.TasProgress == StatusTask.DONE)
                    height = heightDone;
                panel = new Panel();

                TextBox textBox15 = CreareTextBoxStartDate("textBox001");
                TextBox textBox16 = CreareTextBoxEndDate("textBox01");
                TextBox textBox17 = CreareTextBoxName("textBox1");
                RichTextBox richTextBox1 = CreareRichTextBoxDescriere("richTextBox");
                ///Daca sarcina este a autorului logat, culoarea de fundal va fi diferita de task-urile celorlalti utilizatori (culoare verde).
                /// Adauga posibilitatea de a modifica sau sterge sarcina.

                if (t.TaskUserName == nameUser)
                {

                    this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                    Button buttonDelete = CreareButtonDelete(i.ToString(), ButtonDeleteClick);
                    Button buttonModify = CreareButtonModify(i.ToString(), ButtonModifyClick);
                    this.panel.Controls.Add(buttonDelete);
                    this.panel.Controls.Add(buttonModify);
                }
                else
                {
                    ///Seteaza culoarea de fundal a unei sarcini cu galbena
                    this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                }
                Label labelName = CreareLabelName();
                Label labelDescriere = CreareLabelDescriere();
                Label labelEndDate = CreareLabelEndData();
                Label labelStartDate = CreareLabelStartDate();


                this.panel.Controls.Add(textBox15);
                this.panel.Controls.Add(textBox16);
                this.panel.Controls.Add(richTextBox1);
                this.panel.Controls.Add(textBox17); this.panel.Controls.Add(labelName);
                this.panel.Controls.Add(labelDescriere);
                this.panel.Controls.Add(labelEndDate);
                this.panel.Controls.Add(labelStartDate);


                this.panel.Location = new System.Drawing.Point(width, height);
                this.panel.Name = "panel111";
                this.panel.Size = new System.Drawing.Size(200, 164);
                this.panel.TabIndex = 20;
                this.panel.Tag = "";
                this.panel.PerformLayout();
                panels.Add(panel);
                textBox15.Text = t.TaskStartTime.ToString("dd-MM-yyyy");
                textBox16.Text = t.TaskEndTime.ToString("dd-MM-yyyy");
                textBox17.Text = t.TaskName;
                richTextBox1.Text = t.TaskDetails;

                ///In functie de statusul in care se afla o sarcina, vor fi repartizate pe coloane diferite.
                if (t.TasProgress == StatusTask.TODO)
                {
                    heightToDo += 205;
                }
                if (t.TasProgress == StatusTask.DOING)
                {
                    heightDoing += 205;
                }
                if (t.TasProgress == StatusTask.DONE)
                {
                    heightDone += 205;
                }
                i += 1;
            }
        }

        /// <summary>
        /// Functia de creare a unui textbox pentru data de inceput a unei sarcini
        /// </summary>
        /// <param name="name">Numele utilizatorului logat.</param>
        /// <returns>Returneaza textboxul creat</returns>
        private TextBox CreareTextBoxEndDate(string name)
        {
            TextBox textBox15 = new System.Windows.Forms.TextBox();

            textBox15.Location = new System.Drawing.Point(66, 109);
            textBox15.Name = name;
            textBox15.Size = new System.Drawing.Size(122, 23);
            textBox15.TabIndex = 31;
            return textBox15;
        }

        /// <summary>
        /// Functia de creare a unui textbox pentru data de sfarsit a unei sarcini.
        /// </summary>
        /// <param name="name">Nume textbox-ului.</param>
        /// <returns>Returneaza textboxul creat.</returns>
        private TextBox CreareTextBoxStartDate(string name)
        {
            TextBox textBox2 = new System.Windows.Forms.TextBox();

            textBox2.Location = new System.Drawing.Point(66, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(122, 23);
            textBox2.TabIndex = 30;
            return textBox2;
        }

        /// <summary>
        /// Functie de creare a unui textbox pentru numele sarcinii.
        /// </summary>
        /// <param name="name">Numele textbox-ului</param>
        /// <returns>Returneaza textbox-ul creat</returns>
        private TextBox CreareTextBoxName(string name)
        {
            TextBox textBox1 = new System.Windows.Forms.TextBox();

            textBox1.Location = new System.Drawing.Point(66, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(122, 23);
            textBox1.TabIndex = 28;
            return textBox1;
        }

        /// <summary>
        /// Functie de creare a unui textbox pentru descrierea sarcinii.
        /// </summary>
        /// <param name="name">Numele textbox-ului</param>
        /// <returns>Returneaza textbox-ul creat</returns>
        private RichTextBox CreareRichTextBoxDescriere(string name)
        {
            RichTextBox richText = new RichTextBox();
            richText.Location = new System.Drawing.Point(66, 28);
            richText.Name = "richTextBox1";
            richText.Size = new System.Drawing.Size(122, 52);
            richText.TabIndex = 28;
            richText.Text = "";

            return richText;
        }

        /// <summary>
        /// Functie de creare a unui buton de stergere a sarcinii.
        /// </summary>
        /// <param name="name">Numele butonului.</param>
        /// <param name="ButtonDeleteClick">Apeleaza functia de stergere a sarcinii.</param>
        /// <returns></returns>
        private Button CreareButtonDelete(string name, EventHandler ButtonDeleteClick)
        {
            Button button1 = new Button();
            button1.Location = new Point(32, 130);
            button1.Name = name;
            button1.Size = new System.Drawing.Size(53, 27);
            button1.TabIndex = 28;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonDeleteClick;
            return button1;
        }

        /// <summary>
        /// Functie de creare a unui buton de modificare a unei sarcini.
        /// </summary>
        /// <param name="name">Numele butonului.</param>
        /// <param name="ButtonModifyClick">Apeleaza functia de modificare a sarcinii.</param>
        /// <returns></returns>
        private Button CreareButtonModify(string name, EventHandler ButtonModifyClick)
        {
            Button button2 = new Button();
            button2.Location = new System.Drawing.Point(113, 130);
            button2.Name = name;
            button2.Size = new System.Drawing.Size(53, 27);
            button2.TabIndex = 29;
            button2.Text = "Modify";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ButtonModifyClick;
            return button2;
        }

        private Label CreareLabelName()
        {
            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            return label1;
        }
        private Label CreareLabelEndData()
        {
            Label label4 = new Label();
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(10, 112);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "End Date";
            return label4;
        }
        private Label CreareLabelStartDate()
        {
            Label label3 = new Label();
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(10, 86);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Start Date";
            return label3;
        }
        private Label CreareLabelDescriere()
        {
            Label label2 = new Label();
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 37);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Descriere";
            return label2;
        }

    }
}

