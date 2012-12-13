using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVM_Webservice_Client
{
    public partial class Form1 : Form
    {

        private SVM_WS_Handler handler;

        public Form1()
        {
            InitializeComponent();
            handler = new SVM_WS_Handler();
            btnSearchTeams_Click(this, new EventArgs());
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            handler.searchByDate(dtpDate.Value);
            dgvContests.DataSource = handler.Contests;
            tabControl1.SelectedIndex = 1;
        }

        private void btnSearchTeams_Click(object sender, EventArgs e)
        {
            handler.getTeams();
            dgvTeams.DataSource = handler.Teams;
            tabControl1.SelectedIndex = 0;
        }

        private void dgvTeams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTeams.SelectedCells.Count == 1)
            {
                handler.searchByTeam(handler.Teams[dgvTeams.SelectedCells[0].RowIndex]);
                dgvContests.DataSource = handler.Contests;
                tabControl1.SelectedIndex = 1;
            }
        }

        private void dgvContests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvContests.SelectedCells.Count == 1)
            {
                handler.getMatches(handler.Contests[dgvContests.SelectedCells[0].RowIndex]);
                dgvMatches.DataSource = handler.Matches;
                tabControl1.SelectedIndex = 2;
            }
        }

    }


}
