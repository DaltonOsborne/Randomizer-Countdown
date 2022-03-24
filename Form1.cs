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
        public List<Movie> Movies = new List<Movie> { new Movie { Name = "Pokemon: The First Movie", PublicationDate = DateTime.Parse("06-08-1998") },
        new Movie {Name = "Pokemon:The Movie 2000", PublicationDate = DateTime.Parse("06-17-1999")},
        new Movie { Name = "Pokémon 3: The Movie - Spell of the Unown", PublicationDate = DateTime.Parse("06-08-2000") },
            new Movie { Name = "Pokémon 4Ever: Celebi - Voice of the Forest", PublicationDate = DateTime.Parse("06-07-2001") },
            new Movie { Name = "Pokémon Heroes: Latios and Latias", PublicationDate = DateTime.Parse("06-13-2002") },
            new Movie {Name = "Jirachi—Wish Maker", PublicationDate = DateTime.Parse("06-19-2003") },
            new Movie {Name = "Destiny Deoxys", PublicationDate = DateTime.Parse("06-22-2004") },
            new Movie {Name = "Lucario and the Mystery of Mew", PublicationDate = DateTime.Parse("06-16-2005") },
            new Movie {Name = "Pokemon Ranger and the Temple of the Sea", PublicationDate = DateTime.Parse("06-15-2006") },
            new Movie {Name = "The Rise of Darkrai", PublicationDate = DateTime.Parse("06-14-2007") },
            new Movie {Name = "Giratina and the Sky Warrior", PublicationDate = DateTime.Parse("06-19-2008") },
            new Movie {Name = "Arceus and the Jewel of Life", PublicationDate = DateTime.Parse("06-18-2009") },
            new Movie {Name = "Zoroark--Master of Illusions", PublicationDate = DateTime.Parse("06-10-2010") },
            new Movie {Name = "White--Victini and Zekrom", PublicationDate = DateTime.Parse("06-16-2011") },
            new Movie {Name = "Black--Victini and Reshiram", PublicationDate = DateTime.Parse("06-16-2011") },
            new Movie {Name = "Kyruem vs.the Sword of Justice", PublicationDate = DateTime.Parse("06-14-2012") },
            new Movie {Name = "Genesect and the Legend Awakened", PublicationDate = DateTime.Parse("06-13-2013") },
            new Movie {Name = "Diancie and the Coccoon of Destruction", PublicationDate = DateTime.Parse("06-19-2014") },
            new Movie {Name = "Hoopa and the Clash of Ages", PublicationDate = DateTime.Parse("06-18-2015") },
            new Movie {Name = "Volcanion and the MEchanical Marvel", PublicationDate = DateTime.Parse("06-16-2016") },
            new Movie {Name = "I Choose You!", PublicationDate = DateTime.Parse("06-15-2017") },
            new Movie {Name = "The Power of Us", PublicationDate = DateTime.Parse("06-13-2018") },
            new Movie {Name = "Mewtwo Strikes Back:Evolution", PublicationDate = DateTime.Parse("06-12-2019") },
            new Movie {Name = "Secrets of the Jungle", PublicationDate = DateTime.Parse("12-25-2020") } };
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimeSpan result = this.dateTimePicker2.Value - this.dateTimePicker1.Value;
            this.textBox1.Text = result.ToString();

            string s = textBox1.Text;
            string[] tempArry = textBox1.Text.Split('.');
            textBox1.Text = tempArry[0];
        }
    } 
}
