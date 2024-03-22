namespace AS2324._3G.Prof.RubricaWF
{
    public partial class Form1 : Form
    {
        const int nMaxContatti = 100;

        int nRecordInseriti = 0;
        int cont = 0;

        // definizione array paralleli
        string[] cognome = new string[nMaxContatti];
        string[] nome = new string[nMaxContatti];
        string[] email = new string[nMaxContatti];
        string[] nickname = new string[nMaxContatti];
        int[] simpatia = new int[nMaxContatti];
        int[] annoNascita = new int[nMaxContatti];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            if (cmbRicerca.Text == "")
                MessageBox.Show("E' necessario definire il campo di ricerca.");
            string ricerca = cmbRicerca.Text;
            switch (ricerca)
            {
              
                    
            }
            
            if (txtCognome.Text == ricerca)
           {
                lstElenco.Items.Clear();

                for (int i = 0; i < cont; i++)
                {
                    string elenca = $"-{i + 1} -Nicname:{nickname[i]} -Nome:{nome[i]}  -Cognome:{cognome[i]} -Simpatia:{simpatia[i]} -annoDiNacita:{annoNascita[i]} -email:{email[i]}";
                    lstElenco.Items.Add(elenca);
                }
           }
            if (txtNome.Text == ricerca)
            {
                lstElenco.Items.Clear();

                for (int i = 0; i < cont; i++)
                {
                    string elenca = $"-{i + 1} -Nicname:{nickname[i]} -Nome:{nome[i]}  -Cognome:{cognome[i]} -Simpatia:{simpatia[i]} -annoDiNacita:{annoNascita[i]} -email:{email[i]}";
                    lstElenco.Items.Add(elenca);
                }
            }
            if (txtAnnoNascita.Text == ricerca)
            {
                lstElenco.Items.Clear();

                for (int i = 0; i < cont; i++)
                {
                    string elenca = $"-{i + 1} -Nicname:{nickname[i]} -Nome:{nome[i]}  -Cognome:{cognome[i]} -Simpatia:{simpatia[i]} -annoDiNacita:{annoNascita[i]} -email:{email[i]}";
                    lstElenco.Items.Add(elenca);
                }
            }
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            cont++;
            for (int i = 0; i < cont; i++)
            {
                cognome[i] = txtCognome.Text;
                nome[i] = txtNome.Text;
                email[i] = txtEmail.Text;
                nickname[i] = txtNickName.Text;
                simpatia[i] = Convert.ToInt32(cmbSimpatia.Text);
                annoNascita[i] = Convert.ToInt32(txtAnnoNascita.Text);
                lblNRecord.Text = $" N. record inseriti {cont}";

            }
        }

        private void lblNRecord_Click(object sender, EventArgs e)
        {
            lblNRecord.Text = $" N. record inseriti {cont}";
        }

        private void cmbRicerca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstElenco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnElenca_Click(object sender, EventArgs e)
        {
            lstElenco.Items.Clear();
            
            for (int i = 0; i < cont; i++)
            {
                string elenca = $"-{i + 1} -Nicname:{nickname[i]} -Nome:{nome[i]}  -Cognome:{cognome[i]} -Simpatia:{simpatia[i]} -annoDiNacita:{annoNascita[i]} -email:{email[i]}";
                lstElenco.Items.Add(elenca);
            }
        }
    }
}
