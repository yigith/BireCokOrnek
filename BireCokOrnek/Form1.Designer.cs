namespace BireCokOrnek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstDepartmanlar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCalisanlar = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYeniDepartman = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnCalisaniDuzenle = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnYeniCalisan = new System.Windows.Forms.Button();
            this.btnCalisaniSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // lstDepartmanlar
            // 
            this.lstDepartmanlar.DisplayMember = "Ad";
            this.lstDepartmanlar.FormattingEnabled = true;
            this.lstDepartmanlar.ItemHeight = 15;
            this.lstDepartmanlar.Location = new System.Drawing.Point(12, 27);
            this.lstDepartmanlar.Name = "lstDepartmanlar";
            this.lstDepartmanlar.Size = new System.Drawing.Size(148, 364);
            this.lstDepartmanlar.TabIndex = 0;
            this.lstDepartmanlar.SelectedIndexChanged += new System.EventHandler(this.lstDepartmanlar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Departmanlar";
            // 
            // dgvCalisanlar
            // 
            this.dgvCalisanlar.AllowUserToAddRows = false;
            this.dgvCalisanlar.AllowUserToDeleteRows = false;
            this.dgvCalisanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalisanlar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalisanlar.Location = new System.Drawing.Point(180, 27);
            this.dgvCalisanlar.MultiSelect = false;
            this.dgvCalisanlar.Name = "dgvCalisanlar";
            this.dgvCalisanlar.ReadOnly = true;
            this.dgvCalisanlar.RowHeadersVisible = false;
            this.dgvCalisanlar.RowTemplate.Height = 25;
            this.dgvCalisanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalisanlar.Size = new System.Drawing.Size(593, 364);
            this.dgvCalisanlar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Çalışanlar";
            // 
            // btnYeniDepartman
            // 
            this.btnYeniDepartman.Location = new System.Drawing.Point(135, 1);
            this.btnYeniDepartman.Name = "btnYeniDepartman";
            this.btnYeniDepartman.Size = new System.Drawing.Size(25, 23);
            this.btnYeniDepartman.TabIndex = 4;
            this.btnYeniDepartman.Text = "+";
            this.btnYeniDepartman.UseVisualStyleBackColor = true;
            this.btnYeniDepartman.Click += new System.EventHandler(this.btnYeniDepartman_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(12, 397);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(66, 23);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnCalisaniDuzenle
            // 
            this.btnCalisaniDuzenle.Location = new System.Drawing.Point(665, 397);
            this.btnCalisaniDuzenle.Name = "btnCalisaniDuzenle";
            this.btnCalisaniDuzenle.Size = new System.Drawing.Size(108, 23);
            this.btnCalisaniDuzenle.TabIndex = 6;
            this.btnCalisaniDuzenle.Text = "Çalışanı Düzenle";
            this.btnCalisaniDuzenle.UseVisualStyleBackColor = true;
            this.btnCalisaniDuzenle.Click += new System.EventHandler(this.btnCalisaniDuzenle_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(94, 397);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(66, 23);
            this.btnDuzenle.TabIndex = 7;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnYeniCalisan
            // 
            this.btnYeniCalisan.Location = new System.Drawing.Point(748, 1);
            this.btnYeniCalisan.Name = "btnYeniCalisan";
            this.btnYeniCalisan.Size = new System.Drawing.Size(25, 23);
            this.btnYeniCalisan.TabIndex = 8;
            this.btnYeniCalisan.Text = "+";
            this.btnYeniCalisan.UseVisualStyleBackColor = true;
            this.btnYeniCalisan.Click += new System.EventHandler(this.btnYeniCalisan_Click);
            // 
            // btnCalisaniSil
            // 
            this.btnCalisaniSil.Location = new System.Drawing.Point(563, 397);
            this.btnCalisaniSil.Name = "btnCalisaniSil";
            this.btnCalisaniSil.Size = new System.Drawing.Size(96, 23);
            this.btnCalisaniSil.TabIndex = 9;
            this.btnCalisaniSil.Text = "Çalışanı Sil";
            this.btnCalisaniSil.UseVisualStyleBackColor = true;
            this.btnCalisaniSil.Click += new System.EventHandler(this.btnCalisaniSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 427);
            this.Controls.Add(this.btnCalisaniSil);
            this.Controls.Add(this.btnYeniCalisan);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnCalisaniDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYeniDepartman);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCalisanlar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDepartmanlar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departmanlar ve Çalışanlar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstDepartmanlar;
        private Label label1;
        private DataGridView dgvCalisanlar;
        private Label label2;
        private Button btnYeniDepartman;
        private Button btnSil;
        private Button btnCalisaniDuzenle;
        private Button btnDuzenle;
        private Button btnYeniCalisan;
        private Button btnCalisaniSil;
    }
}