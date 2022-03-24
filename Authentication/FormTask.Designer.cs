
namespace Authentication
{
    partial class FormTask
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
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.labelTaskName = new System.Windows.Forms.Label();
            this.labelTaskNote = new System.Windows.Forms.Label();
            this.dateTimePickerTaskStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTaskFinishDate = new System.Windows.Forms.DateTimePicker();
            this.labelTaskStartDate = new System.Windows.Forms.Label();
            this.labelTaskFinishDate = new System.Windows.Forms.Label();
            this.richTextBoxTaskNote = new System.Windows.Forms.RichTextBox();
            this.pictureBoxTaskPhoto = new System.Windows.Forms.PictureBox();
            this.labelTaskPhoto = new System.Windows.Forms.Label();
            this.labelTaskStatus = new System.Windows.Forms.Label();
            this.comboBoxTaskStatus = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.BrowsePhoto = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTaskPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.Location = new System.Drawing.Point(17, 35);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(259, 20);
            this.textBoxTaskName.TabIndex = 0;
            // 
            // labelTaskName
            // 
            this.labelTaskName.AutoSize = true;
            this.labelTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelTaskName.ForeColor = System.Drawing.Color.Coral;
            this.labelTaskName.Location = new System.Drawing.Point(17, 15);
            this.labelTaskName.Name = "labelTaskName";
            this.labelTaskName.Size = new System.Drawing.Size(98, 20);
            this.labelTaskName.TabIndex = 4;
            this.labelTaskName.Text = "Task Name";
            // 
            // labelTaskNote
            // 
            this.labelTaskNote.AutoSize = true;
            this.labelTaskNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelTaskNote.ForeColor = System.Drawing.Color.Coral;
            this.labelTaskNote.Location = new System.Drawing.Point(17, 70);
            this.labelTaskNote.Name = "labelTaskNote";
            this.labelTaskNote.Size = new System.Drawing.Size(90, 20);
            this.labelTaskNote.TabIndex = 5;
            this.labelTaskNote.Text = "Task Note";
            // 
            // dateTimePickerTaskStartDate
            // 
            this.dateTimePickerTaskStartDate.Location = new System.Drawing.Point(317, 35);
            this.dateTimePickerTaskStartDate.Name = "dateTimePickerTaskStartDate";
            this.dateTimePickerTaskStartDate.Size = new System.Drawing.Size(172, 20);
            this.dateTimePickerTaskStartDate.TabIndex = 6;
            // 
            // dateTimePickerTaskFinishDate
            // 
            this.dateTimePickerTaskFinishDate.Location = new System.Drawing.Point(317, 90);
            this.dateTimePickerTaskFinishDate.Name = "dateTimePickerTaskFinishDate";
            this.dateTimePickerTaskFinishDate.Size = new System.Drawing.Size(172, 20);
            this.dateTimePickerTaskFinishDate.TabIndex = 7;
            // 
            // labelTaskStartDate
            // 
            this.labelTaskStartDate.AutoSize = true;
            this.labelTaskStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelTaskStartDate.ForeColor = System.Drawing.Color.Coral;
            this.labelTaskStartDate.Location = new System.Drawing.Point(317, 15);
            this.labelTaskStartDate.Name = "labelTaskStartDate";
            this.labelTaskStartDate.Size = new System.Drawing.Size(92, 20);
            this.labelTaskStartDate.TabIndex = 8;
            this.labelTaskStartDate.Text = "Start Task";
            // 
            // labelTaskFinishDate
            // 
            this.labelTaskFinishDate.AutoSize = true;
            this.labelTaskFinishDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelTaskFinishDate.ForeColor = System.Drawing.Color.Coral;
            this.labelTaskFinishDate.Location = new System.Drawing.Point(317, 70);
            this.labelTaskFinishDate.Name = "labelTaskFinishDate";
            this.labelTaskFinishDate.Size = new System.Drawing.Size(100, 20);
            this.labelTaskFinishDate.TabIndex = 9;
            this.labelTaskFinishDate.Text = "Finish Task";
            // 
            // richTextBoxTaskNote
            // 
            this.richTextBoxTaskNote.Location = new System.Drawing.Point(17, 90);
            this.richTextBoxTaskNote.Name = "richTextBoxTaskNote";
            this.richTextBoxTaskNote.Size = new System.Drawing.Size(259, 178);
            this.richTextBoxTaskNote.TabIndex = 10;
            this.richTextBoxTaskNote.Text = "";
            this.richTextBoxTaskNote.TextChanged += new System.EventHandler(this.richTextBoxTaskNote_TextChanged_1);
            // 
            // pictureBoxTaskPhoto
            // 
            this.pictureBoxTaskPhoto.Location = new System.Drawing.Point(317, 162);
            this.pictureBoxTaskPhoto.Name = "pictureBoxTaskPhoto";
            this.pictureBoxTaskPhoto.Size = new System.Drawing.Size(116, 106);
            this.pictureBoxTaskPhoto.TabIndex = 11;
            this.pictureBoxTaskPhoto.TabStop = false;
            // 
            // labelTaskPhoto
            // 
            this.labelTaskPhoto.AutoSize = true;
            this.labelTaskPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelTaskPhoto.ForeColor = System.Drawing.Color.Coral;
            this.labelTaskPhoto.Location = new System.Drawing.Point(319, 131);
            this.labelTaskPhoto.Name = "labelTaskPhoto";
            this.labelTaskPhoto.Size = new System.Drawing.Size(99, 20);
            this.labelTaskPhoto.TabIndex = 12;
            this.labelTaskPhoto.Text = "Task Photo";
            // 
            // labelTaskStatus
            // 
            this.labelTaskStatus.AutoSize = true;
            this.labelTaskStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelTaskStatus.ForeColor = System.Drawing.Color.Coral;
            this.labelTaskStatus.Location = new System.Drawing.Point(317, 284);
            this.labelTaskStatus.Name = "labelTaskStatus";
            this.labelTaskStatus.Size = new System.Drawing.Size(62, 20);
            this.labelTaskStatus.TabIndex = 13;
            this.labelTaskStatus.Text = "Status";
            // 
            // comboBoxTaskStatus
            // 
            this.comboBoxTaskStatus.FormattingEnabled = true;
            this.comboBoxTaskStatus.Location = new System.Drawing.Point(317, 304);
            this.comboBoxTaskStatus.Name = "comboBoxTaskStatus";
            this.comboBoxTaskStatus.Size = new System.Drawing.Size(172, 21);
            this.comboBoxTaskStatus.TabIndex = 14;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.AddButton.ForeColor = System.Drawing.Color.Coral;
            this.AddButton.Location = new System.Drawing.Point(17, 298);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(60, 26);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // BrowsePhoto
            // 
            this.BrowsePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BrowsePhoto.ForeColor = System.Drawing.Color.Coral;
            this.BrowsePhoto.Location = new System.Drawing.Point(423, 127);
            this.BrowsePhoto.Name = "BrowsePhoto";
            this.BrowsePhoto.Size = new System.Drawing.Size(65, 26);
            this.BrowsePhoto.TabIndex = 16;
            this.BrowsePhoto.Text = "Browse";
            this.BrowsePhoto.UseVisualStyleBackColor = true;
            this.BrowsePhoto.Click += new System.EventHandler(this.BrowsePhoto_Click);
            // 
            // ModifyButton
            // 
            this.ModifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ModifyButton.ForeColor = System.Drawing.Color.Coral;
            this.ModifyButton.Location = new System.Drawing.Point(100, 298);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(60, 26);
            this.ModifyButton.TabIndex = 17;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // FormTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 335);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.BrowsePhoto);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.comboBoxTaskStatus);
            this.Controls.Add(this.labelTaskStatus);
            this.Controls.Add(this.labelTaskPhoto);
            this.Controls.Add(this.pictureBoxTaskPhoto);
            this.Controls.Add(this.richTextBoxTaskNote);
            this.Controls.Add(this.labelTaskFinishDate);
            this.Controls.Add(this.labelTaskStartDate);
            this.Controls.Add(this.dateTimePickerTaskFinishDate);
            this.Controls.Add(this.dateTimePickerTaskStartDate);
            this.Controls.Add(this.labelTaskNote);
            this.Controls.Add(this.labelTaskName);
            this.Controls.Add(this.textBoxTaskName);
            this.Name = "FormTask";
            this.Text = "Task";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTaskPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.Label labelTaskName;
        private System.Windows.Forms.Label labelTaskNote;
        private System.Windows.Forms.DateTimePicker dateTimePickerTaskStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTaskFinishDate;
        private System.Windows.Forms.Label labelTaskStartDate;
        private System.Windows.Forms.Label labelTaskFinishDate;
        private System.Windows.Forms.RichTextBox richTextBoxTaskNote;
        private System.Windows.Forms.PictureBox pictureBoxTaskPhoto;
        private System.Windows.Forms.Label labelTaskPhoto;
        private System.Windows.Forms.Label labelTaskStatus;
        private System.Windows.Forms.ComboBox comboBoxTaskStatus;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button BrowsePhoto;
        private System.Windows.Forms.Button ModifyButton;
    }
}