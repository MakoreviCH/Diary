
using System;

namespace Project
{
    partial class FormView
    {
        private System.Windows.Forms.Button AddButton;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormView));
			this.AddButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// AddButton
			// 
			this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AddButton.BackColor = System.Drawing.Color.Transparent;
			this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.AddButton.FlatAppearance.BorderSize = 0;
			this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
			this.AddButton.Location = new System.Drawing.Point(1006, 499);
			this.AddButton.Margin = new System.Windows.Forms.Padding(0);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(80, 70);
			this.AddButton.TabIndex = 0;
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// FormView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(1095, 578);
			this.Controls.Add(this.AddButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FormView";
			this.Text = "Щоденник";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormView_FormClosing);
			this.Load += new System.EventHandler(this.FormView_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormView_KeyDown);
			this.ResumeLayout(false);

        }


        #endregion

        
        
    }
}

