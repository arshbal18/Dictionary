﻿namespace Dictionary
{
    partial class Form1
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.lbx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(307, 194);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(93, 41);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Clear";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(307, 117);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(93, 40);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "character calculation";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(216, 23);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(184, 20);
            this.txtbox.TabIndex = 2;
            // 
            // lbx
            // 
            this.lbx.FormattingEnabled = true;
            this.lbx.Location = new System.Drawing.Point(444, 23);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(166, 212);
            this.lbx.TabIndex = 3;
            this.lbx.SelectedIndexChanged += new System.EventHandler(this.lbx_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbx);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.ListBox lbx;
    }
}

