
namespace Aplicatie_Produse
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbRON = new System.Windows.Forms.RadioButton();
            this.rbEUR = new System.Windows.Forms.RadioButton();
            this.rbUSD = new System.Windows.Forms.RadioButton();
            this.cbxProdusNou = new System.Windows.Forms.CheckBox();
            this.lvNou = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lvSH = new System.Windows.Forms.ListView();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categorie";
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Items.AddRange(new object[] {
            "Telefon",
            "Tableta",
            "Smart Watch",
            "Casti Wireless",
            "Leptop",
            "PC "});
            this.cmbCategorie.Location = new System.Drawing.Point(189, 18);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(121, 24);
            this.cmbCategorie.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Denumire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pret";
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(189, 53);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(121, 22);
            this.txtDenumire.TabIndex = 5;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(189, 88);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(121, 22);
            this.txtPret.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Moneda";
            // 
            // rbRON
            // 
            this.rbRON.AutoSize = true;
            this.rbRON.Location = new System.Drawing.Point(189, 122);
            this.rbRON.Name = "rbRON";
            this.rbRON.Size = new System.Drawing.Size(60, 21);
            this.rbRON.TabIndex = 8;
            this.rbRON.TabStop = true;
            this.rbRON.Text = "RON";
            this.rbRON.UseVisualStyleBackColor = true;
            // 
            // rbEUR
            // 
            this.rbEUR.AutoSize = true;
            this.rbEUR.Location = new System.Drawing.Point(270, 123);
            this.rbEUR.Name = "rbEUR";
            this.rbEUR.Size = new System.Drawing.Size(58, 21);
            this.rbEUR.TabIndex = 9;
            this.rbEUR.TabStop = true;
            this.rbEUR.Text = "EUR";
            this.rbEUR.UseVisualStyleBackColor = true;
            // 
            // rbUSD
            // 
            this.rbUSD.AutoSize = true;
            this.rbUSD.Location = new System.Drawing.Point(353, 123);
            this.rbUSD.Name = "rbUSD";
            this.rbUSD.Size = new System.Drawing.Size(58, 21);
            this.rbUSD.TabIndex = 10;
            this.rbUSD.TabStop = true;
            this.rbUSD.Text = "USD";
            this.rbUSD.UseVisualStyleBackColor = true;
            // 
            // cbxProdusNou
            // 
            this.cbxProdusNou.AutoSize = true;
            this.cbxProdusNou.Location = new System.Drawing.Point(189, 150);
            this.cbxProdusNou.Name = "cbxProdusNou";
            this.cbxProdusNou.Size = new System.Drawing.Size(103, 21);
            this.cbxProdusNou.TabIndex = 11;
            this.cbxProdusNou.Text = "Produs nou";
            this.cbxProdusNou.UseVisualStyleBackColor = true;
            // 
            // lvNou
            // 
            this.lvNou.HideSelection = false;
            this.lvNou.Location = new System.Drawing.Point(40, 237);
            this.lvNou.Name = "lvNou";
            this.lvNou.Size = new System.Drawing.Size(200, 229);
            this.lvNou.TabIndex = 12;
            this.lvNou.UseCompatibleStateImageBehavior = false;
            this.lvNou.View = System.Windows.Forms.View.SmallIcon;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lista produse noi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(276, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lista produse SH";
            // 
            // lvSH
            // 
            this.lvSH.HideSelection = false;
            this.lvSH.Location = new System.Drawing.Point(246, 237);
            this.lvSH.Name = "lvSH";
            this.lvSH.Size = new System.Drawing.Size(200, 229);
            this.lvSH.TabIndex = 15;
            this.lvSH.UseCompatibleStateImageBehavior = false;
            this.lvSH.View = System.Windows.Forms.View.SmallIcon;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(189, 177);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(121, 34);
            this.btnAdauga.TabIndex = 17;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 485);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lvSH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lvNou);
            this.Controls.Add(this.cbxProdusNou);
            this.Controls.Add(this.rbUSD);
            this.Controls.Add(this.rbEUR);
            this.Controls.Add(this.rbRON);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produse IT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbRON;
        private System.Windows.Forms.RadioButton rbEUR;
        private System.Windows.Forms.RadioButton rbUSD;
        private System.Windows.Forms.CheckBox cbxProdusNou;
        private System.Windows.Forms.ListView lvNou;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvSH;
        private System.Windows.Forms.Button btnAdauga;
    }
}

