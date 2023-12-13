namespace Bender_Saver
{
    partial class SettingsForm
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
            Title = new Label();
            ByMe = new Label();
            url_box = new TextBox();
            Link = new Label();
            pictureBox1 = new PictureBox();
            Color_Title = new Label();
            lbRGBvalues = new Label();
            lblSmallScreen = new Label();
            groupBox1 = new GroupBox();
            pnlSelectedScreen = new Panel();
            TbxGreenValue = new TextBox();
            tbxBlueValue = new TextBox();
            tbxRedValue = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Save = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Dock = DockStyle.Top;
            Title.Font = new Font("Segoe UI", 24F);
            Title.Location = new Point(0, 0);
            Title.Name = "Title";
            Title.Size = new Size(518, 45);
            Title.TabIndex = 0;
            Title.Text = "Bender Screen Saver";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ByMe
            // 
            ByMe.Dock = DockStyle.Top;
            ByMe.Font = new Font("Segoe UI", 14F);
            ByMe.Location = new Point(0, 45);
            ByMe.Name = "ByMe";
            ByMe.Size = new Size(518, 23);
            ByMe.TabIndex = 1;
            ByMe.Text = "By: MaynardMiner";
            ByMe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // url_box
            // 
            url_box.BorderStyle = BorderStyle.FixedSingle;
            url_box.Location = new Point(0, 107);
            url_box.Name = "url_box";
            url_box.Size = new Size(518, 23);
            url_box.TabIndex = 2;
            url_box.Text = "https://art-assets.artlab.xyz/82/47/73/1d8467257c18d9c25f773390a533d8f40e1371e0939dfae915f5d87a5e";
            url_box.TextAlign = HorizontalAlignment.Center;
            url_box.TextChanged += url_box_TextChanged;
            // 
            // Link
            // 
            Link.Font = new Font("Segoe UI", 14F);
            Link.Location = new Point(160, 81);
            Link.Name = "Link";
            Link.Size = new Size(206, 23);
            Link.TabIndex = 3;
            Link.Text = "Animation Url";
            Link.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.rgbSpectrum;
            pictureBox1.Location = new Point(149, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // Color_Title
            // 
            Color_Title.AutoSize = true;
            Color_Title.Font = new Font("Segoe UI", 14F);
            Color_Title.Location = new Point(179, 139);
            Color_Title.Name = "Color_Title";
            Color_Title.Size = new Size(164, 25);
            Color_Title.TabIndex = 5;
            Color_Title.Text = "Background Color";
            Color_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbRGBvalues
            // 
            lbRGBvalues.BorderStyle = BorderStyle.FixedSingle;
            lbRGBvalues.Font = new Font("Segoe UI", 14F);
            lbRGBvalues.Location = new Point(96, 326);
            lbRGBvalues.Name = "lbRGBvalues";
            lbRGBvalues.Size = new Size(167, 34);
            lbRGBvalues.TabIndex = 6;
            lbRGBvalues.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSmallScreen
            // 
            lblSmallScreen.BackColor = SystemColors.Control;
            lblSmallScreen.BorderStyle = BorderStyle.FixedSingle;
            lblSmallScreen.Location = new Point(333, 326);
            lblSmallScreen.Name = "lblSmallScreen";
            lblSmallScreen.Size = new Size(42, 34);
            lblSmallScreen.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pnlSelectedScreen);
            groupBox1.Controls.Add(TbxGreenValue);
            groupBox1.Controls.Add(tbxBlueValue);
            groupBox1.Controls.Add(tbxRedValue);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 363);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(494, 158);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected Color";
            // 
            // pnlSelectedScreen
            // 
            pnlSelectedScreen.BackColor = Color.White;
            pnlSelectedScreen.Location = new Point(288, 30);
            pnlSelectedScreen.Name = "pnlSelectedScreen";
            pnlSelectedScreen.Size = new Size(200, 115);
            pnlSelectedScreen.TabIndex = 6;
            pnlSelectedScreen.Tag = "";
            // 
            // TbxGreenValue
            // 
            TbxGreenValue.Font = new Font("Segoe UI", 9F);
            TbxGreenValue.Location = new Point(137, 76);
            TbxGreenValue.Name = "TbxGreenValue";
            TbxGreenValue.ScrollBars = ScrollBars.Vertical;
            TbxGreenValue.Size = new Size(100, 23);
            TbxGreenValue.TabIndex = 5;
            TbxGreenValue.Tag = "";
            TbxGreenValue.Text = "255";
            TbxGreenValue.TextAlign = HorizontalAlignment.Center;
            TbxGreenValue.TextChanged += TbxGreenValue_TextChanged;
            TbxGreenValue.KeyPress += TbxGreenValue_KeyPress;
            // 
            // tbxBlueValue
            // 
            tbxBlueValue.Font = new Font("Segoe UI", 9F);
            tbxBlueValue.Location = new Point(137, 122);
            tbxBlueValue.Name = "tbxBlueValue";
            tbxBlueValue.ScrollBars = ScrollBars.Vertical;
            tbxBlueValue.Size = new Size(100, 23);
            tbxBlueValue.TabIndex = 4;
            tbxBlueValue.Tag = "";
            tbxBlueValue.Text = "255";
            tbxBlueValue.TextAlign = HorizontalAlignment.Center;
            tbxBlueValue.TextChanged += tbxBlueValue_TextChanged;
            tbxBlueValue.KeyPress += tbxBlueValue_KeyPress;
            // 
            // tbxRedValue
            // 
            tbxRedValue.Font = new Font("Segoe UI", 9F);
            tbxRedValue.Location = new Point(137, 30);
            tbxRedValue.Name = "tbxRedValue";
            tbxRedValue.ScrollBars = ScrollBars.Vertical;
            tbxRedValue.Size = new Size(100, 23);
            tbxRedValue.TabIndex = 3;
            tbxRedValue.Tag = "";
            tbxRedValue.Text = "255";
            tbxRedValue.TextAlign = HorizontalAlignment.Center;
            tbxRedValue.TextChanged += tbxRedValue_TextChanged;
            tbxRedValue.KeyPress += tbxRedValue_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 130);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "Blue";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 84);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Green";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 38);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "Red";
            // 
            // Save
            // 
            Save.Location = new Point(160, 527);
            Save.Name = "Save";
            Save.Size = new Size(175, 40);
            Save.TabIndex = 9;
            Save.Tag = "Save";
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Button1_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 579);
            Controls.Add(Save);
            Controls.Add(groupBox1);
            Controls.Add(lblSmallScreen);
            Controls.Add(lbRGBvalues);
            Controls.Add(Color_Title);
            Controls.Add(pictureBox1);
            Controls.Add(Link);
            Controls.Add(url_box);
            Controls.Add(ByMe);
            Controls.Add(Title);
            Name = "SettingsForm";
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label ByMe;
        private TextBox url_box;
        private Label Link;
        private PictureBox pictureBox1;
        private Label Color_Title;
        private Label lbRGBvalues;
        private Label lblSmallScreen;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TbxGreenValue;
        private TextBox tbxBlueValue;
        private TextBox tbxRedValue;
        private Panel pnlSelectedScreen;
        private Button Save;
    }
}