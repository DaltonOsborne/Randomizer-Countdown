using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randomizer_Countdown
{
    public partial class Form1 : Form
    {
        public List<Movie> Movies = new List<Movie> { new Movie { Name = "This is cool" } };
        public Form1()
        {
            InitializeComponent();
            Movies.ForEach(movie => { listBox1.Items.Add(movie.Name); });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random Movie = new Random();
            int i = listBox1.Items.Count;
            int chosenItem = Movie.Next(0, 24);

            listBox1.SelectedIndex = chosenItem;

            MessageBox.Show("The movie is: " + listBox1.SelectedItem.ToString());
        }
    }
}
