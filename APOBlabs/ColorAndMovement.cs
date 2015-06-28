using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageMagick.Drawables;
namespace APOBlabs
{
    public partial class ColorAndMovement : Form
    {
        PictureBox[] arrayOfImages;
        int item = 0;
        int maxitem = 0;
        bool ChangeColorMode = false;
        public ColorAndMovement()
        {
            InitializeComponent();
            ImagesLayout.ColumnCount = 0;
            ImagesLayout.RowCount = 0;
            ImagesLayout.AutoScroll = false;
            Show();
        }

        private void addImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileOpen = new OpenFileDialog();
            FileOpen.Title = "Open Image File";
            FileOpen.Multiselect = true;
            FileOpen.Filter = "JPEG (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|TIFF (*.tiff)|*.tiff|All (*.*)|*.*";
            DialogResult Result = FileOpen.ShowDialog();
            if (Result == DialogResult.OK)
            {
                //ImageWindow img = new ImageWindow(this, FileOpen.FileName);
                arrayOfImages = new PictureBox[FileOpen.FileNames.Length];
                int i = 0;
                maxitem = FileOpen.FileNames.Length;
                String y = "";
                foreach (String image in FileOpen.FileNames)
                {
                    try
                    {
                            y += image + "  ";
                            PictureBox pb = new PictureBox();
                            Image loadedImage = Image.FromFile(image);
                            pb.Height = loadedImage.Height;
                            pb.Width = loadedImage.Width;
                            pb.Image = loadedImage;
                            pb.MouseClick += pb_MouseClick;
                            arrayOfImages[i] = pb;
                           // ImagesLayout.Width = loadedImage.Width;
                           // ImagesLayout.Height = loadedImage.Height;
                           
                            i += 1;
                           
                    
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Cannot display the image: " + image.Substring(image.LastIndexOf('\\'))
                        + ". You may not have permission to read the file, or " +
                        "it may be corrupt.\n\nReported error: " + ex.Message);
                    }
                }
                UpdateImages();
            }
            else FileOpen.Dispose();
        }

        void pb_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pom = (PictureBox)sender;
            Bitmap pomm = (Bitmap)pom.Image;
            
            Color pixel  = pomm.GetPixel(e.X,e.Y);
            if (ChangeColorMode == true)
            {
                ChangeColor(pom, pixel);
            }
            else
            {
                MessageBox.Show(e.X.ToString() + " | " + e.Y.ToString() + "=" + pixel.ToString());
            }

        }



        private void ColorAndMovement_Load(object sender, EventArgs e)
        {

        }

        private void UpdateImages()
        {
            foreach (PictureBox i in arrayOfImages)
            {
                ImagesLayout.Controls.Add(i);
            }
        }

        private void Colormode_CheckedChanged(object sender, EventArgs e)
        {
            if (ChangeColorMode == false)
            {
                ChangeColorMode = true;
            }
            else
            {
                ChangeColorMode = false;
            }
        }

        private void ChangeColor(PictureBox image, Color color)
        {
            Bitmap pomm = (Bitmap)image.Image;
            for (int y = 0; y < pomm.Height; y += 1)
            {
                for (int x = 0; x < pomm.Width; x += 1)
                {
                    Color c = pomm.GetPixel(x, y);
                    if (c != color)
                    {
                        continue;
                    }
                    else
                    {
                        pomm.SetPixel(x, y, GetChosedColor());
                    }
                }
            }

            image.Image = pomm;
        }

        private Color GetChosedColor()
        {
            Color c = Color.Blue;

            return c;
        }

        

    }
}
