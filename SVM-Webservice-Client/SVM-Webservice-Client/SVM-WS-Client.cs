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
        private Boolean searchByTeam;

        public Form1()
        {
            InitializeComponent();
            handler = new SVM_WS_Handler();
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            handler.searchByDate(dtpDate.Value);
            searchByTeam = false;

            lbxResults.Items.Clear();

            foreach (var item in handler.Contests)
            {
                lbxResults.Items.Add(item.name);
            }


        }

        private void btnSearchTeams_Click(object sender, EventArgs e)
        {
            handler.getTeams();
            searchByTeam = true;


            lbxResults.Items.Clear();

            foreach (var item in handler.Teams)
            {
                lbxResults.Items.Add(item.name);
            }

           

        }

        private void lbxResults_SelectedIndexChanged(object sender, EventArgs e)
        {

           if (searchByTeam)
                {
                    handler.searchByTeam((String)lbxResults.SelectedItem);

                    lbxResults.Items.Clear();

                    foreach (var item in handler.Contests)
                    {
                        lbxResults.Items.Add(item.name);
                    }
                    searchByTeam = false;
                }
                else {
                    handler.getMatches((String)lbxResults.SelectedItem);

                    lbxResults.Items.Clear();

                    foreach (var item in handler.Matches)
                    {
                        lbxResults.Items.Add(item.name + "\t\t\t" + item.resultHome + ":" + item.resultAway);
                    }

                }

            }

        }

    
}
