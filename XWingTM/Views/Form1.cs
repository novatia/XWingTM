using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB.Driver;

namespace XWingTM
{
    public partial class torunamentManager : Form
    {
        MongoServer server;
        MongoClient client;
        MongoDatabase db;

        public torunamentManager()
        {
            InitializeComponent();
            InitMongoDB();
        }

        public void InitMongoDB() {
            client = new MongoClient("mongodb://localhost");
            server = client.GetServer();
            db = server.GetDatabase("tournament_manager");
        }

        private void exitMenuStrip_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are closing the tool, are you sure?", "Warning!", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void playerMenuStrip_Click(object sender, EventArgs e)
        {
            Players player_form = new Players(db);
            player_form.Show();
        }

        private void tournamentMenuStrip_Click(object sender, EventArgs e)
        {
            Tournaments tournament_form = new Tournaments();
            tournament_form.Show();


        }

        private void reportMenuStrip_Click(object sender, EventArgs e)
        {
            Print tournament_form = new Print();
            tournament_form.Show();

        }

        private void infoMenuStrip_Click(object sender, EventArgs e)
        {
            About about_form = new About();
            about_form.Show();

        }

        private void torunamentManager_Load(object sender, EventArgs e)
        {

        }
    }
}
