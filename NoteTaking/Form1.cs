using System.Data;

namespace NoteTaking
{
    public partial class Form1 : Form
    {
        DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Messages", typeof(string));

            dataGridView1.DataSource = table;

            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 160;


        }

        private void bttnNew_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text, txtMessage.Text);

            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void bttnRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtMessage.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();

        }
    }
}
