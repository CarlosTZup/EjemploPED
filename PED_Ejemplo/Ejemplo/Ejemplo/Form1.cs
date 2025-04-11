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

        private void button2_Click(object sender, EventArgs e)
        {

            List<Perdata> Pdata = (List<Perdata>)dataGridView1.DataSource;
            if (nombrebox.Text != "" && edadbox.Text != "" && idbox.Text != "")
            {

                if (int.TryParse(idbox.Text, out int id))
                {
                    Perdata itemToEdit = Pdata.FirstOrDefault(p => p.ID == id);

                    if (itemToEdit != null)
                    {
                        itemToEdit.Name = nombrebox.Text;
                        itemToEdit.Age = edadbox.Text;

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = Pdata;
                        MessageBox.Show("Editado!");
                    }
                    else
                    {
                        MessageBox.Show("ID no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("ID inválido.");
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Perdata> Pdata = (List<Perdata>)dataGridView1.DataSource;
            if (idbox.Text != "")
            {

                if (int.TryParse(idbox.Text, out int id))
                {
                    Perdata itemsearched = Pdata.FirstOrDefault(p => p.ID == id);

                    if (itemsearched != null)
                    {
                        nombrebox.Text = itemsearched.Name;
                        edadbox.Text = itemsearched.Age;

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = Pdata;
                        MessageBox.Show("Encontrado!");
                    }
                    else
                    {
                        MessageBox.Show("ID no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("ID inválido.");
                }
            }
            else
            {
                MessageBox.Show("Rellene el campo ID.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Perdata> Pdata = (List<Perdata>)dataGridView1.DataSource;
            if (idbox.Text != "")
            {

                if (int.TryParse(idbox.Text, out int id))
                {
                    Perdata ItemRemove = Pdata.FirstOrDefault(p => p.ID == id);

                    if (ItemRemove != null)
                    {
                        if (nombrebox.Text == ItemRemove.Name && edadbox.Text == ItemRemove.Age)
                        {
                            MessageBox.Show("Eliminando! " + ItemRemove.Name);
                            Pdata.Remove(ItemRemove);
                            for (int i = 0; i < Pdata.Count; i++)
                            {
                                Pdata[i].ID = i + 1;
                            }
                            idbox.Clear();
                            nombrebox.Clear();
                            edadbox.Clear();
                        }
                        else
                            MessageBox.Show("Porfavor valide la informacion de todos los campos.");

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = Pdata;
                    }
                    else
                    {
                        MessageBox.Show("ID no encontrado.");
                    }

                }
                else
                {
                    MessageBox.Show("ID inválido.");
                }
            }
            else
            {
                MessageBox.Show("Rellene el campo ID.");
            }
        }
    }
}