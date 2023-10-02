using ADO.NET_ile_Veritabani_Programlama.Business;
using ADO.NET_ile_Veritabani_Programlama.Database;
using System.Windows.Forms;

namespace ADO.NET_ile_Veritabani_Programlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SeedDataGridByShipper();
        }

        ShipperDAL shipperDAL = new ShipperDAL();
        CategoryDAL categoryDAL = new CategoryDAL();
        ProductDAL productDAL = new ProductDAL();

        List<Category> categories = new List<Category>();

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string companyName = txtAd.Text;
            string phone = txtTelefon.Text;

            if (shipperDAL.Add(companyName, phone))
            {
                MessageBox.Show("Baþarýlý!");
            }
            else
            {
                MessageBox.Show("Baþarýsýz!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string companyName = txtAd.Text;
            string phone = txtTelefon.Text;

            if (shipperDAL.Update(id, companyName, phone))
            {
                MessageBox.Show("Baþarýlý!");
            }
            else
            {
                MessageBox.Show("Baþarýsýz!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);

            if (shipperDAL.Delete(id))
            {
                MessageBox.Show("Baþarýlý!");
            }
            else
            {
                MessageBox.Show("Baþarýsýz!");
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            SeedDataGridByShipper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> single = new List<String>();
            single.Add(shipperDAL.GetCompanyNameById(int.Parse(txtById.Text)));
            dataGridView1.DataSource = single;
        }

        private void northwindTabs_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == sirketTab)
            {
                SeedDataGridByShipper();
            }

            if (e.TabPage == kategoriTab)
            {
                SeedComboBoxByCategory();
            }

        }

        private void SeedComboBoxByCategory()
        {
            cmbCategory.DataSource = categoryDAL.GetCategories();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
        }

        private void SeedDataGridByShipper()
        {
            dataGridView1.DataSource = shipperDAL.GetShippers();
        }

        private void SeedComboBoxByProduct()
        {
            int categoryId = ((Category)(cmbCategory.SelectedItem)).CategoryID;


            cmbProduct.DataSource = productDAL.GetProductsByCategoryID(categoryId);
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductID";
        }

        private void GetProductInfo()
        {
            int productId = ((Product)(cmbProduct.SelectedItem)).ProductID;
            Product product = productDAL.GetProductById(productId);

            lblUrunNo.Text = productId.ToString();
            lblUrunAd.Text = product.ProductName;
            lblBirimFiyat.Text = product.UnitPrice.ToString();
            lblStokAdet.Text = product.UnitsInStock.ToString();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeedComboBoxByProduct();
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProductInfo();
        }
    }
}