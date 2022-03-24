
namespace Authentication
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonAddTask = new System.Windows.Forms.Button();
            this.labelToDo = new System.Windows.Forms.Label();
            this.labelDone = new System.Windows.Forms.Label();
            this.labelDoing = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAut = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonAddTask
            // 
            this.ButtonAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonAddTask.ForeColor = System.Drawing.Color.Coral;
            this.ButtonAddTask.Location = new System.Drawing.Point(844, 311);
            this.ButtonAddTask.Name = "ButtonAddTask";
            this.ButtonAddTask.Size = new System.Drawing.Size(86, 43);
            this.ButtonAddTask.TabIndex = 13;
            this.ButtonAddTask.Text = "Add Task";
            this.ButtonAddTask.UseVisualStyleBackColor = true;
            this.ButtonAddTask.Click += new System.EventHandler(this.ButtonAddTask_Click);
            // 
            // labelToDo
            // 
            this.labelToDo.AutoSize = true;
            this.labelToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelToDo.ForeColor = System.Drawing.Color.Coral;
            this.labelToDo.Location = new System.Drawing.Point(100, 87);
            this.labelToDo.Name = "labelToDo";
            this.labelToDo.Size = new System.Drawing.Size(54, 20);
            this.labelToDo.TabIndex = 14;
            this.labelToDo.Text = "To do";
            // 
            // labelDone
            // 
            this.labelDone.AutoSize = true;
            this.labelDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelDone.ForeColor = System.Drawing.Color.Coral;
            this.labelDone.Location = new System.Drawing.Point(582, 87);
            this.labelDone.Name = "labelDone";
            this.labelDone.Size = new System.Drawing.Size(52, 20);
            this.labelDone.TabIndex = 15;
            this.labelDone.Text = "Done";
            // 
            // labelDoing
            // 
            this.labelDoing.AutoSize = true;
            this.labelDoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelDoing.ForeColor = System.Drawing.Color.Coral;
            this.labelDoing.Location = new System.Drawing.Point(341, 87);
            this.labelDoing.Name = "labelDoing";
            this.labelDoing.Size = new System.Drawing.Size(56, 20);
            this.labelDoing.TabIndex = 16;
            this.labelDoing.Text = "Doing";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonLogOut.Location = new System.Drawing.Point(805, 3);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(125, 45);
            this.buttonLogOut.TabIndex = 18;
            this.buttonLogOut.Text = "Delogare";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.labelAut);
            this.panel1.Controls.Add(this.buttonLogOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 58);
            this.panel1.TabIndex = 19;
            // 
            // labelAut
            // 
            this.labelAut.AutoSize = true;
            this.labelAut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAut.Location = new System.Drawing.Point(571, 30);
            this.labelAut.Name = "labelAut";
            this.labelAut.Size = new System.Drawing.Size(57, 20);
            this.labelAut.TabIndex = 19;
            this.labelAut.Text = "Autent";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(967, 664);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelDoing);
            this.Controls.Add(this.labelDone);
            this.Controls.Add(this.labelToDo);
            this.Controls.Add(this.ButtonAddTask);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Management";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddTask;
        private System.Windows.Forms.Label labelToDo;
        private System.Windows.Forms.Label labelDone;
        private System.Windows.Forms.Label labelDoing;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label labelAut;
    }
}