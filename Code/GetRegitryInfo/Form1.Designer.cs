﻿using System;
using System.Windows.Forms;

namespace GetRegitryInfo
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDisplayResults = new System.Windows.Forms.TextBox();
            this.textBoxStringInput = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Scan System";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxDisplayResults
            // 
            this.textBoxDisplayResults.Location = new System.Drawing.Point(12, 60);
            this.textBoxDisplayResults.Multiline = true;
            this.textBoxDisplayResults.Name = "textBoxDisplayResults";
            this.textBoxDisplayResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDisplayResults.Size = new System.Drawing.Size(776, 338);
            this.textBoxDisplayResults.TabIndex = 2;
            // 
            // textBoxStringInput
            // 
            this.textBoxStringInput.Location = new System.Drawing.Point(12, 34);
            this.textBoxStringInput.Name = "textBoxStringInput";
            this.textBoxStringInput.Size = new System.Drawing.Size(245, 20);
            this.textBoxStringInput.TabIndex = 3;
            this.textBoxStringInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxStringInput_KeyDown);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(120, 434);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(542, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Software to Find";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBoxStringInput);
            this.Controls.Add(this.textBoxDisplayResults);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Get Local Machine Registry Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxDisplayResults;
        private System.Windows.Forms.TextBox textBoxStringInput;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

