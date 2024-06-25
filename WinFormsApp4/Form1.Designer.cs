namespace WinFormsApp4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            txtName = new TextBox();
            txtCaliber = new TextBox();
            txtRange = new TextBox();
            txtWeight = new TextBox();
            txtCountryOfOrigin = new TextBox();
            comboBoxPurpose = new ComboBox();
            txtPrice = new TextBox();
            txtFilterName = new TextBox();
            comboBoxFilterPurpose = new ComboBox();
            txtFilterCaliber = new TextBox();
            txtFilterRange = new TextBox();
            txtFilterWeight = new TextBox();
            txtFilterCountryOfOrigin = new TextBox();
            txtFilterPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(1300, 881);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1463, 193);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 49);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1463, 289);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 47);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1463, 378);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(137, 46);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1463, 461);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 46);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1463, 539);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(137, 42);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(87, 953);
            txtName.Name = "txtName";
            txtName.Size = new Size(141, 35);
            txtName.TabIndex = 6;
            // 
            // txtCaliber
            // 
            txtCaliber.Location = new Point(450, 956);
            txtCaliber.Name = "txtCaliber";
            txtCaliber.Size = new Size(141, 35);
            txtCaliber.TabIndex = 8;
            // 
            // txtRange
            // 
            txtRange.Location = new Point(629, 956);
            txtRange.Name = "txtRange";
            txtRange.Size = new Size(150, 35);
            txtRange.TabIndex = 9;
            txtRange.TextChanged += txtRange_TextChanged;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(825, 956);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(146, 35);
            txtWeight.TabIndex = 10;
            txtWeight.TextChanged += txtWeight_TextChanged;
            // 
            // txtCountryOfOrigin
            // 
            txtCountryOfOrigin.Location = new Point(1010, 956);
            txtCountryOfOrigin.Name = "txtCountryOfOrigin";
            txtCountryOfOrigin.Size = new Size(133, 35);
            txtCountryOfOrigin.TabIndex = 11;
            txtCountryOfOrigin.TextChanged += txtCountryOfOrigin_TextChanged;
            // 
            // comboBoxPurpose
            // 
            comboBoxPurpose.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPurpose.FormattingEnabled = true;
            comboBoxPurpose.Items.AddRange(new object[] { "Артилерійське", "Авіаційне", "Піхотне" });
            comboBoxPurpose.Location = new Point(266, 953);
            comboBoxPurpose.Name = "comboBoxPurpose";
            comboBoxPurpose.Size = new Size(148, 38);
            comboBoxPurpose.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(1177, 956);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(135, 35);
            txtPrice.TabIndex = 12;
            // 
            // txtFilterName
            // 
            txtFilterName.Location = new Point(87, 1030);
            txtFilterName.Name = "txtFilterName";
            txtFilterName.Size = new Size(141, 35);
            txtFilterName.TabIndex = 13;
            txtFilterName.TextChanged += txtFilter_TextChanged;
            // 
            // comboBoxFilterPurpose
            // 
            comboBoxFilterPurpose.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterPurpose.FormattingEnabled = true;
            comboBoxFilterPurpose.Items.AddRange(new object[] { "", "Артилерійське", "Авіаційне", "Піхотне" });
            comboBoxFilterPurpose.Location = new Point(266, 1030);
            comboBoxFilterPurpose.Name = "comboBoxFilterPurpose";
            comboBoxFilterPurpose.Size = new Size(148, 38);
            comboBoxFilterPurpose.TabIndex = 14;
            comboBoxFilterPurpose.SelectedIndexChanged += comboBoxFilterPurpose_SelectedIndexChanged;
            // 
            // txtFilterCaliber
            // 
            txtFilterCaliber.Location = new Point(450, 1030);
            txtFilterCaliber.Name = "txtFilterCaliber";
            txtFilterCaliber.Size = new Size(147, 35);
            txtFilterCaliber.TabIndex = 15;
            txtFilterCaliber.TextChanged += txtFilter_TextChanged;
            // 
            // txtFilterRange
            // 
            txtFilterRange.Location = new Point(629, 1033);
            txtFilterRange.Name = "txtFilterRange";
            txtFilterRange.Size = new Size(150, 35);
            txtFilterRange.TabIndex = 16;
            txtFilterRange.TextChanged += txtFilter_TextChanged;
            // 
            // txtFilterWeight
            // 
            txtFilterWeight.Location = new Point(825, 1030);
            txtFilterWeight.Name = "txtFilterWeight";
            txtFilterWeight.Size = new Size(146, 35);
            txtFilterWeight.TabIndex = 17;
            txtFilterWeight.TextChanged += txtFilter_TextChanged;
            // 
            // txtFilterCountryOfOrigin
            // 
            txtFilterCountryOfOrigin.Location = new Point(1010, 1030);
            txtFilterCountryOfOrigin.Name = "txtFilterCountryOfOrigin";
            txtFilterCountryOfOrigin.Size = new Size(133, 35);
            txtFilterCountryOfOrigin.TabIndex = 18;
            txtFilterCountryOfOrigin.TextChanged += txtFilter_TextChanged;
            // 
            // txtFilterPrice
            // 
            txtFilterPrice.Location = new Point(1177, 1033);
            txtFilterPrice.Name = "txtFilterPrice";
            txtFilterPrice.Size = new Size(135, 35);
            txtFilterPrice.TabIndex = 19;
            txtFilterPrice.TextChanged += txtFilter_TextChanged;
            // 
            // Form1
            // 
            ClientSize = new Size(1769, 1208);
            Controls.Add(txtFilterPrice);
            Controls.Add(txtFilterCountryOfOrigin);
            Controls.Add(txtFilterWeight);
            Controls.Add(txtFilterRange);
            Controls.Add(txtFilterCaliber);
            Controls.Add(comboBoxFilterPurpose);
            Controls.Add(txtFilterName);
            Controls.Add(txtPrice);
            Controls.Add(comboBoxPurpose);
            Controls.Add(txtCountryOfOrigin);
            Controls.Add(txtWeight);
            Controls.Add(txtRange);
            Controls.Add(txtCaliber);
            Controls.Add(txtName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Ammunition Accounting";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCaliber;
        private System.Windows.Forms.TextBox txtRange;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtCountryOfOrigin;
        private System.Windows.Forms.ComboBox comboBoxPurpose;
        private System.Windows.Forms.TextBox txtPrice;

        // Filter controls
        private System.Windows.Forms.TextBox txtFilterName;
        private System.Windows.Forms.ComboBox comboBoxFilterPurpose;
        private System.Windows.Forms.TextBox txtFilterCaliber;
        private System.Windows.Forms.TextBox txtFilterRange;
        private System.Windows.Forms.TextBox txtFilterWeight;
        private System.Windows.Forms.TextBox txtFilterCountryOfOrigin;
        private System.Windows.Forms.TextBox txtFilterPrice;
    }
}
