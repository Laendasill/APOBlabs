using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;

using System.Threading.Tasks;
using System.Windows.Forms;
using ImageMagick.Drawables;
using ImageMagick;
namespace APOBlabs
{
    public partial class ColorAndMovement : Form
    {
        PictureBox[] arrayOfImages;
        int item = 0;
        int lastArrayClickIndex = 0;
        int maxitem = 0;
        bool ChangeColorMode = false;
        MainWindow wind;
        Color currentColor;
        Bitmap LastChange;
        public ColorAndMovement(MainWindow im)
        {
            InitializeComponent();
            ImagesLayout.ColumnCount = 0;
            ImagesLayout.RowCount = 0;
            ImagesLayout.AutoScroll = false;
            wind = im;
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
                            pb.Tag = image;
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
        Bitmap Copy(Bitmap bitmap)
        {
            return new Bitmap(bitmap);
        }
        void pb_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pom = (PictureBox)sender;
            Bitmap pomm = (Bitmap)pom.Image;
            
            Color pixel  = pomm.GetPixel(e.X,e.Y);
            lastArrayClickIndex = Array.IndexOf(arrayOfImages,pom);
            if (ChangeColorMode == true)
            {
                
                LastChange = this.Copy(pomm);
                
                ChangeColor(pom, pixel);
            }
            else
            {
                MessageBox.Show("Kolory" + pixel.ToString()+ "(Żeby kolorować obrazek należy zaznaczyć opcje Kolorowanie)");
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
            Color c = currentColor;
            if (c == null)
            {
                c = Color.Black;
            }
            return c;
        }

        private void saveAsGifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String savedgif = null;
            saveFileDialog1.FileName = "animation.gif";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                savedgif = saveFileDialog1.FileName;
            
           
            
                String[] images = new String[arrayOfImages.Length];
                String log = "";
                int i = 0;
                String tmpDir = @"tmp\";
                if(Directory.Exists(@"tmp\")){

                } else {
                    Directory.CreateDirectory(@"tmp\");
                }
                using (ImageMagick.MagickImageCollection collection = new MagickImageCollection())
                {
               
                    foreach (PictureBox image in arrayOfImages)
                    {
                        Bitmap temp = (Bitmap)image.Image;
                        String name = tmpDir +"img" + i + ".png";
                       temp.Save(name);
                        images[i] = name;
                        i += 1;
                    }

                    foreach (String s in images)
                    {
                       collection.Add(s);
                       collection.Write(savedgif);
                        log += s;
                    }

                   // MessageBox.Show(log);

                    ImageWindow pos = new ImageWindow(wind, savedgif);
                }
            }
        }

        private void ColorChoose_Click(object sender, EventArgs e)
        {
            Button pom = (Button)sender;
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog2.Color;
                pom.BackColor = colorDialog2.Color;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
                arrayOfImages[lastArrayClickIndex].Image = (Image)LastChange;
            
        }

        private void animateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] images = new String[arrayOfImages.Length];
            String log = "";
            int i = 0;
            String tmpDir = @"tmp\";
            if (Directory.Exists(@"tmp\"))
            {

            }
            else
            {
                Directory.CreateDirectory(@"tmp\");
            }
            using (ImageMagick.MagickImageCollection collection = new MagickImageCollection())
            {

                foreach (PictureBox image in arrayOfImages)
                {
                    Bitmap temp = (Bitmap)image.Image;
                    String name = tmpDir + "img" + i + ".png";
                    temp.Save(name);
                    images[i] = name;
                    i += 1;
                }

                foreach (String s in images)
                {
                    collection.Add(s);
                    collection.Write(@"tmp\animation.gif");
                    log += s;
                }

                // MessageBox.Show(log);

                ImageWindow pos = new ImageWindow(wind, @"tmp\animation.gif");
            }
        }

        

    }
}
