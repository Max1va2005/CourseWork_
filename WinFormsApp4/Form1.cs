using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private List<Ammunition> ammunitionList;
        private int currentNumber;
        private int selectedIndex = -1;

        public Form1()
        {
            InitializeComponent();
            ammunitionList = new List<Ammunition>();
            InitializeDataGridView();
            currentNumber = 1;
        }

        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 7; // Змінити кількість стовпців на 7
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Purpose";
            dataGridView1.Columns[2].Name = "Caliber";
            dataGridView1.Columns[3].Name = "Range";
            dataGridView1.Columns[4].Name = "Weight";
            dataGridView1.Columns[5].Name = "Country Of Origin";
            dataGridView1.Columns[6].Name = "Price";

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void AddAmmunition(Ammunition ammunition)
        {
            ammunitionList.Add(ammunition);
            dataGridView1.Rows.Add(ammunition.Name, ammunition.Purpose, ammunition.Caliber, ammunition.Range, ammunition.Weight, ammunition.CountryOfOrigin, ammunition.Price);

            // Оновлення нумерації рядків
            ReNumberRows();
        }

        private void EditAmmunition(int index, Ammunition ammunition)
        {
            ammunitionList[index] = ammunition;
            dataGridView1.Rows[index].Cells[0].Value = ammunition.Name;
            dataGridView1.Rows[index].Cells[1].Value = ammunition.Purpose;
            dataGridView1.Rows[index].Cells[2].Value = ammunition.Caliber;
            dataGridView1.Rows[index].Cells[3].Value = ammunition.Range;
            dataGridView1.Rows[index].Cells[4].Value = ammunition.Weight;
            dataGridView1.Rows[index].Cells[5].Value = ammunition.CountryOfOrigin;
            dataGridView1.Rows[index].Cells[6].Value = ammunition.Price;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string purpose = comboBoxPurpose.SelectedItem?.ToString();
            string caliber = txtCaliber.Text;
            string range = txtRange.Text;
            string weight = txtWeight.Text;
            string countryOfOrigin = txtCountryOfOrigin.Text;
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            if (string.IsNullOrEmpty(purpose))
            {
                MessageBox.Show("Please select a purpose.");
                return;
            }

            Ammunition ammunition = new Ammunition(name, purpose, caliber, range, weight, countryOfOrigin, price);
            AddAmmunition(ammunition);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows.RemoveAt(rowIndex);
                ammunitionList.RemoveAt(rowIndex);
                ReNumberRows();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedIndex = dataGridView1.SelectedRows[0].Index;
                Ammunition selectedAmmunition = ammunitionList[selectedIndex];
                txtName.Text = selectedAmmunition.Name;
                comboBoxPurpose.SelectedItem = selectedAmmunition.Purpose;
                txtCaliber.Text = selectedAmmunition.Caliber;
                txtRange.Text = selectedAmmunition.Range;
                txtWeight.Text = selectedAmmunition.Weight;
                txtCountryOfOrigin.Text = selectedAmmunition.CountryOfOrigin;
                txtPrice.Text = selectedAmmunition.Price.ToString();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0 && selectedIndex < ammunitionList.Count)
            {
                string name = txtName.Text;
                string purpose = comboBoxPurpose.SelectedItem?.ToString();
                string caliber = txtCaliber.Text;
                string range = txtRange.Text;
                string weight = txtWeight.Text;
                string countryOfOrigin = txtCountryOfOrigin.Text;
                if (!decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    MessageBox.Show("Please enter a valid price.");
                    return;
                }

                if (string.IsNullOrEmpty(purpose))
                {
                    MessageBox.Show("Please select a purpose.");
                    return;
                }

                Ammunition updatedAmmunition = new Ammunition(name, purpose, caliber, range, weight, countryOfOrigin, price);
                EditAmmunition(selectedIndex, updatedAmmunition);
                selectedIndex = -1;
                ClearFields();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            selectedIndex = -1;
            ClearFields();
        }

        private void ClearFields()
        {
            txtName.Text = "";
            comboBoxPurpose.SelectedIndex = -1;
            txtCaliber.Text = "";
            txtRange.Text = "";
            txtWeight.Text = "";
            txtCountryOfOrigin.Text = "";
            txtPrice.Text = "";
        }

        private void ReNumberRows()
        {
            int number = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.HeaderCell.Value = number.ToString();
                number++;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedIndex = e.RowIndex;
                Ammunition selectedAmmunition = ammunitionList[selectedIndex];
                txtName.Text = selectedAmmunition.Name;
                comboBoxPurpose.SelectedItem = selectedAmmunition.Purpose;
                txtCaliber.Text = selectedAmmunition.Caliber;
                txtRange.Text = selectedAmmunition.Range;
                txtWeight.Text = selectedAmmunition.Weight;
                txtCountryOfOrigin.Text = selectedAmmunition.CountryOfOrigin;
                txtPrice.Text = selectedAmmunition.Price.ToString();
            }
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void comboBoxFilterPurpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void FilterData()
        {
            var filteredList = ammunitionList.Where(a =>
                (string.IsNullOrEmpty(txtFilterName.Text) || a.Name.Contains(txtFilterName.Text, StringComparison.OrdinalIgnoreCase)) &&
                (comboBoxFilterPurpose.SelectedItem == null || a.Purpose.Equals(comboBoxFilterPurpose.SelectedItem.ToString(), StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(txtFilterCaliber.Text) || a.Caliber.Contains(txtFilterCaliber.Text, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(txtFilterRange.Text) || a.Range.Contains(txtFilterRange.Text, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(txtFilterWeight.Text) || a.Weight.Contains(txtFilterWeight.Text, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(txtFilterCountryOfOrigin.Text) || a.CountryOfOrigin.Contains(txtFilterCountryOfOrigin.Text, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(txtFilterPrice.Text) || a.Price.ToString().Contains(txtFilterPrice.Text))
            ).ToList();

            dataGridView1.Rows.Clear();
            foreach (var ammunition in filteredList)
            {
                dataGridView1.Rows.Add(ammunition.Name, ammunition.Purpose, ammunition.Caliber, ammunition.Range, ammunition.Weight, ammunition.CountryOfOrigin, ammunition.Price);
            }

            ReNumberRows();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCountryOfOrigin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtRange_TextChanged(object sender, EventArgs e)
        {

        }
    }
}