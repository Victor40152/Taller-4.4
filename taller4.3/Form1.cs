using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller4._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            lblnom.Text = txtnombre.Text;
            lblnom.ForeColor = Color.Blue;
            lblnom.Font = new Font(lblnom.Font.Name, 25);
            lblnom.Font = new System.Drawing.Font(lblnom.Font, FontStyle.Bold);



        }
    }
}
