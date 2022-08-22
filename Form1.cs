namespace MiniCalco
{
    public partial class Form1 : Form
    {
        public string oprateur = "";
        double number = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button digit = (Button)sender;
            TxtResult.Text += digit.Text;
        }

        private void operateur_Click(object sender, EventArgs e)
        {
            Button BtnOperator = (Button)sender;
            if (TxtResult.Text != "")
            {
                number = Convert.ToDouble(TxtResult.Text);
                TxtResult.Clear();
                TxtResult.Focus();//= BtnOperator.Text;
                oprateur =BtnOperator.Text;

            }
           
            
        }

        private void equal_Click(object sender, EventArgs e)
        {
            switch(oprateur)
            {
                case "+":

                    TxtResult.Text = (number + Convert.ToDouble(TxtResult.Text)).ToString();
                    break;
                case "/":
                    TxtResult.Text = (number / Convert.ToDouble(TxtResult.Text)).ToString();
                    break;
                case "*":
                    TxtResult.Text = (number * Convert.ToDouble(TxtResult.Text)).ToString();
                    break;
                case "-":
                    TxtResult.Text = (number - Convert.ToDouble(TxtResult.Text)).ToString();
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TxtResult.Clear();
            oprateur = "";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            int c = TxtResult.TextLength;
            int flag = 0;
            string text = TxtResult.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                TxtResult.Text = TxtResult.Text + ".";
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
           int len = TxtResult.Text.Length - 1;
            string text = TxtResult.Text;
            TxtResult.Clear();
            for (int i = 0; i < len; i++) {
                TxtResult.Text += text[i];
            }        
        }
    }
}