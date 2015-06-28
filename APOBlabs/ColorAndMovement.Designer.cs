namespace APOBlabs
{
    partial class ColorAndMovement
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsGifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImagesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Colormode = new System.Windows.Forms.CheckBox();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.ColorChoose = new System.Windows.Forms.Button();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addImagesToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.undoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(393, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addImagesToolStripMenuItem
            // 
            this.addImagesToolStripMenuItem.Name = "addImagesToolStripMenuItem";
            this.addImagesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.addImagesToolStripMenuItem.Text = "AddImages";
            this.addImagesToolStripMenuItem.Click += new System.EventHandler(this.addImagesToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsGifToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsGifToolStripMenuItem
            // 
            this.saveAsGifToolStripMenuItem.Name = "saveAsGifToolStripMenuItem";
            this.saveAsGifToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.saveAsGifToolStripMenuItem.Text = "Save as gif";
            this.saveAsGifToolStripMenuItem.Click += new System.EventHandler(this.saveAsGifToolStripMenuItem_Click);
            // 
            // ImagesLayout
            // 
            this.ImagesLayout.AutoScroll = true;
            this.ImagesLayout.AutoSize = true;
            this.ImagesLayout.ColumnCount = 1;
            this.ImagesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImagesLayout.Location = new System.Drawing.Point(0, 27);
            this.ImagesLayout.Name = "ImagesLayout";
            this.ImagesLayout.RowCount = 1;
            this.ImagesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImagesLayout.Size = new System.Drawing.Size(86, 23);
            this.ImagesLayout.TabIndex = 1;
            // 
            // Colormode
            // 
            this.Colormode.AutoSize = true;
            this.Colormode.Location = new System.Drawing.Point(297, 33);
            this.Colormode.Name = "Colormode";
            this.Colormode.Size = new System.Drawing.Size(84, 17);
            this.Colormode.TabIndex = 0;
            this.Colormode.Text = "Kolorowanie";
            this.Colormode.UseVisualStyleBackColor = true;
            this.Colormode.CheckedChanged += new System.EventHandler(this.Colormode_CheckedChanged);
            // 
            // colorDialog2
            // 
            this.colorDialog2.AllowFullOpen = false;
            this.colorDialog2.AnyColor = true;
            this.colorDialog2.Color = System.Drawing.Color.Fuchsia;
            // 
            // ColorChoose
            // 
            this.ColorChoose.Location = new System.Drawing.Point(297, 56);
            this.ColorChoose.Name = "ColorChoose";
            this.ColorChoose.Size = new System.Drawing.Size(75, 23);
            this.ColorChoose.TabIndex = 2;
            this.ColorChoose.Text = "button1";
            this.ColorChoose.UseVisualStyleBackColor = true;
            this.ColorChoose.Click += new System.EventHandler(this.ColorChoose_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // ColorAndMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(393, 455);
            this.Controls.Add(this.ColorChoose);
            this.Controls.Add(this.Colormode);
            this.Controls.Add(this.ImagesLayout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ColorAndMovement";
            this.Text = "ColorAndMovement";
            this.Load += new System.EventHandler(this.ColorAndMovement_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addImagesToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel ImagesLayout;
        private System.Windows.Forms.CheckBox Colormode;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsGifToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button ColorChoose;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}