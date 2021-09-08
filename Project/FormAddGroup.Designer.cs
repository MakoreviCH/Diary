
namespace Project
{
    partial class FormAddGroup
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddGroup));
			this.ConfirmButton = new System.Windows.Forms.Button();
			this.GroupBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// ConfirmButton
			// 
			this.ConfirmButton.Location = new System.Drawing.Point(12, 72);
			this.ConfirmButton.Name = "ConfirmButton";
			this.ConfirmButton.Size = new System.Drawing.Size(332, 35);
			this.ConfirmButton.TabIndex = 0;
			this.ConfirmButton.Text = "Додати новий список";
			this.ConfirmButton.UseVisualStyleBackColor = true;
			this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
			// 
			// GroupBox
			// 
			this.GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.13F);
			this.GroupBox.Location = new System.Drawing.Point(12, 25);
			this.GroupBox.Name = "GroupBox";
			this.GroupBox.Size = new System.Drawing.Size(332, 27);
			this.GroupBox.TabIndex = 1;
			// 
			// FormAddGroup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 119);
			this.Controls.Add(this.GroupBox);
			this.Controls.Add(this.ConfirmButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "FormAddGroup";
			this.Text = "Додавання форми";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAddGroup_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmButton;
        public System.Windows.Forms.TextBox GroupBox;
    }
}