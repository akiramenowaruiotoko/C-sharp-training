namespace EncapsulationSamples
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
			labelColorResult = new Label();
			textBoxColorValue = new TextBox();
			buttonSetColor = new Button();
			SuspendLayout();
			// 
			// labelColorResult
			// 
			labelColorResult.AutoSize = true;
			labelColorResult.Location = new Point(39, 32);
			labelColorResult.Name = "labelColorResult";
			labelColorResult.Size = new Size(134, 32);
			labelColorResult.TabIndex = 0;
			labelColorResult.Text = "color to set";
			// 
			// textBoxColorValue
			// 
			textBoxColorValue.Location = new Point(179, 29);
			textBoxColorValue.Name = "textBoxColorValue";
			textBoxColorValue.Size = new Size(200, 39);
			textBoxColorValue.TabIndex = 1;
			textBoxColorValue.Text = "Black";
			// 
			// buttonSetColor
			// 
			buttonSetColor.Location = new Point(397, 25);
			buttonSetColor.Name = "buttonSetColor";
			buttonSetColor.Size = new Size(150, 46);
			buttonSetColor.TabIndex = 2;
			buttonSetColor.Text = "set color";
			buttonSetColor.UseVisualStyleBackColor = true;
			buttonSetColor.Click += buttonSetColor_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(611, 109);
			Controls.Add(buttonSetColor);
			Controls.Add(textBoxColorValue);
			Controls.Add(labelColorResult);
			Name = "Form1";
			Text = "set color with text";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label labelColorResult;
		private TextBox textBoxColorValue;
		private Button buttonSetColor;
	}
}
