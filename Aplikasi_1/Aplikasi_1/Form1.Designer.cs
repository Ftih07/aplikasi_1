namespace Aplikasi_1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNama = new TextBox();
            txtfavoritfood = new TextBox();
            txtfavoritcolor = new TextBox();
            button_apply = new Button();
            button_clear = new Button();
            button_exit = new Button();
            colorDialog1 = new ColorDialog();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblkesimpulan = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 22);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "Masukkan Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 69);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 1;
            label2.Text = "Masukkan Makanan Favorit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 117);
            label3.Name = "label3";
            label3.Size = new Size(168, 20);
            label3.TabIndex = 2;
            label3.Text = "Masukkan Warna Favorit";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(252, 19);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(365, 27);
            txtNama.TabIndex = 3;
            // 
            // txtfavoritfood
            // 
            txtfavoritfood.Location = new Point(252, 69);
            txtfavoritfood.Name = "txtfavoritfood";
            txtfavoritfood.Size = new Size(365, 27);
            txtfavoritfood.TabIndex = 4;
            // 
            // txtfavoritcolor
            // 
            txtfavoritcolor.Location = new Point(252, 117);
            txtfavoritcolor.Name = "txtfavoritcolor";
            txtfavoritcolor.Size = new Size(365, 27);
            txtfavoritcolor.TabIndex = 5;
            // 
            // button_apply
            // 
            button_apply.BackColor = Color.Yellow;
            button_apply.Location = new Point(661, 19);
            button_apply.Name = "button_apply";
            button_apply.Size = new Size(88, 37);
            button_apply.TabIndex = 6;
            button_apply.Text = "Apply";
            button_apply.UseVisualStyleBackColor = false;
            button_apply.Click += button1_Click;
            // 
            // button_clear
            // 
            button_clear.BackColor = Color.Yellow;
            button_clear.Location = new Point(661, 69);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(88, 37);
            button_clear.TabIndex = 7;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button2_Click;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.Yellow;
            button_exit.Location = new Point(661, 117);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(88, 37);
            button_exit.TabIndex = 8;
            button_exit.Text = "Exit";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_exit);
            groupBox1.Controls.Add(button_clear);
            groupBox1.Controls.Add(button_apply);
            groupBox1.Controls.Add(txtfavoritcolor);
            groupBox1.Controls.Add(txtfavoritfood);
            groupBox1.Controls.Add(txtNama);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(17, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(768, 166);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblkesimpulan);
            groupBox2.Location = new Point(17, 208);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(768, 208);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // lblkesimpulan
            // 
            lblkesimpulan.AutoSize = true;
            lblkesimpulan.Location = new Point(15, 23);
            lblkesimpulan.Name = "lblkesimpulan";
            lblkesimpulan.Size = new Size(86, 20);
            lblkesimpulan.TabIndex = 9;
            lblkesimpulan.Text = "Kesimpulan";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Aplikasi Menampilkan Data";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNama;
        private TextBox txtfavoritfood;
        private TextBox txtfavoritcolor;
        private Button button_apply;
        private Button button_clear;
        private Button button_exit;
        private ColorDialog colorDialog1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblkesimpulan;
    }
}