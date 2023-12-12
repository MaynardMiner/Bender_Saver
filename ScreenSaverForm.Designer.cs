using AxWMPLib;
using Microsoft.VisualBasic.ApplicationServices;

namespace Bender_Saver
{
    partial class ScreensaverForm : Form
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreensaverForm));
            axWindowsMediaPlayer1 = new AxWindowsMediaPlayer();
            moveTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(197, 38);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(940, 960);
            axWindowsMediaPlayer1.TabIndex = 0;
            axWindowsMediaPlayer1.TabStop = false;
            // 
            // moveTimer
            // 
            moveTimer.Tick += moveTimer_Tick;
            // 
            // ScreensaverForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Black;
            ClientSize = new Size(1920, 1080);
            Controls.Add(axWindowsMediaPlayer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScreensaverForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            Load += ScreensaverForm_Load;
            KeyPress += ScreensaverForm_KeyPress;
            MouseClick += ScreensaverForm_MouseClick;
            MouseMove += ScreensaverForm_MouseMove;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer moveTimer;
    }
}
