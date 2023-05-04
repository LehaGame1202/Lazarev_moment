namespace Lazarev_moment
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listbox_customers = new System.Windows.Forms.ListBox();
            this.listbox_orders = new System.Windows.Forms.ListBox();
            this.dataGridView_products = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).BeginInit();
            this.SuspendLayout();
            // 
            // listbox_customers
            // 
            this.listbox_customers.FormattingEnabled = true;
            this.listbox_customers.Location = new System.Drawing.Point(92, 52);
            this.listbox_customers.Name = "listbox_customers";
            this.listbox_customers.Size = new System.Drawing.Size(120, 95);
            this.listbox_customers.TabIndex = 0;
            this.listbox_customers.SelectedIndexChanged += new System.EventHandler(this.listbox_customers_SelectedIndexChanged);
            // 
            // listbox_orders
            // 
            this.listbox_orders.FormattingEnabled = true;
            this.listbox_orders.Location = new System.Drawing.Point(284, 52);
            this.listbox_orders.Name = "listbox_orders";
            this.listbox_orders.Size = new System.Drawing.Size(120, 95);
            this.listbox_orders.TabIndex = 1;
            this.listbox_orders.SelectedIndexChanged += new System.EventHandler(this.listbox_orders_SelectedIndexChanged);
            // 
            // dataGridView_products
            // 
            this.dataGridView_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_products.Location = new System.Drawing.Point(92, 269);
            this.dataGridView_products.Name = "dataGridView_products";
            this.dataGridView_products.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_products.TabIndex = 2;
            this.dataGridView_products.SelectionChanged += new System.EventHandler(this.dataGridView_products_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_products);
            this.Controls.Add(this.listbox_orders);
            this.Controls.Add(this.listbox_customers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_customers;
        private System.Windows.Forms.ListBox listbox_orders;
        private System.Windows.Forms.DataGridView dataGridView_products;
    }
}

