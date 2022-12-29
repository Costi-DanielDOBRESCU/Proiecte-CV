
namespace Aplicatie_studenti_DB
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ListaNote = new System.Windows.Forms.ListView();
            this.Materia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NotaP1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NotaP2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NotaP3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NotaAP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListaStudenti = new System.Windows.Forms.ListView();
            this.NrMatricol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Facultatea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AnStudiu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Varsta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPanouNote = new System.Windows.Forms.Button();
            this.btnPanouStudenti = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtAnStudiu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.txtFacultatea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVarsta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumarMatricol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtNMatricol = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClearNota = new System.Windows.Forms.Button();
            this.btnUpNota = new System.Windows.Forms.Button();
            this.btnDelNota = new System.Windows.Forms.Button();
            this.btnAddNota = new System.Windows.Forms.Button();
            this.btnLastNota = new System.Windows.Forms.Button();
            this.btnNextNota = new System.Windows.Forms.Button();
            this.btnBackNota = new System.Windows.Forms.Button();
            this.btnFirstNota = new System.Windows.Forms.Button();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtP3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-4, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1058, 493);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ListaNote);
            this.tabPage1.Controls.Add(this.ListaStudenti);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnPanouNote);
            this.tabPage1.Controls.Add(this.btnPanouStudenti);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1050, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Note Studenti";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ListaNote
            // 
            this.ListaNote.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Materia,
            this.NotaP1,
            this.NotaP2,
            this.NotaP3,
            this.NotaAP});
            this.ListaNote.HideSelection = false;
            this.ListaNote.Location = new System.Drawing.Point(607, 46);
            this.ListaNote.Name = "ListaNote";
            this.ListaNote.Size = new System.Drawing.Size(429, 342);
            this.ListaNote.TabIndex = 8;
            this.ListaNote.UseCompatibleStateImageBehavior = false;
            this.ListaNote.View = System.Windows.Forms.View.Details;
            // 
            // Materia
            // 
            this.Materia.Text = "Materia";
            this.Materia.Width = 80;
            // 
            // NotaP1
            // 
            this.NotaP1.Text = "NotaP1";
            // 
            // NotaP2
            // 
            this.NotaP2.Text = "NotaP2";
            // 
            // NotaP3
            // 
            this.NotaP3.Text = "NotaP3";
            // 
            // NotaAP
            // 
            this.NotaAP.Text = "NotaAP";
            // 
            // ListaStudenti
            // 
            this.ListaStudenti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListaStudenti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NrMatricol,
            this.Facultatea,
            this.AnStudiu,
            this.Nume,
            this.Prenume,
            this.Varsta});
            this.ListaStudenti.FullRowSelect = true;
            this.ListaStudenti.HideSelection = false;
            this.ListaStudenti.Location = new System.Drawing.Point(15, 46);
            this.ListaStudenti.Name = "ListaStudenti";
            this.ListaStudenti.Size = new System.Drawing.Size(586, 342);
            this.ListaStudenti.TabIndex = 7;
            this.ListaStudenti.UseCompatibleStateImageBehavior = false;
            this.ListaStudenti.View = System.Windows.Forms.View.Details;
            this.ListaStudenti.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListaStudenti_MouseClick);
            // 
            // NrMatricol
            // 
            this.NrMatricol.Text = "NrMatricol";
            this.NrMatricol.Width = 80;
            // 
            // Facultatea
            // 
            this.Facultatea.Text = "Facultatea";
            this.Facultatea.Width = 80;
            // 
            // AnStudiu
            // 
            this.AnStudiu.Text = "AnStudiu";
            this.AnStudiu.Width = 70;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 70;
            // 
            // Prenume
            // 
            this.Prenume.Text = "Prenume";
            this.Prenume.Width = 75;
            // 
            // Varsta
            // 
            this.Varsta.Text = "Varsta";
            this.Varsta.Width = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(613, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista notelor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista studentilor";
            // 
            // btnPanouNote
            // 
            this.btnPanouNote.Location = new System.Drawing.Point(734, 397);
            this.btnPanouNote.Name = "btnPanouNote";
            this.btnPanouNote.Size = new System.Drawing.Size(175, 44);
            this.btnPanouNote.TabIndex = 3;
            this.btnPanouNote.Text = "Adauga Nota";
            this.btnPanouNote.UseVisualStyleBackColor = true;
            this.btnPanouNote.Click += new System.EventHandler(this.btnPanouNote_Click);
            // 
            // btnPanouStudenti
            // 
            this.btnPanouStudenti.Location = new System.Drawing.Point(221, 397);
            this.btnPanouStudenti.Name = "btnPanouStudenti";
            this.btnPanouStudenti.Size = new System.Drawing.Size(175, 44);
            this.btnPanouStudenti.TabIndex = 2;
            this.btnPanouStudenti.Text = "Adauga Student";
            this.btnPanouStudenti.UseVisualStyleBackColor = true;
            this.btnPanouStudenti.Click += new System.EventHandler(this.btnPanouStudenti_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtAnStudiu);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(this.btnStergere);
            this.tabPage2.Controls.Add(this.btnAdaugare);
            this.tabPage2.Controls.Add(this.btnLast);
            this.tabPage2.Controls.Add(this.btnNext);
            this.tabPage2.Controls.Add(this.btnBack);
            this.tabPage2.Controls.Add(this.btnFirst);
            this.tabPage2.Controls.Add(this.txtFacultatea);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtVarsta);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtPrenume);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtNume);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtNumarMatricol);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1050, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Adaugare Student";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtAnStudiu
            // 
            this.txtAnStudiu.Location = new System.Drawing.Point(530, 94);
            this.txtAnStudiu.Name = "txtAnStudiu";
            this.txtAnStudiu.Size = new System.Drawing.Size(164, 27);
            this.txtAnStudiu.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(409, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "An studiu";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(485, 401);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(250, 31);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Cautare dupa nr matricol";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(315, 403);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(164, 27);
            this.txtSearch.TabIndex = 23;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(650, 243);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 40);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(529, 243);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 40);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(408, 243);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(113, 40);
            this.btnStergere.TabIndex = 20;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(287, 243);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(113, 40);
            this.btnAdaugare.TabIndex = 19;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(628, 316);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(74, 54);
            this.btnLast.TabIndex = 18;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(535, 316);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(74, 54);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(442, 316);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 54);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(349, 316);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(74, 54);
            this.btnFirst.TabIndex = 15;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // txtFacultatea
            // 
            this.txtFacultatea.Location = new System.Drawing.Point(530, 61);
            this.txtFacultatea.Name = "txtFacultatea";
            this.txtFacultatea.Size = new System.Drawing.Size(164, 27);
            this.txtFacultatea.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(401, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Facultatea";
            // 
            // txtVarsta
            // 
            this.txtVarsta.Location = new System.Drawing.Point(530, 193);
            this.txtVarsta.Name = "txtVarsta";
            this.txtVarsta.Size = new System.Drawing.Size(164, 27);
            this.txtVarsta.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Varsta";
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(530, 160);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(164, 27);
            this.txtPrenume.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(412, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Prenume";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(530, 127);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(164, 27);
            this.txtNume.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nume";
            // 
            // txtNumarMatricol
            // 
            this.txtNumarMatricol.Location = new System.Drawing.Point(530, 28);
            this.txtNumarMatricol.Name = "txtNumarMatricol";
            this.txtNumarMatricol.Size = new System.Drawing.Size(164, 27);
            this.txtNumarMatricol.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numar matricol";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtNMatricol);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtP2);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.btnClearNota);
            this.tabPage3.Controls.Add(this.btnUpNota);
            this.tabPage3.Controls.Add(this.btnDelNota);
            this.tabPage3.Controls.Add(this.btnAddNota);
            this.tabPage3.Controls.Add(this.btnLastNota);
            this.tabPage3.Controls.Add(this.btnNextNota);
            this.tabPage3.Controls.Add(this.btnBackNota);
            this.tabPage3.Controls.Add(this.btnFirstNota);
            this.tabPage3.Controls.Add(this.txtP1);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtAP);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtP3);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.txtMateria);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1050, 460);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Adaugare Note";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtNMatricol
            // 
            this.txtNMatricol.Location = new System.Drawing.Point(584, 58);
            this.txtNMatricol.Name = "txtNMatricol";
            this.txtNMatricol.Size = new System.Drawing.Size(164, 27);
            this.txtNMatricol.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(410, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 24);
            this.label11.TabIndex = 49;
            this.label11.Text = "Numar matricol";
            // 
            // txtP2
            // 
            this.txtP2.Location = new System.Drawing.Point(584, 157);
            this.txtP2.Name = "txtP2";
            this.txtP2.Size = new System.Drawing.Size(164, 27);
            this.txtP2.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(374, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 24);
            this.label9.TabIndex = 47;
            this.label9.Text = "Nota Prezentarea 2";
            // 
            // btnClearNota
            // 
            this.btnClearNota.Location = new System.Drawing.Point(650, 275);
            this.btnClearNota.Name = "btnClearNota";
            this.btnClearNota.Size = new System.Drawing.Size(113, 40);
            this.btnClearNota.TabIndex = 44;
            this.btnClearNota.Text = "Clear";
            this.btnClearNota.UseVisualStyleBackColor = true;
            this.btnClearNota.Click += new System.EventHandler(this.btnClearNota_Click);
            // 
            // btnUpNota
            // 
            this.btnUpNota.Location = new System.Drawing.Point(529, 275);
            this.btnUpNota.Name = "btnUpNota";
            this.btnUpNota.Size = new System.Drawing.Size(113, 40);
            this.btnUpNota.TabIndex = 43;
            this.btnUpNota.Text = "Update";
            this.btnUpNota.UseVisualStyleBackColor = true;
            this.btnUpNota.Click += new System.EventHandler(this.btnUpNota_Click);
            // 
            // btnDelNota
            // 
            this.btnDelNota.Location = new System.Drawing.Point(408, 275);
            this.btnDelNota.Name = "btnDelNota";
            this.btnDelNota.Size = new System.Drawing.Size(113, 40);
            this.btnDelNota.TabIndex = 42;
            this.btnDelNota.Text = "Stergere";
            this.btnDelNota.UseVisualStyleBackColor = true;
            this.btnDelNota.Click += new System.EventHandler(this.btnDelNota_Click);
            // 
            // btnAddNota
            // 
            this.btnAddNota.Location = new System.Drawing.Point(287, 275);
            this.btnAddNota.Name = "btnAddNota";
            this.btnAddNota.Size = new System.Drawing.Size(113, 40);
            this.btnAddNota.TabIndex = 41;
            this.btnAddNota.Text = "Adaugare";
            this.btnAddNota.UseVisualStyleBackColor = true;
            this.btnAddNota.Click += new System.EventHandler(this.btnAddNota_Click);
            // 
            // btnLastNota
            // 
            this.btnLastNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastNota.Location = new System.Drawing.Point(628, 348);
            this.btnLastNota.Name = "btnLastNota";
            this.btnLastNota.Size = new System.Drawing.Size(74, 54);
            this.btnLastNota.TabIndex = 40;
            this.btnLastNota.Text = ">>";
            this.btnLastNota.UseVisualStyleBackColor = true;
            this.btnLastNota.Click += new System.EventHandler(this.btnLastNota_Click);
            // 
            // btnNextNota
            // 
            this.btnNextNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextNota.Location = new System.Drawing.Point(535, 348);
            this.btnNextNota.Name = "btnNextNota";
            this.btnNextNota.Size = new System.Drawing.Size(74, 54);
            this.btnNextNota.TabIndex = 39;
            this.btnNextNota.Text = ">";
            this.btnNextNota.UseVisualStyleBackColor = true;
            this.btnNextNota.Click += new System.EventHandler(this.btnNextNota_Click);
            // 
            // btnBackNota
            // 
            this.btnBackNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackNota.Location = new System.Drawing.Point(442, 348);
            this.btnBackNota.Name = "btnBackNota";
            this.btnBackNota.Size = new System.Drawing.Size(74, 54);
            this.btnBackNota.TabIndex = 38;
            this.btnBackNota.Text = "<";
            this.btnBackNota.UseVisualStyleBackColor = true;
            this.btnBackNota.Click += new System.EventHandler(this.btnBackNota_Click);
            // 
            // btnFirstNota
            // 
            this.btnFirstNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstNota.Location = new System.Drawing.Point(349, 348);
            this.btnFirstNota.Name = "btnFirstNota";
            this.btnFirstNota.Size = new System.Drawing.Size(74, 54);
            this.btnFirstNota.TabIndex = 37;
            this.btnFirstNota.Text = "<<";
            this.btnFirstNota.UseVisualStyleBackColor = true;
            this.btnFirstNota.Click += new System.EventHandler(this.btnFirstNota_Click);
            // 
            // txtP1
            // 
            this.txtP1.Location = new System.Drawing.Point(584, 124);
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(164, 27);
            this.txtP1.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(374, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 24);
            this.label10.TabIndex = 35;
            this.label10.Text = "Nota Prezentarea 1";
            // 
            // txtAP
            // 
            this.txtAP.Location = new System.Drawing.Point(584, 223);
            this.txtAP.Name = "txtAP";
            this.txtAP.Size = new System.Drawing.Size(164, 27);
            this.txtAP.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(302, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(260, 24);
            this.label12.TabIndex = 31;
            this.label12.Text = "Nota Activitatea pe Parcurs";
            // 
            // txtP3
            // 
            this.txtP3.Location = new System.Drawing.Point(584, 190);
            this.txtP3.Name = "txtP3";
            this.txtP3.Size = new System.Drawing.Size(164, 27);
            this.txtP3.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(374, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 24);
            this.label13.TabIndex = 29;
            this.label13.Text = "Nota Prezentarea 3";
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(584, 91);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(164, 27);
            this.txtMateria.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(382, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(180, 24);
            this.label14.TabIndex = 27;
            this.label14.Text = "Disciplina Studiata";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 489);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicatie Note Studenti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnPanouNote;
        private System.Windows.Forms.Button btnPanouStudenti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtVarsta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumarMatricol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFacultatea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.TextBox txtAnStudiu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView ListaNote;
        private System.Windows.Forms.ListView ListaStudenti;
        private System.Windows.Forms.ColumnHeader NrMatricol;
        private System.Windows.Forms.ColumnHeader Facultatea;
        private System.Windows.Forms.ColumnHeader AnStudiu;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Prenume;
        private System.Windows.Forms.ColumnHeader Varsta;
        private System.Windows.Forms.ColumnHeader Materia;
        private System.Windows.Forms.ColumnHeader NotaP1;
        private System.Windows.Forms.ColumnHeader NotaP2;
        private System.Windows.Forms.ColumnHeader NotaP3;
        private System.Windows.Forms.ColumnHeader NotaAP;
        private System.Windows.Forms.TextBox txtP2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClearNota;
        private System.Windows.Forms.Button btnUpNota;
        private System.Windows.Forms.Button btnDelNota;
        private System.Windows.Forms.Button btnAddNota;
        private System.Windows.Forms.Button btnLastNota;
        private System.Windows.Forms.Button btnNextNota;
        private System.Windows.Forms.Button btnBackNota;
        private System.Windows.Forms.Button btnFirstNota;
        private System.Windows.Forms.TextBox txtP1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtP3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNMatricol;
        private System.Windows.Forms.Label label11;
    }
}

