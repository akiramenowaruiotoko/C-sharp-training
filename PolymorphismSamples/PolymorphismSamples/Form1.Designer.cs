using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PolymorphismSamples
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSing = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.pictureBoxBird = new System.Windows.Forms.PictureBox();
            this.pictureBoxCat = new System.Windows.Forms.PictureBox();
            this.pictureBoxDog = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Animal Cookie";
            // 
            // buttonSing
            // 
            this.buttonSing.Location = new System.Drawing.Point(12, 174);
            this.buttonSing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSing.Name = "buttonSing";
            this.buttonSing.Size = new System.Drawing.Size(678, 55);
            this.buttonSing.TabIndex = 4;
            this.buttonSing.Text = "sing";
            this.buttonSing.UseVisualStyleBackColor = true;
            this.buttonSing.Click += new System.EventHandler(this.ButtonSing_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(12, 258);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(678, 46);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // pictureBoxBird
            // 
            this.pictureBoxBird.Image = global::PolymorphismSamples.Properties.Resources.BirdCookie;
            this.pictureBoxBird.Location = new System.Drawing.Point(468, 33);
            this.pictureBoxBird.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxBird.Name = "pictureBoxBird";
            this.pictureBoxBird.Size = new System.Drawing.Size(222, 120);
            this.pictureBoxBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBird.TabIndex = 3;
            this.pictureBoxBird.TabStop = false;
            // 
            // pictureBoxCat
            // 
            this.pictureBoxCat.Image = global::PolymorphismSamples.Properties.Resources.CatCookie;
            this.pictureBoxCat.Location = new System.Drawing.Point(240, 33);
            this.pictureBoxCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCat.Name = "pictureBoxCat";
            this.pictureBoxCat.Size = new System.Drawing.Size(222, 120);
            this.pictureBoxCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCat.TabIndex = 2;
            this.pictureBoxCat.TabStop = false;
            // 
            // pictureBoxDog
            // 
            this.pictureBoxDog.Image = global::PolymorphismSamples.Properties.Resources.DogCookie;
            this.pictureBoxDog.Location = new System.Drawing.Point(12, 33);
            this.pictureBoxDog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxDog.Name = "pictureBoxDog";
            this.pictureBoxDog.Size = new System.Drawing.Size(222, 120);
            this.pictureBoxDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDog.TabIndex = 0;
            this.pictureBoxDog.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 338);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSing);
            this.Controls.Add(this.pictureBoxBird);
            this.Controls.Add(this.pictureBoxCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxDog);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "AnimalCookie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxDog;
        private Label label1;
        private PictureBox pictureBoxCat;
        private PictureBox pictureBoxBird;
        private Button buttonSing;
        private Button buttonReset;
    }
}
