using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XWingTM.Model;

namespace XWingTM.Views
{
    public partial class PlayerEdit : Form
    {
        Player player;
        PlayerFactory pf;
        Players form;

        public PlayerEdit(Players form,PlayerFactory pf)
        {
            this.form = form;
            this.pf = pf;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player = new Player();
            player.Name = nameTextBox.Text;
            player.Surname = surnameTextBox.Text;
            player.Nickname = nicknameTextBox.Text;
            player.Phone = phoneTextBox.Text;
            player.Location = locationTextBox.Text;
            player.Faction =  factionTextBox.Text;
            player.Notes = notesTextBox.Text;
            player.Email = emailTextBox.Text;

            pf.Save(player);
            this.Hide();
            form.PopulateDataGridView();
        }
    }
}
