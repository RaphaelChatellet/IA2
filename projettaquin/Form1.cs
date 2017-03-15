﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projettaquin
{
    public partial class Form1 : Form
    {
        string[][] entrepot = new string[25][];
        public Form1()
        {
            InitializeComponent();
            entrepot[0] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[1] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[2] = new string[] { "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0" };
            entrepot[3] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[4] = new string[] { "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0" };
            entrepot[5] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[6] = new string[] { "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0" };
            entrepot[7] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[8] = new string[] { "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0" };
            entrepot[9] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[10] = new string[] { "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0" };
            entrepot[11] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[12] = new string[] { "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0" };
            entrepot[13] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[14] = new string[] { "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0" };
            entrepot[15] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[16] = new string[] { "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0" };
            entrepot[17] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[18] = new string[] { "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0" };
            entrepot[19] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[20] = new string[] { "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0" };
            entrepot[21] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[22] = new string[] { "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0" };
            entrepot[23] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[24] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graph g = new Graph();
            NodeTaquin N0 = new NodeTaquin(textBox1.Text);
            List<GenericNode> Lres = g.RechercheSolutionAEtoile(N0);

            if (Lres.Count == 0)
            {
                labelsolution.Text = "Pas de solution";
            }
            else
            {   labelsolution.Text = "Une solution a été trouvée";
                foreach (GenericNode N in Lres)
                {
                    listBox1.Items.Add( N);
                }
                labelcountopen.Text = "Nb noeuds des ouverts : " + g.CountInOpenList().ToString();
                labelcountclosed.Text = "Nb noeuds des fermés : "+ g.CountInClosedList().ToString();
                g.GetSearchTree( treeView1 );
            }

        }

        private void showtab_Click(object sender, EventArgs e)
        {
        }
    }
}
