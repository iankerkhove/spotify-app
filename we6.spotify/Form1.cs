using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using we6.spotify.logic;

namespace we6.spotify
{
    public partial class Form1 : Form
    {
        private SpotifySearch spotifySearch;

        public Form1()
        {
            spotifySearch = new SpotifySearch();
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Task<List<string>> t = new Task<List<string>>(() => spotifySearch.Search(textBox1.Text));
            t.Start();
            await t;

            foreach (var element in t.Result)
                listBox1.Items.Add(element);
        }
    }
}
