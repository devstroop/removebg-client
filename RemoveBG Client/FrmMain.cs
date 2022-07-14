using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoveBG_Client
{
    public partial class FrmMain : Form
    {
        private string _InputImagePath;
        private string InputImagePath
        {
            get
            {
                return _InputImagePath;
            }
            set
            {
                if (System.IO.File.Exists(value))
                {
                    _InputImagePath = value;
                    this.pBoxInput.Image = Image.FromFile(_InputImagePath);
                }
                else
                {
                    MessageBox.Show("File not found");
                }
            }
        }
        private Image noImage = global::RemoveBG_Client.Properties.Resources.no_image;
        private Image loadingImage = global::RemoveBG_Client.Properties.Resources.loading_min;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            (new AboutBox()).ShowDialog();
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            this.pBoxInput.Image = noImage;
        }

        private void btnClearOutput_Click(object sender, EventArgs e)
        {
            this.pBoxOutput.Image = noImage;
        }

        private void btnLoadInput_Click(object sender, EventArgs e)
        {
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists(openImage.FileName))
                {
                    InputImagePath = openImage.FileName;
                }
                else
                {
                    MessageBox.Show("File not found");
                }
            }
        }

        private void btnSaveOutput_Click(object sender, EventArgs e)
        {
            if(this.pBoxOutput.Image != noImage && this.pBoxOutput.Image != loadingImage)
            {
                if (saveImage.ShowDialog() == DialogResult.OK)
                {
                    if (System.IO.File.Exists(saveImage.FileName))
                    {
                        MessageBox.Show($"Do you want to replace {saveImage.FileName}");
                    }
                    try
                    {
                        Image output = this.pBoxOutput.Image;
                        output.Save(saveImage.FileName, ImageFormat.Png);
                        MessageBox.Show("Saved successfully");
                    }catch (Exception ex)
                    {
                        MessageBox.Show("Failed to save");
                    }
                }
            }
            else
            {
                MessageBox.Show("Output is not ready to save");
            }
        }

        private async void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                this.pBoxOutput.Image = loadingImage;
                this.pBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                var client = new RestClient("https://removebg.devstroop.com");
                // client.Timeout = -1;
                var request = new RestRequest("", Method.Post);
                request.AddFile("file", InputImagePath);
                var response = await client.ExecuteAsync(request);
                Image image;
                using (MemoryStream ms = new MemoryStream(response.RawBytes))
                {
                    image = Image.FromStream(ms);
                }
                this.pBoxOutput.Image = image;
                this.pBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Failed, Please try again.");
                this.pBoxOutput.Image = noImage;
                this.pBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            }
        }
    }
}
