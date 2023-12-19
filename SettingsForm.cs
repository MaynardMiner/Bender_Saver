using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bender_Saver
{
    public partial class SettingsForm : Form
    {
        static readonly HttpClient client = new HttpClient();

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap)pictureBox1.Image;
            Color clr = pixelData.GetPixel(e.X, e.Y);
            lblSmallScreen.BackColor = clr;
            lbRGBvalues.Text = "R: " + clr.R.ToString() + " G: " + clr.G.ToString() + " B: " + clr.B.ToString();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap)pictureBox1.Image;
            Color clr = pixelData.GetPixel(e.X, e.Y);
            tbxRedValue.Text = clr.R.ToString();
            TbxGreenValue.Text = clr.G.ToString();
            tbxBlueValue.Text = clr.B.ToString();
            pnlSelectedScreen.BackColor = clr;
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            bool good = false;
            if(File.Exists(url_box.Text))
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Bender_Saver");
                key.SetValue("url", url_box.Text);
                key.SetValue("color", HexConverter(pnlSelectedScreen.BackColor));
                good = true;
            }
            else if (Uri.IsWellFormedUriString(url_box.Text, UriKind.Absolute))
            {
                try
                {
                    using (var client = new HttpClient())
                    {
                        HttpResponseMessage result = await client.GetAsync(url_box.Text);
                        if (result.IsSuccessStatusCode)
                        {
                            if (result.Content.Headers.ContentType != null)
                            {
                                MediaTypeHeaderValue type = result.Content.Headers.ContentType;
                                if (type.MediaType == "video/mp4")
                                {
                                    // Create or get existing Registry subkey
                                    RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Bender_Saver");
                                    key.SetValue("url", url_box.Text);
                                    key.SetValue("color", HexConverter(pnlSelectedScreen.BackColor));
                                    good = true;
                                }
                            }
                        }
                    }
                }
                catch (HttpRequestException a)
                {
                    url_box.BackColor = Color.Pink;
                }
            }
            if (good)
            {
                Close();
            }
            else
            {
                url_box.BackColor = Color.Pink;
            }
        }

        private static String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        private void url_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void tbxRedValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TbxGreenValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbxBlueValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbxRedValue_TextChanged(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(tbxRedValue.Text);
            if (value > 255)
            {
                tbxRedValue.Text = "255";
            }
            pnlSelectedScreen.BackColor = Color.FromArgb(Convert.ToInt32(tbxRedValue.Text), Convert.ToInt32(TbxGreenValue.Text), Convert.ToInt32(tbxBlueValue.Text));
        }

        private void TbxGreenValue_TextChanged(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(TbxGreenValue.Text);
            if (value > 255)
            {
                TbxGreenValue.Text = "255";
            }
            pnlSelectedScreen.BackColor = Color.FromArgb(Convert.ToInt32(tbxRedValue.Text), Convert.ToInt32(TbxGreenValue.Text), Convert.ToInt32(tbxBlueValue.Text));
        }

        private void tbxBlueValue_TextChanged(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(tbxBlueValue.Text);
            if (value > 255)
            {
                tbxBlueValue.Text = "255";
            }
            pnlSelectedScreen.BackColor = Color.FromArgb(Convert.ToInt32(tbxRedValue.Text), Convert.ToInt32(TbxGreenValue.Text), Convert.ToInt32(tbxBlueValue.Text));
        }
    }
}