namespace Login
{
    partial class FormKasir
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtHargaMinuman = new TextBox();
            txtHargaMakanan = new TextBox();
            cmbMinuman = new ComboBox();
            cmbMakanan = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            groupBox3 = new GroupBox();
            txtSubTotalMinuman = new TextBox();
            txtSubTotalMakanan = new TextBox();
            label4 = new Label();
            txtNamaKasir = new TextBox();
            label5 = new Label();
            txtTotal = new TextBox();
            txtBayar = new TextBox();
            txtKembali = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btnClear = new Button();
            btnProses = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 19F, FontStyle.Bold);
            label1.ForeColor = Color.PaleVioletRed;
            label1.Location = new Point(393, 33);
            label1.Name = "label1";
            label1.Size = new Size(433, 67);
            label1.TabIndex = 0;
            label1.Text = "WARUNG MAKAN IRA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtHargaMinuman);
            groupBox1.Controls.Add(txtHargaMakanan);
            groupBox1.Controls.Add(cmbMinuman);
            groupBox1.Controls.Add(cmbMakanan);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.PaleVioletRed;
            groupBox1.Location = new Point(28, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(569, 194);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesan";
            // 
            // txtHargaMinuman
            // 
            txtHargaMinuman.BackColor = Color.LavenderBlush;
            txtHargaMinuman.Location = new Point(388, 127);
            txtHargaMinuman.Name = "txtHargaMinuman";
            txtHargaMinuman.Size = new Size(166, 34);
            txtHargaMinuman.TabIndex = 5;
            // 
            // txtHargaMakanan
            // 
            txtHargaMakanan.BackColor = Color.LavenderBlush;
            txtHargaMakanan.Location = new Point(388, 51);
            txtHargaMakanan.Name = "txtHargaMakanan";
            txtHargaMakanan.Size = new Size(166, 34);
            txtHargaMakanan.TabIndex = 3;
            // 
            // cmbMinuman
            // 
            cmbMinuman.BackColor = Color.LavenderBlush;
            cmbMinuman.FormattingEnabled = true;
            cmbMinuman.Location = new Point(184, 127);
            cmbMinuman.Name = "cmbMinuman";
            cmbMinuman.Size = new Size(182, 39);
            cmbMinuman.TabIndex = 4;
            cmbMinuman.SelectedIndexChanged += cmbMinuman_SelectedIndexChanged;
            // 
            // cmbMakanan
            // 
            cmbMakanan.BackColor = Color.LavenderBlush;
            cmbMakanan.FormattingEnabled = true;
            cmbMakanan.Location = new Point(184, 48);
            cmbMakanan.Name = "cmbMakanan";
            cmbMakanan.Size = new Size(182, 39);
            cmbMakanan.TabIndex = 3;
            cmbMakanan.SelectedIndexChanged += cmbMakanan_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 130);
            label3.Name = "label3";
            label3.Size = new Size(109, 31);
            label3.TabIndex = 3;
            label3.Text = "Minuman";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 51);
            label2.Name = "label2";
            label2.Size = new Size(107, 31);
            label2.TabIndex = 3;
            label2.Text = "Makanan";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.PaleVioletRed;
            groupBox2.Location = new Point(619, 129);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(177, 194);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Satuan";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(21, 127);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(140, 34);
            numericUpDown2.TabIndex = 4;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(21, 53);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(140, 34);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSubTotalMinuman);
            groupBox3.Controls.Add(txtSubTotalMakanan);
            groupBox3.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.PaleVioletRed;
            groupBox3.Location = new Point(807, 129);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(376, 194);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sub Total";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // txtSubTotalMinuman
            // 
            txtSubTotalMinuman.BackColor = Color.LavenderBlush;
            txtSubTotalMinuman.Location = new Point(39, 126);
            txtSubTotalMinuman.Name = "txtSubTotalMinuman";
            txtSubTotalMinuman.Size = new Size(307, 34);
            txtSubTotalMinuman.TabIndex = 4;
            // 
            // txtSubTotalMakanan
            // 
            txtSubTotalMakanan.BackColor = Color.LavenderBlush;
            txtSubTotalMakanan.Location = new Point(39, 53);
            txtSubTotalMakanan.Name = "txtSubTotalMakanan";
            txtSubTotalMakanan.Size = new Size(307, 34);
            txtSubTotalMakanan.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.PaleVioletRed;
            label4.Location = new Point(55, 344);
            label4.Name = "label4";
            label4.Size = new Size(130, 31);
            label4.TabIndex = 3;
            label4.Text = "Nama Kasir";
            // 
            // txtNamaKasir
            // 
            txtNamaKasir.BackColor = Color.LavenderBlush;
            txtNamaKasir.Location = new Point(55, 381);
            txtNamaKasir.Name = "txtNamaKasir";
            txtNamaKasir.Size = new Size(339, 31);
            txtNamaKasir.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.PaleVioletRed;
            label5.Location = new Point(748, 344);
            label5.Name = "label5";
            label5.Size = new Size(74, 31);
            label5.TabIndex = 5;
            label5.Text = "TOTAL";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.LavenderBlush;
            txtTotal.Location = new Point(846, 344);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(307, 31);
            txtTotal.TabIndex = 6;
            // 
            // txtBayar
            // 
            txtBayar.BackColor = Color.LavenderBlush;
            txtBayar.Location = new Point(846, 400);
            txtBayar.Name = "txtBayar";
            txtBayar.Size = new Size(307, 31);
            txtBayar.TabIndex = 7;
            txtBayar.TextChanged += txtBayar_TextChanged;
            // 
            // txtKembali
            // 
            txtKembali.BackColor = Color.LavenderBlush;
            txtKembali.Location = new Point(846, 459);
            txtKembali.Name = "txtKembali";
            txtKembali.Size = new Size(307, 31);
            txtKembali.TabIndex = 8;
            txtKembali.TextChanged += txtKembali_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.PaleVioletRed;
            label6.Location = new Point(748, 400);
            label6.Name = "label6";
            label6.Size = new Size(78, 31);
            label6.TabIndex = 9;
            label6.Text = "BAYAR";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.PaleVioletRed;
            label7.Location = new Point(744, 459);
            label7.Name = "label7";
            label7.Size = new Size(94, 31);
            label7.TabIndex = 10;
            label7.Text = "KEMBALI";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LavenderBlush;
            btnClear.Font = new Font("Poppins", 11F, FontStyle.Bold);
            btnClear.ForeColor = Color.PaleVioletRed;
            btnClear.Location = new Point(378, 538);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(162, 59);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnProses
            // 
            btnProses.BackColor = Color.LavenderBlush;
            btnProses.Font = new Font("Poppins", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProses.ForeColor = Color.PaleVioletRed;
            btnProses.Location = new Point(581, 538);
            btnProses.Name = "btnProses";
            btnProses.Size = new Size(162, 59);
            btnProses.TabIndex = 12;
            btnProses.Text = "Proses";
            btnProses.UseVisualStyleBackColor = false;
            btnProses.Click += btnProses_Click;
            // 
            // FormKasir
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1218, 625);
            Controls.Add(btnProses);
            Controls.Add(btnClear);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtKembali);
            Controls.Add(txtBayar);
            Controls.Add(txtTotal);
            Controls.Add(label5);
            Controls.Add(txtNamaKasir);
            Controls.Add(label4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FormKasir";
            Text = "Kasir";
            Load += FormKasir_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txtHargaMakanan;
        private ComboBox cmbMinuman;
        private ComboBox cmbMakanan;
        private Label label3;
        private Label label2;
        private TextBox txtHargaMinuman;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private TextBox txtSubTotalMinuman;
        private TextBox txtSubTotalMakanan;
        private Label label4;
        private TextBox txtNamaKasir;
        private Label label5;
        private TextBox txtTotal;
        private TextBox txtBayar;
        private TextBox txtKembali;
        private Label label6;
        private Label label7;
        private Button btnClear;
        private Button btnProses;
    }
}