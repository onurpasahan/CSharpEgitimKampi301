namespace CSharpEgitimKampi301.PresentationLayer
{
    partial class FrmProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGetById = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txt55 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnList = new System.Windows.Forms.Button();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txt564 = new System.Windows.Forms.Label();
            this.txtProductDescribtion = new System.Windows.Forms.TextBox();
            this.textt = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.txttt = new System.Windows.Forms.Label();
            this.cmbProductCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnList2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(112, 358);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 33);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(112, 319);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 33);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(112, 397);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 33);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGetById
            // 
            this.btnGetById.Location = new System.Drawing.Point(112, 436);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(149, 33);
            this.btnGetById.TabIndex = 24;
            this.btnGetById.Text = "ID\' ye göre getir";
            this.btnGetById.UseVisualStyleBackColor = true;
            this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(112, 71);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(149, 20);
            this.txtProductName.TabIndex = 21;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // txt55
            // 
            this.txt55.AutoSize = true;
            this.txt55.Location = new System.Drawing.Point(53, 74);
            this.txt55.Name = "txt55";
            this.txt55.Size = new System.Drawing.Size(54, 13);
            this.txt55.TabIndex = 20;
            this.txt55.Text = "Ürün İsmi:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(286, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 424);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(112, 280);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(67, 33);
            this.btnList.TabIndex = 17;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(112, 45);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(149, 20);
            this.txtProductId.TabIndex = 16;
            // 
            // txt564
            // 
            this.txt564.AutoSize = true;
            this.txt564.Location = new System.Drawing.Point(59, 48);
            this.txt564.Name = "txt564";
            this.txt564.Size = new System.Drawing.Size(47, 13);
            this.txt564.TabIndex = 15;
            this.txt564.Text = "Ürün ID:";
            // 
            // txtProductDescribtion
            // 
            this.txtProductDescribtion.Location = new System.Drawing.Point(112, 149);
            this.txtProductDescribtion.Multiline = true;
            this.txtProductDescribtion.Name = "txtProductDescribtion";
            this.txtProductDescribtion.Size = new System.Drawing.Size(149, 83);
            this.txtProductDescribtion.TabIndex = 29;
            // 
            // textt
            // 
            this.textt.AutoSize = true;
            this.textt.Location = new System.Drawing.Point(21, 152);
            this.textt.Name = "textt";
            this.textt.Size = new System.Drawing.Size(86, 13);
            this.textt.TabIndex = 28;
            this.textt.Text = "Ürün Açıklaması:";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(112, 123);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(149, 20);
            this.txtProductPrice.TabIndex = 31;
            this.txtProductPrice.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(46, 126);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(60, 13);
            this.txt.TabIndex = 30;
            this.txt.Text = "Ürün Fiyatı:";
            // 
            // txtProductStock
            // 
            this.txtProductStock.Location = new System.Drawing.Point(112, 97);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(149, 20);
            this.txtProductStock.TabIndex = 33;
            // 
            // txttt
            // 
            this.txttt.AutoSize = true;
            this.txttt.Location = new System.Drawing.Point(44, 100);
            this.txttt.Name = "txttt";
            this.txttt.Size = new System.Drawing.Size(64, 13);
            this.txttt.TabIndex = 32;
            this.txttt.Text = "Ürün Stoğu:";
            // 
            // cmbProductCategory
            // 
            this.cmbProductCategory.FormattingEnabled = true;
            this.cmbProductCategory.Location = new System.Drawing.Point(112, 238);
            this.cmbProductCategory.Name = "cmbProductCategory";
            this.cmbProductCategory.Size = new System.Drawing.Size(149, 21);
            this.cmbProductCategory.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ürün Kategorisi:";
            // 
            // btnList2
            // 
            this.btnList2.Location = new System.Drawing.Point(189, 280);
            this.btnList2.Name = "btnList2";
            this.btnList2.Size = new System.Drawing.Size(72, 33);
            this.btnList2.TabIndex = 36;
            this.btnList2.Text = "Listele 2";
            this.btnList2.UseVisualStyleBackColor = true;
            this.btnList2.Click += new System.EventHandler(this.btnList2_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1092, 566);
            this.Controls.Add(this.btnList2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProductCategory);
            this.Controls.Add(this.txtProductStock);
            this.Controls.Add(this.txttt);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txtProductDescribtion);
            this.Controls.Add(this.textt);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txt55);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.txt564);
            this.Name = "FrmProduct";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label txt55;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label txt564;
        private System.Windows.Forms.TextBox txtProductDescribtion;
        private System.Windows.Forms.Label textt;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.Label txttt;
        private System.Windows.Forms.ComboBox cmbProductCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnList2;
    }
}