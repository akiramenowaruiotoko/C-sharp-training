namespace EncapsulationSamples
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		// variables in the class, it cannot be operated from outside.
		private string _colorName;

		// sample code of properties
		public string ColorName
		{
			get // Corresponds to methods that obtain values, get is fixed, arguments and () are not written.
			{
				return _colorName; // get arguments value inside.
			}

			set // Corresponds to methods that obtain values, set is fixed, arguments and () are not written.
			{
				// Set does not write an argument, but instead contains a value in value.
				// Check the values and set appropriate values for internal variables.
				if (value == "")
				{
					// Set the internal variable to black if a value is entered.
					_colorName = "Black";
				}
				else
				{
					// Other than the above, set the entered values as they are to internal variables.
					_colorName = value;
				}
			}
		}

		private void buttonSetColor_Click(object sender, EventArgs e)
		{
			// Set the value entered in the text box to the property
			ColorName = textBoxColorValue.Text;

			// Get the value from the property and convert it to color. Undefined colors will be black.
			labelColorResult.ForeColor = Color.FromName(ColorName);
		}
	}
}