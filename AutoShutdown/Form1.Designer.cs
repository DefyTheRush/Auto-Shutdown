namespace AutoShutdown
{
    partial class frmAutoShutdown
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutoShutdown));
            this.prgShutdownCounter = new System.Windows.Forms.ProgressBar();
            this.btnCancelShutdown = new System.Windows.Forms.Button();
            this.lblShutdownMessage = new System.Windows.Forms.Label();
            this.tmrStartShutdown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // prgShutdownCounter
            // 
            this.prgShutdownCounter.Location = new System.Drawing.Point(85, 76);
            this.prgShutdownCounter.Maximum = 300;
            this.prgShutdownCounter.Name = "prgShutdownCounter";
            this.prgShutdownCounter.Size = new System.Drawing.Size(223, 23);
            this.prgShutdownCounter.TabIndex = 0;
            // 
            // btnCancelShutdown
            // 
            this.btnCancelShutdown.Location = new System.Drawing.Point(113, 115);
            this.btnCancelShutdown.Name = "btnCancelShutdown";
            this.btnCancelShutdown.Size = new System.Drawing.Size(166, 26);
            this.btnCancelShutdown.TabIndex = 1;
            this.btnCancelShutdown.Text = "Cancel Shutdown";
            this.btnCancelShutdown.UseVisualStyleBackColor = true;
            this.btnCancelShutdown.Click += new System.EventHandler(this.btnCancelShutdown_Click);
            // 
            // lblShutdownMessage
            // 
            this.lblShutdownMessage.Location = new System.Drawing.Point(43, 45);
            this.lblShutdownMessage.Name = "lblShutdownMessage";
            this.lblShutdownMessage.Size = new System.Drawing.Size(154, 15);
            this.lblShutdownMessage.TabIndex = 2;
            this.lblShutdownMessage.Text = "Shutdown in: 300 seconds";
            // 
            // tmrStartShutdown
            // 
            this.tmrStartShutdown.Interval = 1000;
            this.tmrStartShutdown.Tick += new System.EventHandler(this.tmrStartShutdown_Tick);
            // 
            // frmAutoShutdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 193);
            this.Controls.Add(this.lblShutdownMessage);
            this.Controls.Add(this.btnCancelShutdown);
            this.Controls.Add(this.prgShutdownCounter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAutoShutdown";
            this.Text = "Automatic Shutdown";
            this.Load += new System.EventHandler(this.frmAutoShutdown_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgShutdownCounter;
        private System.Windows.Forms.Button btnCancelShutdown;
        private System.Windows.Forms.Label lblShutdownMessage;
        private System.Windows.Forms.Timer tmrStartShutdown;
    }
}

