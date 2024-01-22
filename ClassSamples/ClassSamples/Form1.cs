namespace ClassSamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAnimalInstanceCreate_Click(object sender, EventArgs e)
        {
            Animal cat = new Animal();
            Animal dog = new Animal();

            // setting concreate value to cat instance
            cat.name = "ƒlƒR";
            cat.color = "”’";

            // display value of cat instance in textbox
            textBoxName1.Text = cat.name;
            textBoxColor1.Text = cat.color;
            textBoxSing1.Text = cat.Sing();

            // setting concreate value to dog instance
            dog.name = "ƒCƒk";
            dog.color = "’ƒ";

            // display value of dog instance in textbox
            textBoxName2.Text = dog.name;
            textBoxColor2.Text = dog.color;
            textBoxSing2.Text = dog.Sing();

        }
    }
}
