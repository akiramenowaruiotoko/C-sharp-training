using System;
using System.Windows.Forms;

namespace PolymorphismSamples
{
    public partial class FormCookie : Form
    {
        public FormCookie()
        {
            InitializeComponent();
        }

        Animal animalCookie; // class instance variables that can be used throughout the class

        // Inplementation of animal cookie, sing() 
        private void ButtonSing_Click(object sender, EventArgs e)
        {
            animalCookie = new Dog(); // setting an instance of the dog class
            pictureBoxDog.Image = animalCookie.Sing(); // Set the image of the back side of the dog cookie
            animalCookie = new Cat();
            pictureBoxCat.Image = animalCookie.Sing(); // Set the image of the back side of the cat cookie
            animalCookie = new Bird();
            pictureBoxBird.Image = animalCookie.Sing(); // Set the image of the back side of the bird cookie

        }

        // reset animal cookie to back side
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            animalCookie = new Dog();
            pictureBoxDog.Image = animalCookie.Reset(); // Set the image of the front side of the dog cookie
            animalCookie = new Cat();
            pictureBoxCat.Image = animalCookie.Reset(); // Set the image of the front side of the cat cookie
            animalCookie = new Bird();
            pictureBoxBird.Image = animalCookie.Reset(); // Set the image of the front side of the bird cookie
        }
    }
}
