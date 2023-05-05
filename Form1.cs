using System;
using System.Windows.Forms;

namespace Calculate_Quiz
{
    public partial class QuizFrm : Form
    {
        private int limit = 500;
        /* 
         * Init question & answer
         * a & b are 2 numbers
         * op is the operator (0 : + | 1 : - | 2 : * | 3 : /)
         * result is the result of the calculation
         */
        private int a, b, op, result;
        // Result position
        private int resultPos;

        public QuizFrm()
        {
            InitializeComponent();
            randomQuestionAndResult();
            randomAnswers();
        }

        private void randomQuestionAndResult()
        {
            // Random 0 <= a < limit, 0 < b <= limit
            Random rnd = new Random();
            a = rnd.Next(limit);
            b = rnd.Next(limit) + 1;
            op = rnd.Next(4);
            switch (op)
            {
                case 0:
                    {
                        result = a + b;
                        this.txtQuestion.Text = a + " + " + b + " = ?";
                        break;
                    }
                case 1:
                    {
                        result = a - b;
                        this.txtQuestion.Text = a + " - " + b + " = ?";
                        break;
                    }
                case 2:
                    {
                        result = a * b;
                        this.txtQuestion.Text = a + " x " + b + " = ?";
                        break;
                    }
                case 3:
                    {
                        result = a / b;
                        this.txtQuestion.Text = a + " / " + b + " = ?";
                        break;
                    }
            }
        }

        private void randomAnswers()
        {
            // Random result position
            Random rnd = new Random();
            resultPos = rnd.Next(4);
            // Random answer
            this.button1.Text = rnd.Next(limit * 5).ToString();
            this.button2.Text = rnd.Next(limit * 5).ToString();
            this.button3.Text = rnd.Next(limit * 5).ToString();
            this.button4.Text = rnd.Next(limit * 5).ToString();
            // Put correct result into correct position answer
            if (resultPos == 0) this.button1.Text = result.ToString();
            if (resultPos == 1) this.button2.Text = result.ToString();
            if (resultPos == 2) this.button3.Text = result.ToString();
            if (resultPos == 3) this.button4.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (resultPos == 0) popupCorrectMessageBox();
            else popupWrongMessageBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (resultPos == 1) popupCorrectMessageBox();
            else popupWrongMessageBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (resultPos == 2) popupCorrectMessageBox();
            else popupWrongMessageBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (resultPos == 3) popupCorrectMessageBox();
            else popupWrongMessageBox();
        }

        private void popupCorrectMessageBox()
        {
            MessageBox.Show("Correct!!!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            randomQuestionAndResult();
            randomAnswers();
        }
        private void popupWrongMessageBox()
        {
            MessageBox.Show("Wrong!!!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            randomQuestionAndResult();
            randomAnswers();
        }
        private void QuizFrm_Load(object sender, EventArgs e)
        {

        }
    }
}