using System.Windows.Forms;

namespace Ejemplo
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = GetPerdataNewList();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Perdata> Pdata = (List<Perdata>)dataGridView1.DataSource;
            if (nombrebox.Text != "" && edadbox.Text != "")
            {
                Perdata temp = new Perdata(Pdata.Count + 1, nombrebox.Text, edadbox.Text);
                Pdata.Add(temp);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Pdata;
            }
        }
        public List<Perdata> GetPerdataNewList()
        {
            List<Perdata> Pdata = new List<Perdata>();
            Perdata temp = new Perdata(1, "Devesh", "11");
            Pdata.Add(temp);
            temp = new Perdata(2, "Omar", "14");
            Pdata.Add(temp);
            temp = new Perdata(3, "Marco", "23");
            Pdata.Add(temp);
            temp = new Perdata(4, "Carlos", "43");
            Pdata.Add(temp);
            temp = new Perdata(5, "Vanesa", "21");
            Pdata.Add(temp);
            temp = new Perdata(6, "Luisa", "64");
            Pdata.Add(temp);

            return Pdata;
        }


    }
}