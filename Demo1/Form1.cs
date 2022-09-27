namespace Demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            if(checkBoxInscrit.Checked == true)
            {
                labelInscrit.Visible = true;
            }
            else
            {
                labelInscrit.Visible = false;
                if(progressBar1.Value <= 100 && progressBar1.Value != 100) 
                {
                    labelMax.Visible = false;
                    listBox1.Items.Add(textBoxNom.Text);
                    progressBar1.Value += 10;
                }
                else
                {
                    labelMax.Visible = true;
                }
            }
        }
    }
}