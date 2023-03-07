namespace MR_saldumi_11kl_ms_forms
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
            this.darbibas_poga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.teksts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kg_daudzums = new System.Windows.Forms.Label();
            this.rezultats = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.krabitis = new System.Windows.Forms.CheckBox();
            this.delfins = new System.Windows.Forms.CheckBox();
            this.bocka = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // darbibas_poga
            // 
            this.darbibas_poga.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darbibas_poga.Location = new System.Drawing.Point(494, 139);
            this.darbibas_poga.Name = "darbibas_poga";
            this.darbibas_poga.Size = new System.Drawing.Size(134, 27);
            this.darbibas_poga.TabIndex = 0;
            this.darbibas_poga.Text = "Nospiediet pogu!";
            this.darbibas_poga.UseVisualStyleBackColor = true;
            this.darbibas_poga.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ievadiet cik naudas jus velaties teret saldumu iegade :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // teksts
            // 
            this.teksts.Location = new System.Drawing.Point(396, 143);
            this.teksts.Name = "teksts";
            this.teksts.Size = new System.Drawing.Size(92, 20);
            this.teksts.TabIndex = 2;
            this.teksts.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(472, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Saldumu daudzums(Kg) cik jums sanaks par ievadito naudas summu : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // kg_daudzums
            // 
            this.kg_daudzums.AutoSize = true;
            this.kg_daudzums.Location = new System.Drawing.Point(544, 176);
            this.kg_daudzums.Name = "kg_daudzums";
            this.kg_daudzums.Size = new System.Drawing.Size(0, 13);
            this.kg_daudzums.TabIndex = 6;
            // 
            // rezultats
            // 
            this.rezultats.AutoSize = true;
            this.rezultats.Location = new System.Drawing.Point(485, 193);
            this.rezultats.Name = "rezultats";
            this.rezultats.Size = new System.Drawing.Size(143, 13);
            this.rezultats.TabIndex = 7;
            this.rezultats.Text = "Seit bus konfeksu daudzums";
            this.rezultats.Click += new System.EventHandler(this.rezultats_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(12, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(338, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Atkeksejiet kadus saldumus velaties iegadaties : ";
            // 
            // krabitis
            // 
            this.krabitis.AutoSize = true;
            this.krabitis.Location = new System.Drawing.Point(35, 54);
            this.krabitis.Name = "krabitis";
            this.krabitis.Size = new System.Drawing.Size(123, 17);
            this.krabitis.TabIndex = 9;
            this.krabitis.Text = "\"Krabitis\" | 7.99€/Kg";
            this.krabitis.UseVisualStyleBackColor = true;
            this.krabitis.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // delfins
            // 
            this.delfins.AutoSize = true;
            this.delfins.Location = new System.Drawing.Point(35, 77);
            this.delfins.Name = "delfins";
            this.delfins.Size = new System.Drawing.Size(124, 17);
            this.delfins.TabIndex = 10;
            this.delfins.Text = "\"Delfins\" |  5.99€/Kg";
            this.delfins.UseVisualStyleBackColor = true;
            this.delfins.CheckedChanged += new System.EventHandler(this.delfins_CheckedChanged);
            // 
            // bocka
            // 
            this.bocka.AutoSize = true;
            this.bocka.Location = new System.Drawing.Point(35, 100);
            this.bocka.Name = "bocka";
            this.bocka.Size = new System.Drawing.Size(126, 17);
            this.bocka.TabIndex = 11;
            this.bocka.Text = "\"Bocka\" | 20.99€/Kg";
            this.bocka.UseVisualStyleBackColor = true;
            this.bocka.CheckedChanged += new System.EventHandler(this.bocka_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(957, 411);
            this.Controls.Add(this.bocka);
            this.Controls.Add(this.delfins);
            this.Controls.Add(this.krabitis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rezultats);
            this.Controls.Add(this.kg_daudzums);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teksts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.darbibas_poga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button darbibas_poga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teksts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label kg_daudzums;
        private System.Windows.Forms.Label rezultats;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox krabitis;
        private System.Windows.Forms.CheckBox delfins;
        private System.Windows.Forms.CheckBox bocka;
    }
}

