
namespace App8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartTimer = new System.Windows.Forms.Button();
            this.PauseTimer = new System.Windows.Forms.Button();
            this.StopTimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartTimer
            // 
            this.StartTimer.Location = new System.Drawing.Point(136, 147);
            this.StartTimer.Name = "StartTimer";
            this.StartTimer.Size = new System.Drawing.Size(75, 23);
            this.StartTimer.TabIndex = 0;
            this.StartTimer.Text = "Старт";
            this.StartTimer.UseVisualStyleBackColor = true;
            this.StartTimer.Click += new System.EventHandler(this.StartTimer_Click);
            // 
            // PauseTimer
            // 
            this.PauseTimer.Location = new System.Drawing.Point(136, 182);
            this.PauseTimer.Name = "PauseTimer";
            this.PauseTimer.Size = new System.Drawing.Size(75, 23);
            this.PauseTimer.TabIndex = 1;
            this.PauseTimer.Text = "Пауза";
            this.PauseTimer.UseVisualStyleBackColor = true;
            this.PauseTimer.Click += new System.EventHandler(this.PauseTimer_Click);
            // 
            // StopTimer
            // 
            this.StopTimer.Location = new System.Drawing.Point(136, 220);
            this.StopTimer.Name = "StopTimer";
            this.StopTimer.Size = new System.Drawing.Size(75, 23);
            this.StopTimer.TabIndex = 2;
            this.StopTimer.Text = "Стоп";
            this.StopTimer.UseVisualStyleBackColor = true;
            this.StopTimer.Click += new System.EventHandler(this.StopTimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 316);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopTimer);
            this.Controls.Add(this.PauseTimer);
            this.Controls.Add(this.StartTimer);
            this.Name = "Form1";
            this.Text = "App8";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartTimer;
        private System.Windows.Forms.Button PauseTimer;
        private System.Windows.Forms.Button StopTimer;
        private System.Windows.Forms.Label label1;
    }
}

