namespace ClassSamples
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
            buttonAnimalInstanceCreate = new Button();
            textBoxName1 = new TextBox();
            textBoxColor1 = new TextBox();
            textBoxSing1 = new TextBox();
            textBoxSing2 = new TextBox();
            textBoxColor2 = new TextBox();
            textBoxName2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // buttonAnimalInstanceCreate
            // 
            buttonAnimalInstanceCreate.Location = new Point(101, 51);
            buttonAnimalInstanceCreate.Name = "buttonAnimalInstanceCreate";
            buttonAnimalInstanceCreate.Size = new Size(554, 45);
            buttonAnimalInstanceCreate.TabIndex = 0;
            buttonAnimalInstanceCreate.Text = "動物クラスのインスタンス生成";
            buttonAnimalInstanceCreate.UseVisualStyleBackColor = true;
            buttonAnimalInstanceCreate.Click += buttonAnimalInstanceCreate_Click;
            // 
            // textBoxName1
            // 
            textBoxName1.Location = new Point(101, 161);
            textBoxName1.Name = "textBoxName1";
            textBoxName1.Size = new Size(263, 39);
            textBoxName1.TabIndex = 1;
            // 
            // textBoxColor1
            // 
            textBoxColor1.Location = new Point(101, 223);
            textBoxColor1.Name = "textBoxColor1";
            textBoxColor1.Size = new Size(263, 39);
            textBoxColor1.TabIndex = 2;
            // 
            // textBoxSing1
            // 
            textBoxSing1.Location = new Point(101, 280);
            textBoxSing1.Name = "textBoxSing1";
            textBoxSing1.Size = new Size(263, 39);
            textBoxSing1.TabIndex = 3;
            // 
            // textBoxSing2
            // 
            textBoxSing2.Location = new Point(392, 280);
            textBoxSing2.Name = "textBoxSing2";
            textBoxSing2.Size = new Size(263, 39);
            textBoxSing2.TabIndex = 6;
            // 
            // textBoxColor2
            // 
            textBoxColor2.Location = new Point(392, 223);
            textBoxColor2.Name = "textBoxColor2";
            textBoxColor2.Size = new Size(263, 39);
            textBoxColor2.TabIndex = 5;
            // 
            // textBoxName2
            // 
            textBoxName2.Location = new Point(392, 161);
            textBoxName2.Name = "textBoxName2";
            textBoxName2.Size = new Size(263, 39);
            textBoxName2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 117);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 7;
            label1.Text = "動物１";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(469, 117);
            label2.Name = "label2";
            label2.Size = new Size(86, 32);
            label2.TabIndex = 8;
            label2.Text = "動物２";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 164);
            label3.Name = "label3";
            label3.Size = new Size(62, 32);
            label3.TabIndex = 9;
            label3.Text = "名前";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 230);
            label4.Name = "label4";
            label4.Size = new Size(38, 32);
            label4.TabIndex = 10;
            label4.Text = "色";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 283);
            label5.Name = "label5";
            label5.Size = new Size(80, 32);
            label5.TabIndex = 11;
            label5.Text = "鳴き声";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSing2);
            Controls.Add(textBoxColor2);
            Controls.Add(textBoxName2);
            Controls.Add(textBoxSing1);
            Controls.Add(textBoxColor1);
            Controls.Add(textBoxName1);
            Controls.Add(buttonAnimalInstanceCreate);
            Name = "Form1";
            Text = "Animal Class Sample";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAnimalInstanceCreate;
        private TextBox textBoxName1;
        private TextBox textBoxColor1;
        private TextBox textBoxSing1;
        private TextBox textBoxSing2;
        private TextBox textBoxColor2;
        private TextBox textBoxName2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
