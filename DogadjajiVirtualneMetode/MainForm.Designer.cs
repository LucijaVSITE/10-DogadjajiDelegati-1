﻿namespace Vsite.CSharp
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
            this.button = new System.Windows.Forms.Button();
            this.buttonMy = new System.Windows.Forms.Button();
            this.mybutton1 = new Vsite.CSharp.Mybutton();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(12, 12);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 0;
            this.button.Text = "&Button";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMy
            // 
            this.buttonMy.Location = new System.Drawing.Point(12, 61);
            this.buttonMy.Name = "buttonMy";
            this.buttonMy.Size = new System.Drawing.Size(75, 23);
            this.buttonMy.TabIndex = 1;
            this.buttonMy.Text = "&My button";
            this.buttonMy.UseVisualStyleBackColor = true;
            this.buttonMy.Click += new System.EventHandler(this.buttonMy_Click);
            // 
            // mybutton1
            // 
            this.mybutton1.Location = new System.Drawing.Point(12, 113);
            this.mybutton1.Name = "mybutton1";
            this.mybutton1.Size = new System.Drawing.Size(75, 23);
            this.mybutton1.TabIndex = 2;
            this.mybutton1.Text = "mybutton1";
            this.mybutton1.UseVisualStyleBackColor = true;
            this.mybutton1.Click += new System.EventHandler(this.buttonMy_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.mybutton1);
            this.Controls.Add(this.buttonMy);
            this.Controls.Add(this.button);
            this.Name = "MainForm";
            this.Text = "Događaji i virtualne metode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button buttonMy;
        private Mybutton mybutton1;
    }
}

