
namespace Project
{
    partial class FormAddView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddView));
			this.label1 = new System.Windows.Forms.Label();
			this.NameBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.DateTimeBox = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.TimeBox = new System.Windows.Forms.DateTimePicker();
			this.GroupsListBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.AddGroup = new System.Windows.Forms.Button();
			this.AddButton = new System.Windows.Forms.Button();
			this.CompleteBox = new System.Windows.Forms.CheckBox();
			this.label = new System.Windows.Forms.Label();
			this.PlaceBox = new System.Windows.Forms.TextBox();
			this.RemoveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.19F);
			this.label1.Location = new System.Drawing.Point(20, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(256, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Що має бути зроблено?";
			// 
			// NameBox
			// 
			this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.13F);
			this.NameBox.Location = new System.Drawing.Point(35, 60);
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(566, 27);
			this.NameBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.19F);
			this.label2.Location = new System.Drawing.Point(20, 246);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(245, 26);
			this.label2.TabIndex = 2;
			this.label2.Text = "Дата та час виконання";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DateTimeBox
			// 
			this.DateTimeBox.CustomFormat = "dd.MM.yyyy HH:mm:ss";
			this.DateTimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14F);
			this.DateTimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateTimeBox.Location = new System.Drawing.Point(35, 283);
			this.DateTimeBox.Name = "DateTimeBox";
			this.DateTimeBox.Size = new System.Drawing.Size(241, 27);
			this.DateTimeBox.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.19F);
			this.label3.Location = new System.Drawing.Point(407, 246);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(194, 26);
			this.label3.TabIndex = 4;
			this.label3.Text = "Термін виконання";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TimeBox
			// 
			this.TimeBox.CustomFormat = "hh:mm:ss";
			this.TimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14F);
			this.TimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.TimeBox.Location = new System.Drawing.Point(406, 283);
			this.TimeBox.MaxDate = new System.DateTime(1970, 1, 2, 0, 0, 0, 0);
			this.TimeBox.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
			this.TimeBox.Name = "TimeBox";
			this.TimeBox.Size = new System.Drawing.Size(210, 27);
			this.TimeBox.TabIndex = 4;
			this.TimeBox.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
			// 
			// GroupsListBox
			// 
			this.GroupsListBox.BackColor = System.Drawing.SystemColors.Control;
			this.GroupsListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.GroupsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14F);
			this.GroupsListBox.FormattingEnabled = true;
			this.GroupsListBox.Location = new System.Drawing.Point(35, 398);
			this.GroupsListBox.Name = "GroupsListBox";
			this.GroupsListBox.Size = new System.Drawing.Size(345, 28);
			this.GroupsListBox.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.19F);
			this.label4.Location = new System.Drawing.Point(20, 353);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(180, 26);
			this.label4.TabIndex = 7;
			this.label4.Text = "Додати у список";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AddGroup
			// 
			this.AddGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.11F);
			this.AddGroup.Location = new System.Drawing.Point(406, 394);
			this.AddGroup.Name = "AddGroup";
			this.AddGroup.Size = new System.Drawing.Size(195, 34);
			this.AddGroup.TabIndex = 8;
			this.AddGroup.Text = "Створити список";
			this.AddGroup.UseVisualStyleBackColor = true;
			this.AddGroup.Click += new System.EventHandler(this.AddGroup_Click);
			// 
			// AddButton
			// 
			this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AddButton.BackColor = System.Drawing.Color.Transparent;
			this.AddButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.AddButton.FlatAppearance.BorderSize = 2;
			this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
			this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
			this.AddButton.Location = new System.Drawing.Point(543, 538);
			this.AddButton.Margin = new System.Windows.Forms.Padding(0);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(80, 70);
			this.AddButton.TabIndex = 10;
			this.AddButton.UseVisualStyleBackColor = false;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// CompleteBox
			// 
			this.CompleteBox.AutoSize = true;
			this.CompleteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.11F);
			this.CompleteBox.Location = new System.Drawing.Point(40, 93);
			this.CompleteBox.Name = "CompleteBox";
			this.CompleteBox.Size = new System.Drawing.Size(179, 21);
			this.CompleteBox.TabIndex = 11;
			this.CompleteBox.Text = "Завдання завершено?";
			this.CompleteBox.UseVisualStyleBackColor = true;
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.19F);
			this.label.Location = new System.Drawing.Point(20, 148);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(198, 26);
			this.label.TabIndex = 12;
			this.label.Text = "Місце проведення";
			// 
			// PlaceBox
			// 
			this.PlaceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PlaceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.13F);
			this.PlaceBox.Location = new System.Drawing.Point(35, 185);
			this.PlaceBox.Name = "PlaceBox";
			this.PlaceBox.Size = new System.Drawing.Size(566, 27);
			this.PlaceBox.TabIndex = 2;
			// 
			// RemoveButton
			// 
			this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RemoveButton.BackColor = System.Drawing.Color.Transparent;
			this.RemoveButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.RemoveButton.FlatAppearance.BorderSize = 2;
			this.RemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
			this.RemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RemoveButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveButton.Image")));
			this.RemoveButton.Location = new System.Drawing.Point(9, 538);
			this.RemoveButton.Margin = new System.Windows.Forms.Padding(0);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(80, 70);
			this.RemoveButton.TabIndex = 14;
			this.RemoveButton.UseVisualStyleBackColor = false;
			this.RemoveButton.Visible = false;
			// 
			// FormAddView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 617);
			this.Controls.Add(this.RemoveButton);
			this.Controls.Add(this.PlaceBox);
			this.Controls.Add(this.label);
			this.Controls.Add(this.CompleteBox);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.AddGroup);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.GroupsListBox);
			this.Controls.Add(this.TimeBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.DateTimeBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.NameBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "FormAddView";
			this.Text = "Додати завдання";
			this.Load += new System.EventHandler(this.FormAdd_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAddView_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker DateTimeBox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker TimeBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox GroupsListBox;
        public System.Windows.Forms.Button AddGroup;
        public System.Windows.Forms.Button AddButton;
        public System.Windows.Forms.CheckBox CompleteBox;
        private System.Windows.Forms.Label label;
        public System.Windows.Forms.TextBox PlaceBox;
        public System.Windows.Forms.Button RemoveButton;
    }
}