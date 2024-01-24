namespace InheritanceSamples
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
			label1 = new Label();
			buttonAnimal = new Button();
			textBoxAnimalColor = new TextBox();
			textBoxSing = new TextBox();
			textBoxAnimalSmell = new TextBox();
			textBoxAnimalSing = new TextBox();
			textBoxAnimalFlavor = new TextBox();
			textBoxCatFlavor = new TextBox();
			textBoxCatEar = new TextBox();
			textBoxCatSmell = new TextBox();
			textBoxCatColor = new TextBox();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			buttonCat = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(98, 78);
			label1.Name = "label1";
			label1.Size = new Size(67, 32);
			label1.TabIndex = 0;
			label1.Text = "color";
			// 
			// buttonAnimal
			// 
			buttonAnimal.Location = new Point(196, 12);
			buttonAnimal.Name = "buttonAnimal";
			buttonAnimal.Size = new Size(207, 53);
			buttonAnimal.TabIndex = 1;
			buttonAnimal.Text = "Animal cookie";
			buttonAnimal.UseVisualStyleBackColor = true;
			buttonAnimal.Click += buttonAnimal_Click;
			// 
			// textBoxAnimalColor
			// 
			textBoxAnimalColor.Location = new Point(196, 71);
			textBoxAnimalColor.Name = "textBoxAnimalColor";
			textBoxAnimalColor.Size = new Size(207, 39);
			textBoxAnimalColor.TabIndex = 2;
			// 
			// textBoxSing
			// 
			textBoxSing.Location = new Point(419, 251);
			textBoxSing.Name = "textBoxSing";
			textBoxSing.Size = new Size(207, 39);
			textBoxSing.TabIndex = 3;
			// 
			// textBoxAnimalSmell
			// 
			textBoxAnimalSmell.Location = new Point(196, 116);
			textBoxAnimalSmell.Name = "textBoxAnimalSmell";
			textBoxAnimalSmell.Size = new Size(207, 39);
			textBoxAnimalSmell.TabIndex = 5;
			// 
			// textBoxAnimalSing
			// 
			textBoxAnimalSing.Location = new Point(196, 251);
			textBoxAnimalSing.Name = "textBoxAnimalSing";
			textBoxAnimalSing.Size = new Size(207, 39);
			textBoxAnimalSing.TabIndex = 6;
			// 
			// textBoxAnimalFlavor
			// 
			textBoxAnimalFlavor.Location = new Point(196, 161);
			textBoxAnimalFlavor.Name = "textBoxAnimalFlavor";
			textBoxAnimalFlavor.Size = new Size(207, 39);
			textBoxAnimalFlavor.TabIndex = 7;
			// 
			// textBoxCatFlavor
			// 
			textBoxCatFlavor.Location = new Point(419, 161);
			textBoxCatFlavor.Name = "textBoxCatFlavor";
			textBoxCatFlavor.Size = new Size(207, 39);
			textBoxCatFlavor.TabIndex = 11;
			// 
			// textBoxCatEar
			// 
			textBoxCatEar.Location = new Point(419, 206);
			textBoxCatEar.Name = "textBoxCatEar";
			textBoxCatEar.Size = new Size(207, 39);
			textBoxCatEar.TabIndex = 10;
			// 
			// textBoxCatSmell
			// 
			textBoxCatSmell.Location = new Point(419, 116);
			textBoxCatSmell.Name = "textBoxCatSmell";
			textBoxCatSmell.Size = new Size(207, 39);
			textBoxCatSmell.TabIndex = 9;
			// 
			// textBoxCatColor
			// 
			textBoxCatColor.Location = new Point(419, 71);
			textBoxCatColor.Name = "textBoxCatColor";
			textBoxCatColor.Size = new Size(207, 39);
			textBoxCatColor.TabIndex = 8;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(98, 119);
			label2.Name = "label2";
			label2.Size = new Size(70, 32);
			label2.TabIndex = 12;
			label2.Text = "smell";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(98, 161);
			label3.Name = "label3";
			label3.Size = new Size(75, 32);
			label3.TabIndex = 13;
			label3.Text = "flavor";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(98, 209);
			label4.Name = "label4";
			label4.Size = new Size(117, 32);
			label4.TabIndex = 14;
			label4.Text = "ear shape";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(98, 254);
			label5.Name = "label5";
			label5.Size = new Size(58, 32);
			label5.TabIndex = 15;
			label5.Text = "sing";
			// 
			// buttonCat
			// 
			buttonCat.Location = new Point(419, 12);
			buttonCat.Name = "buttonCat";
			buttonCat.Size = new Size(207, 53);
			buttonCat.TabIndex = 16;
			buttonCat.Text = "Cat cookie";
			buttonCat.UseVisualStyleBackColor = true;
			buttonCat.Click += buttonCat_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(buttonCat);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(textBoxCatFlavor);
			Controls.Add(textBoxCatEar);
			Controls.Add(textBoxCatSmell);
			Controls.Add(textBoxCatColor);
			Controls.Add(textBoxAnimalFlavor);
			Controls.Add(textBoxAnimalSing);
			Controls.Add(textBoxAnimalSmell);
			Controls.Add(textBoxSing);
			Controls.Add(textBoxAnimalColor);
			Controls.Add(buttonAnimal);
			Controls.Add(label1);
			Name = "Form1";
			Text = "InheritanceSample";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button buttonAnimal;
		private TextBox textBoxAnimalColor;
		private TextBox textBoxSing;
		private TextBox textBoxAnimalSmell;
		private TextBox textBoxAnimalSing;
		private TextBox textBoxAnimalFlavor;
		private TextBox textBoxCatFlavor;
		private TextBox textBoxCatEar;
		private TextBox textBoxCatSmell;
		private TextBox textBoxCatColor;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Button buttonCat;
	}
}
