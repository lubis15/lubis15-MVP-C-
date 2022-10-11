namespace SQLITE_TEST
{
    partial class TokoCRUD
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddToko = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvToko = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToko)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(650, 161);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 63);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(650, 265);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(142, 63);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit ";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddToko
            // 
            this.btnAddToko.Location = new System.Drawing.Point(821, 161);
            this.btnAddToko.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddToko.Name = "btnAddToko";
            this.btnAddToko.Size = new System.Drawing.Size(142, 63);
            this.btnAddToko.TabIndex = 15;
            this.btnAddToko.Text = "Add ";
            this.btnAddToko.UseVisualStyleBackColor = true;
            this.btnAddToko.Click += new System.EventHandler(this.btnAddToko_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 47);
            this.label1.TabIndex = 10;
            this.label1.Text = "Toko CRUD";
            // 
            // dgvToko
            // 
            this.dgvToko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToko.Location = new System.Drawing.Point(10, 161);
            this.dgvToko.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvToko.Name = "dgvToko";
            this.dgvToko.RowHeadersWidth = 62;
            this.dgvToko.Size = new System.Drawing.Size(601, 388);
            this.dgvToko.TabIndex = 9;
            this.dgvToko.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvToko_CellClick);
            this.dgvToko.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvToko_CellContentClick);
            // 
            // TokoCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 686);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddToko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvToko);
            this.Name = "TokoCRUD";
            this.Text = "TokoCRUD";
            this.Load += new System.EventHandler(this.TokoCRUDForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvToko)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddToko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvToko;
    }
}