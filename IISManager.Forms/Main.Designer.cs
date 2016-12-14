namespace IISManager.Forms
{
    partial class Main
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
            this.bRecycle = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.bRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bRecycle
            // 
            this.bRecycle.Location = new System.Drawing.Point(36, 27);
            this.bRecycle.Name = "bRecycle";
            this.bRecycle.Size = new System.Drawing.Size(202, 36);
            this.bRecycle.TabIndex = 0;
            this.bRecycle.Text = "Recycle";
            this.bRecycle.UseVisualStyleBackColor = true;
            this.bRecycle.Click += new System.EventHandler(this.bRecycle_Click);
            // 
            // bStop
            // 
            this.bStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bStop.Location = new System.Drawing.Point(36, 69);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(202, 36);
            this.bStop.TabIndex = 1;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(36, 111);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(202, 36);
            this.bStart.TabIndex = 2;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bRestart
            // 
            this.bRestart.Location = new System.Drawing.Point(36, 153);
            this.bRestart.Name = "bRestart";
            this.bRestart.Size = new System.Drawing.Size(202, 36);
            this.bRestart.TabIndex = 3;
            this.bRestart.Text = "Restart";
            this.bRestart.UseVisualStyleBackColor = true;
            this.bRestart.Click += new System.EventHandler(this.bRestart_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 221);
            this.Controls.Add(this.bRestart);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bRecycle);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage IIS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bRecycle;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bRestart;
    }
}

