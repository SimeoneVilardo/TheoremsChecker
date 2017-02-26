using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheoremsCheckerCore;
using TheoremsCheckerCore.Models;

namespace TheoremsCheckerUI
{
    public partial class TheoremsCheckerHome : Form
    {

        private Theorem currentTheorem;
        private TheoremsChecker tcc;

        public TheoremsCheckerHome()
        {
            InitializeComponent();
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                txtSource.Text = ofd.FileName;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                tcc = new TheoremsChecker(txtSource.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore caricamento file teoremi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            lblTeorema.Enabled = true;
            txtTeorema.Enabled = true;
            btnConfirm.Enabled = true;

            currentTheorem = tcc.GetRndTheorem();
            lblTeorema.Text = currentTheorem.Name;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Theorem theorem = tcc.ParseString(txtTeorema.Text);
            theorem.Id = currentTheorem.Id;
            if (tcc.CheckTheorem(theorem))
                MessageBox.Show("Esatto", "Esatto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Sbagliato", "Sbagliato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
