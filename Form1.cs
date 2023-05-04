using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculate_Quiz
{
    public partial class QuizFrm : Form
    {
        public QuizFrm()
        {
            InitializeComponent();

        }

        private void popupCorrectMessageBox()
        {
            MessageBox.Show("Correct!!!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void popupWrongMessageBox()
        {
            MessageBox.Show("Wrong!!!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void QuizFrm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}