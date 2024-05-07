namespace EN_dizaina_risinājums_2024
{
    partial class Form1
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
            this.rtb_apraksts = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_gramatas_nosaukums = new System.Windows.Forms.MaskedTextBox();
            this.rtb_ilustracijas = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.b_tabula = new System.Windows.Forms.Button();
            this.tb_dzest = new System.Windows.Forms.TextBox();
            this.b_Dzest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.b_saglabat_db = new System.Windows.Forms.Button();
            this.tb_autors = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtb_patika = new System.Windows.Forms.RichTextBox();
            this.rtb_nepatika = new System.Windows.Forms.RichTextBox();
            this.dgv_apskatit = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.rtb_zanri = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_apskatit)).BeginInit();
            this.SuspendLayout();
            // 
            // rtb_apraksts
            // 
            this.rtb_apraksts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(119)))), ((int)(((byte)(116)))));
            this.rtb_apraksts.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.rtb_apraksts.ForeColor = System.Drawing.Color.White;
            this.rtb_apraksts.Location = new System.Drawing.Point(9, 206);
            this.rtb_apraksts.Name = "rtb_apraksts";
            this.rtb_apraksts.Size = new System.Drawing.Size(180, 159);
            this.rtb_apraksts.TabIndex = 0;
            this.rtb_apraksts.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(-2, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grāmatas nosaukums";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grāmatas apraksts";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_gramatas_nosaukums
            // 
            this.tb_gramatas_nosaukums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(119)))), ((int)(((byte)(116)))));
            this.tb_gramatas_nosaukums.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.tb_gramatas_nosaukums.ForeColor = System.Drawing.Color.White;
            this.tb_gramatas_nosaukums.Location = new System.Drawing.Point(199, 125);
            this.tb_gramatas_nosaukums.Name = "tb_gramatas_nosaukums";
            this.tb_gramatas_nosaukums.Size = new System.Drawing.Size(100, 29);
            this.tb_gramatas_nosaukums.TabIndex = 3;
            // 
            // rtb_ilustracijas
            // 
            this.rtb_ilustracijas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(119)))), ((int)(((byte)(116)))));
            this.rtb_ilustracijas.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.rtb_ilustracijas.ForeColor = System.Drawing.Color.White;
            this.rtb_ilustracijas.Location = new System.Drawing.Point(227, 206);
            this.rtb_ilustracijas.Name = "rtb_ilustracijas";
            this.rtb_ilustracijas.Size = new System.Drawing.Size(146, 159);
            this.rtb_ilustracijas.TabIndex = 4;
            this.rtb_ilustracijas.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(223, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ilustrāciju apraksts";
            // 
            // b_tabula
            // 
            this.b_tabula.BackColor = System.Drawing.Color.White;
            this.b_tabula.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.b_tabula.Location = new System.Drawing.Point(25, 419);
            this.b_tabula.Name = "b_tabula";
            this.b_tabula.Size = new System.Drawing.Size(168, 31);
            this.b_tabula.TabIndex = 7;
            this.b_tabula.Text = "Pārskatīt datus tabulā";
            this.b_tabula.UseVisualStyleBackColor = false;
            this.b_tabula.Click += new System.EventHandler(this.b_tabula_Click);
            // 
            // tb_dzest
            // 
            this.tb_dzest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(136)))), ((int)(((byte)(115)))));
            this.tb_dzest.Location = new System.Drawing.Point(894, 425);
            this.tb_dzest.Name = "tb_dzest";
            this.tb_dzest.Size = new System.Drawing.Size(100, 20);
            this.tb_dzest.TabIndex = 8;
            // 
            // b_Dzest
            // 
            this.b_Dzest.BackColor = System.Drawing.Color.White;
            this.b_Dzest.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.b_Dzest.Location = new System.Drawing.Point(724, 412);
            this.b_Dzest.Name = "b_Dzest";
            this.b_Dzest.Size = new System.Drawing.Size(164, 33);
            this.b_Dzest.TabIndex = 9;
            this.b_Dzest.Text = "Dzēst kādu no grāmatām";
            this.b_Dzest.UseVisualStyleBackColor = false;
            this.b_Dzest.Click += new System.EventHandler(this.b_Dzest_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(1000, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "(ID numurs)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.label5.Location = new System.Drawing.Point(418, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kas patika";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.label6.Location = new System.Drawing.Point(539, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kas nepatika";
            // 
            // b_saglabat_db
            // 
            this.b_saglabat_db.BackColor = System.Drawing.Color.White;
            this.b_saglabat_db.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.b_saglabat_db.Location = new System.Drawing.Point(393, 331);
            this.b_saglabat_db.Name = "b_saglabat_db";
            this.b_saglabat_db.Size = new System.Drawing.Size(289, 34);
            this.b_saglabat_db.TabIndex = 15;
            this.b_saglabat_db.Text = "Saglabāt datus";
            this.b_saglabat_db.UseVisualStyleBackColor = false;
            this.b_saglabat_db.Click += new System.EventHandler(this.button3_Click);
            // 
            // tb_autors
            // 
            this.tb_autors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(119)))), ((int)(((byte)(116)))));
            this.tb_autors.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.tb_autors.ForeColor = System.Drawing.Color.White;
            this.tb_autors.Location = new System.Drawing.Point(76, 98);
            this.tb_autors.Name = "tb_autors";
            this.tb_autors.Size = new System.Drawing.Size(100, 29);
            this.tb_autors.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label7.Location = new System.Drawing.Point(3, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Autors";
            // 
            // rtb_patika
            // 
            this.rtb_patika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(119)))), ((int)(((byte)(116)))));
            this.rtb_patika.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.rtb_patika.ForeColor = System.Drawing.Color.White;
            this.rtb_patika.Location = new System.Drawing.Point(418, 226);
            this.rtb_patika.Name = "rtb_patika";
            this.rtb_patika.Size = new System.Drawing.Size(100, 96);
            this.rtb_patika.TabIndex = 20;
            this.rtb_patika.Text = "";
            // 
            // rtb_nepatika
            // 
            this.rtb_nepatika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(119)))), ((int)(((byte)(116)))));
            this.rtb_nepatika.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.rtb_nepatika.ForeColor = System.Drawing.Color.White;
            this.rtb_nepatika.Location = new System.Drawing.Point(543, 226);
            this.rtb_nepatika.Name = "rtb_nepatika";
            this.rtb_nepatika.Size = new System.Drawing.Size(100, 96);
            this.rtb_nepatika.TabIndex = 21;
            this.rtb_nepatika.Text = "";
            // 
            // dgv_apskatit
            // 
            this.dgv_apskatit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(136)))), ((int)(((byte)(115)))));
            this.dgv_apskatit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_apskatit.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_apskatit.Location = new System.Drawing.Point(17, 456);
            this.dgv_apskatit.Name = "dgv_apskatit";
            this.dgv_apskatit.Size = new System.Drawing.Size(1067, 246);
            this.dgv_apskatit.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(34, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(445, 38);
            this.label8.TabIndex = 23;
            this.label8.Text = "Lasīto grāmatu dienasgrāmata";
            // 
            // rtb_zanri
            // 
            this.rtb_zanri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(119)))), ((int)(((byte)(116)))));
            this.rtb_zanri.Location = new System.Drawing.Point(758, 58);
            this.rtb_zanri.Name = "rtb_zanri";
            this.rtb_zanri.Size = new System.Drawing.Size(220, 264);
            this.rtb_zanri.TabIndex = 24;
            this.rtb_zanri.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label9.Location = new System.Drawing.Point(754, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "Autora Populārākie žanri";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(755, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "(Angliksi)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(172)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(1096, 714);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rtb_zanri);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgv_apskatit);
            this.Controls.Add(this.rtb_nepatika);
            this.Controls.Add(this.rtb_patika);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_autors);
            this.Controls.Add(this.b_saglabat_db);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b_Dzest);
            this.Controls.Add(this.tb_dzest);
            this.Controls.Add(this.b_tabula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtb_ilustracijas);
            this.Controls.Add(this.tb_gramatas_nosaukums);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_apraksts);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_apskatit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_apraksts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tb_gramatas_nosaukums;
        private System.Windows.Forms.RichTextBox rtb_ilustracijas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_tabula;
        private System.Windows.Forms.TextBox tb_dzest;
        private System.Windows.Forms.Button b_Dzest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_saglabat_db;
        private System.Windows.Forms.TextBox tb_autors;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtb_patika;
        private System.Windows.Forms.RichTextBox rtb_nepatika;
        private System.Windows.Forms.DataGridView dgv_apskatit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtb_zanri;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

