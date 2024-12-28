namespace DoAnhHuy_1376
{
    partial class QL_DanhMuc
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.them_dm = new System.Windows.Forms.Button();
            this.sua_dm = new System.Windows.Forms.Button();
            this.xoa_dm = new System.Windows.Forms.Button();
            this.timkiem_dm = new System.Windows.Forms.Button();
            this.txt_timkiemdm = new System.Windows.Forms.TextBox();
            this.txt_madm = new System.Windows.Forms.TextBox();
            this.txt_tendm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Danh Mục";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(358, 366);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // them_dm
            // 
            this.them_dm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.them_dm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them_dm.Location = new System.Drawing.Point(426, 172);
            this.them_dm.Name = "them_dm";
            this.them_dm.Size = new System.Drawing.Size(119, 42);
            this.them_dm.TabIndex = 2;
            this.them_dm.Text = "Thêm";
            this.them_dm.UseVisualStyleBackColor = false;
            this.them_dm.Click += new System.EventHandler(this.them_dm_Click);
            // 
            // sua_dm
            // 
            this.sua_dm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sua_dm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua_dm.Location = new System.Drawing.Point(613, 172);
            this.sua_dm.Name = "sua_dm";
            this.sua_dm.Size = new System.Drawing.Size(119, 42);
            this.sua_dm.TabIndex = 3;
            this.sua_dm.Text = "Sửa";
            this.sua_dm.UseVisualStyleBackColor = false;
            this.sua_dm.Click += new System.EventHandler(this.sua_dm_Click);
            // 
            // xoa_dm
            // 
            this.xoa_dm.BackColor = System.Drawing.Color.LightCoral;
            this.xoa_dm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa_dm.Location = new System.Drawing.Point(426, 272);
            this.xoa_dm.Name = "xoa_dm";
            this.xoa_dm.Size = new System.Drawing.Size(119, 42);
            this.xoa_dm.TabIndex = 4;
            this.xoa_dm.Text = "Xóa";
            this.xoa_dm.UseVisualStyleBackColor = false;
            this.xoa_dm.Click += new System.EventHandler(this.xoa_dm_Click);
            // 
            // timkiem_dm
            // 
            this.timkiem_dm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiem_dm.Location = new System.Drawing.Point(426, 371);
            this.timkiem_dm.Name = "timkiem_dm";
            this.timkiem_dm.Size = new System.Drawing.Size(102, 30);
            this.timkiem_dm.TabIndex = 5;
            this.timkiem_dm.Text = "Tìm Kiếm";
            this.timkiem_dm.UseVisualStyleBackColor = true;
            this.timkiem_dm.Click += new System.EventHandler(this.timkiem_dm_Click);
            // 
            // txt_timkiemdm
            // 
            this.txt_timkiemdm.Location = new System.Drawing.Point(534, 371);
            this.txt_timkiemdm.Multiline = true;
            this.txt_timkiemdm.Name = "txt_timkiemdm";
            this.txt_timkiemdm.Size = new System.Drawing.Size(198, 30);
            this.txt_timkiemdm.TabIndex = 6;
            // 
            // txt_madm
            // 
            this.txt_madm.Location = new System.Drawing.Point(562, 59);
            this.txt_madm.Name = "txt_madm";
            this.txt_madm.Size = new System.Drawing.Size(170, 22);
            this.txt_madm.TabIndex = 7;
            // 
            // txt_tendm
            // 
            this.txt_tendm.Location = new System.Drawing.Point(562, 111);
            this.txt_tendm.Name = "txt_tendm";
            this.txt_tendm.Size = new System.Drawing.Size(170, 22);
            this.txt_tendm.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã Danh Mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên Danh Mục";
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(613, 272);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(119, 42);
            this.btn_load.TabIndex = 11;
            this.btn_load.Text = "Tải Lại";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // QL_DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tendm);
            this.Controls.Add(this.txt_madm);
            this.Controls.Add(this.txt_timkiemdm);
            this.Controls.Add(this.timkiem_dm);
            this.Controls.Add(this.xoa_dm);
            this.Controls.Add(this.sua_dm);
            this.Controls.Add(this.them_dm);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "QL_DanhMuc";
            this.Text = "QL_DanhMuc";
            this.Load += new System.EventHandler(this.QL_DanhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button them_dm;
        private System.Windows.Forms.Button sua_dm;
        private System.Windows.Forms.Button xoa_dm;
        private System.Windows.Forms.Button timkiem_dm;
        private System.Windows.Forms.TextBox txt_timkiemdm;
        private System.Windows.Forms.TextBox txt_madm;
        private System.Windows.Forms.TextBox txt_tendm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_load;
    }
}