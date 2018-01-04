using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB.Driver;
using XWingTM.Model;
using XWingTM.Views;

namespace XWingTM
{
    public partial class Players : Form
    {
        private MongoDatabase db;
        private PlayerFactory pf;
        private MongoCursor<Player> list;

        public Players(MongoDatabase db)
        {
            this.db = db;
            pf = new PlayerFactory(db);

            InitializeComponent();
        }

        private void Players_Load(object sender, EventArgs e)
        {
            InitDataGrid();
            PopulateDataGridView();
        }

        public void InitDataGrid() {
            playersGridView.ColumnCount = 5;
            playersGridView.Columns[0].Name = "Name";
            playersGridView.Columns[1].Name = "Surname";
            playersGridView.Columns[2].Name = "Nickname";
            playersGridView.Columns[3].Name = "Faction";
            playersGridView.Columns[4].Name = "Location";
            playersGridView.Columns[4].Name = "Notes";
            playersGridView.CellDoubleClick += playersGridView_CellDoubleClick;
        }

        private void playersGridView_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {   
           
        }
        
        public void PopulateDataGridView(){
            list = pf.GetList();
            playersGridView.Rows.Clear();

            foreach (Player current_player in list)
            {
                string[] row = {current_player.Name,current_player.Surname,current_player.Nickname,current_player.Faction,current_player.Location,current_player.Notes};
                playersGridView.Rows.Add(row);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PlayerEdit pe = new PlayerEdit(this,pf);
            pe.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //get selected 
            Player[] to_remove = list.ToArray();

            Player target = to_remove[playersGridView.CurrentCell.RowIndex];

            DialogResult result = MessageBox.Show("Are you sure you want to delete permanently?", "Warning!", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                pf.Remove(target);
            //remove selected
            PopulateDataGridView();
        }
    }
}
