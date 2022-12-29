using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aplicatie_studenti_DB
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Daniel\source\repos\Aplicatie_studenti_DB\Aplicatie_studenti_DB\baza_date.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable tabel_studenti = new DataTable();
        DataTable tabel_note = new DataTable();
        SqlDataAdapter sda_studenti,sda_note;
        int pozitie_student = 0;
        int pozitie_nota = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPanouStudenti_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        private void btnPanouNote_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage3);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumarMatricol.Text = "";
            txtFacultatea.Text = "";
            txtAnStudiu.Text = "";
            txtNume.Text = "";
            txtPrenume.Text = "";
            txtVarsta.Text = "";
            txtSearch.Text = "";

            btnFirst.Enabled = true;
            btnBack.Enabled = false;
            btnNext.Enabled = false;
            btnLast.Enabled = true;
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command;
                SqlDataAdapter sda = new SqlDataAdapter();
                String sql_insert = "INSERT INTO Studenti VALUES('" + txtNumarMatricol.Text + "','" + txtFacultatea.Text + "'," +
                    "'" + Int32.Parse(txtAnStudiu.Text) + "','" + txtNume.Text + "','" + txtPrenume.Text + "','" + Int32.Parse(txtVarsta.Text) + "')";
                command = new SqlCommand(sql_insert, con);
                sda.InsertCommand = new SqlCommand(sql_insert, con);
                sda.InsertCommand.ExecuteNonQuery();
                command.Dispose();

                MessageBox.Show("Student adaugat cu succes !");

                con.Close();

                ListaStudenti.Items.Clear();
                afisare_elemente_lista_studenti();
                
            }
            catch (System.Data.SqlClient.SqlException e1)
            {
                MessageBox.Show("Studentul a mai fost inregistrat !");
            }
            catch (System.FormatException e2)
            {
                MessageBox.Show("Date lipsa sau date introduse necorespunzator");
            }
            catch(System.InvalidOperationException e3)
            {
                MessageBox.Show("Date lipsa sau date introduse necorespunzator");
            }
            finally
            {
                pozitie_student++;
                tabel_studenti.Clear();
                sda_studenti = new SqlDataAdapter("SELECT *FROM Studenti", con);
                sda_studenti.Fill(tabel_studenti);
                con.Close();
            }
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa stergi studentul cu numarul matricol : " + txtNumarMatricol.Text, "Avertizare", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command;
                    SqlDataAdapter sda = new SqlDataAdapter();
                    if (string.IsNullOrEmpty(txtNumarMatricol.Text))
                        throw new InvalidOperationException();
                    String sql_delete = " DELETE FROM Studenti WHERE NrMatricol = '" + txtNumarMatricol.Text + "'";
                    command = new SqlCommand(sql_delete, con);
                    sda.InsertCommand = new SqlCommand(sql_delete, con);
                    sda.InsertCommand.ExecuteNonQuery();
                    command.Dispose();
                    MessageBox.Show("Student sters cu succes !");
                    con.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Studentul nu a fost sters !");
                }
                ListaStudenti.Items.Clear();
                afisare_elemente_lista_studenti();
            }
            catch (System.InvalidOperationException e1)
            {
                MessageBox.Show("Studentul nu exista!");
            }
            finally
            {
                tabel_studenti.Clear();
                sda_studenti = new SqlDataAdapter("SELECT *FROM Studenti", con);
                sda_studenti.Fill(tabel_studenti);
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command;
                SqlDataAdapter sda = new SqlDataAdapter();
                String sql_update = "UPDATE Studenti SET Facultatea = '"+ txtFacultatea.Text + "' , AnStudiu = '"+Int32.Parse(txtAnStudiu.Text)+"'" +
                    ", Nume = '"+txtNume.Text+"' , Prenume = '"+txtPrenume.Text+"' , Varsta = '"+Int32.Parse(txtVarsta.Text)+"' WHERE NrMatricol = '"+txtNumarMatricol.Text+"'";
                command = new SqlCommand(sql_update, con);
                sda.InsertCommand = new SqlCommand(sql_update, con);
                sda.InsertCommand.ExecuteNonQuery();
                command.Dispose();

                MessageBox.Show("Informatii actualizate cu succes !");

                con.Close();
                ListaStudenti.Items.Clear();
                afisare_elemente_lista_studenti();
            }
            catch (System.InvalidOperationException e1)
            {
                MessageBox.Show("Studentul cu numarul matricol " + txtNumarMatricol.Text + " nu exista!");
            }
            catch (System.FormatException e2)
            {
                MessageBox.Show("Date lipsa sau date introduse necorespunzator");
            }
            finally
            {
                tabel_studenti.Clear();
                sda_studenti = new SqlDataAdapter("SELECT *FROM Studenti", con);
                sda_studenti.Fill(tabel_studenti);
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnBack.Enabled = false;
            btnNext.Enabled = false;

            btnBackNota.Enabled = false;
            btnNextNota.Enabled = false;

            afisare_elemente_lista_studenti();
            sda_studenti = new SqlDataAdapter("SELECT *FROM Studenti", con);
            sda_studenti.Fill(tabel_studenti);

            sda_note = new SqlDataAdapter("SELECT *FROM Note ORDER BY NrMatricol", con);
            sda_note.Fill(tabel_note);
        }

        private void afisare_elemente_lista_studenti()
        {
            con.Open();
            SqlCommand command;
            SqlDataReader dr;
            String sql_select = "SELECT *FROM Studenti";
            command = new SqlCommand(sql_select, con);
            dr = command.ExecuteReader();
            
            while (dr.Read())
            {
                String[] rand = { dr.GetValue(0).ToString(), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString(), dr.GetValue(5).ToString() };
                ListViewItem item = new ListViewItem(rand);
                ListaStudenti.Items.Add(item);
            }
            dr.Close();
            con.Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            btnBack.Enabled = true;
            btnNext.Enabled = true;
            pozitie_student = 0;
            navigare_date_studenti(pozitie_student);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pozitie_student++;
            try
            {
                navigare_date_studenti(pozitie_student);
            }
            catch(System.IndexOutOfRangeException e1)
            {
                MessageBox.Show("Finalul informatiilor !");
                pozitie_student--;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pozitie_student--;
            try
            {
                navigare_date_studenti(pozitie_student);
            }
            catch (System.IndexOutOfRangeException e1)
            {
                MessageBox.Show("Nu exista informatii anterioare !");
                pozitie_student++;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            btnBack.Enabled = true;
            btnNext.Enabled = true;
            con.Open();
            SqlCommand comanda = new SqlCommand("SELECT COUNT(*) FROM Studenti", con);
            pozitie_student = (Int32)comanda.ExecuteScalar();
            con.Close();
            pozitie_student--;
            navigare_date_studenti(pozitie_student);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command;
            SqlDataReader dr;
            String sql_select_student = "SELECT *FROM Studenti WHERE NrMatricol = '"+txtSearch.Text+"'";
            command = new SqlCommand(sql_select_student, con);
            dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    txtNumarMatricol.Text = dr.GetValue(0).ToString();
                    txtFacultatea.Text = dr.GetValue(1).ToString();
                    txtAnStudiu.Text = dr.GetValue(2).ToString();
                    txtNume.Text = dr.GetValue(3).ToString();
                    txtPrenume.Text = dr.GetValue(4).ToString();
                    txtVarsta.Text = dr.GetValue(5).ToString();
                    btnFirst.Enabled = false;
                    btnBack.Enabled = false;
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                }
            }else MessageBox.Show("Studentul cu numarul matricol : " + txtSearch.Text + " nu exista!");
            dr.Close();
            con.Close();
        }

        public void navigare_date_studenti(int index)
        {
            txtNumarMatricol.Text = tabel_studenti.Rows[index][0].ToString();
            txtFacultatea.Text = tabel_studenti.Rows[index][1].ToString();
            txtAnStudiu.Text = tabel_studenti.Rows[index][2].ToString();
            txtNume.Text = tabel_studenti.Rows[index][3].ToString();
            txtPrenume.Text = tabel_studenti.Rows[index][4].ToString();
            txtVarsta.Text = tabel_studenti.Rows[index][5].ToString();
        }

        private void ListaStudenti_MouseClick(object sender, MouseEventArgs e)
        {
            ListaNote.Items.Clear();
            String NM = ListaStudenti.SelectedItems[0].SubItems[0].Text;
            //Console.WriteLine(NM);
            con.Open();
            SqlCommand command;
            SqlDataReader dr;
            String sql_select = "SELECT *FROM Note WHERE NrMatricol = '"+NM+"' ORDER BY NotaPrezentare1 DESC";
            command = new SqlCommand(sql_select, con);
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                String[] rand = { dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString(), dr.GetValue(5).ToString() };
                ListViewItem item = new ListViewItem(rand);
                ListaNote.Items.Add(item);
            }
            dr.Close();
            con.Close(); 
        }

        private void btnFirstNota_Click(object sender, EventArgs e)
        {
            btnBackNota.Enabled = true;
            btnNextNota.Enabled = true;
            pozitie_nota = 0;
            navigare_date_note(pozitie_nota);
        }

        private void btnLastNota_Click(object sender, EventArgs e)
        {
            btnBackNota.Enabled = true;
            btnNextNota.Enabled = true;
            con.Open();
            SqlCommand comanda = new SqlCommand("SELECT COUNT(*) FROM Note", con);
            pozitie_nota = (Int32)comanda.ExecuteScalar();
            con.Close();
            pozitie_nota--;
            navigare_date_note(pozitie_nota);
        }

        private void btnBackNota_Click(object sender, EventArgs e)
        {
            pozitie_nota--;
            try
            {
                navigare_date_note(pozitie_nota);
            }
            catch (System.IndexOutOfRangeException e1)
            {
                MessageBox.Show("Nu exista informatii anterioare !");
                pozitie_nota++;
            }
        }

        private void btnNextNota_Click(object sender, EventArgs e)
        {
            pozitie_nota++;
            try
            {
                navigare_date_note(pozitie_nota);
            }
            catch (System.IndexOutOfRangeException e1)
            {
                MessageBox.Show("Finalul informatiilor !");
                pozitie_nota--;
            }
        }

        private void btnAddNota_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command;
                SqlDataAdapter sda = new SqlDataAdapter();
                String sql_insert = "INSERT INTO Note VALUES('" + txtNMatricol.Text + "','" + txtMateria.Text + "'," +
                    "'" + Int32.Parse(txtP1.Text) + "','" + Int32.Parse(txtP2.Text) + "','" + Int32.Parse(txtP3.Text) + "','" + Int32.Parse(txtAP.Text) + "')";
                command = new SqlCommand(sql_insert, con);
                sda.InsertCommand = new SqlCommand(sql_insert, con);
                sda.InsertCommand.ExecuteNonQuery();
                command.Dispose();

                MessageBox.Show("Note adaugate cu succes !");

                con.Close();
            }
            catch (System.Data.SqlClient.SqlException e1)
            {
                MessageBox.Show("Notele la aceasta materie au mai fost inregistrate inainte !");
            }
            catch (System.FormatException e2)
            {
                MessageBox.Show("Date lipsa sau date introduse necorespunzator");
            }
            catch (System.InvalidOperationException e3)
            {
                MessageBox.Show("Date lipsa sau date introduse necorespunzator");
            }
            finally
            {
                pozitie_nota++;
                tabel_note.Clear();
                sda_studenti = new SqlDataAdapter("SELECT *FROM Note ORDER BY NrMatricol", con);
                sda_note.Fill(tabel_note);
                con.Close();
            }
        }

        private void btnDelNota_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa stergi notele corespunzatoare materiei : " + txtMateria.Text, "Avertizare", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command;
                    SqlDataAdapter sda = new SqlDataAdapter();
                    if (string.IsNullOrEmpty(txtNMatricol.Text) && string.IsNullOrEmpty(txtMateria.Text))
                        throw new InvalidOperationException();
                    String sql_delete = " DELETE FROM Note WHERE NrMatricol = '" + txtNMatricol.Text + "' AND Materia = '"+txtMateria.Text+"'";
                    command = new SqlCommand(sql_delete, con);
                    sda.InsertCommand = new SqlCommand(sql_delete, con);
                    sda.InsertCommand.ExecuteNonQuery();
                    command.Dispose();
                    MessageBox.Show("Note sterse cu succes !");
                    con.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Notele nu au fost sterse !");
                } 
            }
            catch (System.InvalidOperationException e1)
            {
                MessageBox.Show("Studentul sau materia nu exista!");
            }
            finally
            {
                tabel_note.Clear();
                sda_note = new SqlDataAdapter("SELECT *FROM Note ORDER BY NrMatricol", con);
                sda_note.Fill(tabel_note);
                con.Close();
            }
        }

        private void btnClearNota_Click(object sender, EventArgs e)
        {
            txtNMatricol.Text = "";
            txtMateria.Text = "";
            txtP1.Text = "";
            txtP2.Text = "";
            txtP3.Text = "";
            txtAP.Text = "";
            btnFirstNota.Enabled = true;
            btnBackNota.Enabled = false;
            btnNextNota.Enabled = false;
            btnLastNota.Enabled = true;
        }

        private void btnUpNota_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command;
                SqlDataAdapter sda = new SqlDataAdapter();
                String sql_update = "UPDATE Note SET NotaPrezentare1 = '" + Int32.Parse(txtP1.Text) + "'" +
                    ", NotaPrezentare2 = '" + Int32.Parse(txtP2.Text) + "' , NotaPrezentare3 = '" + Int32.Parse(txtP3.Text) + "' , NotaActivitateParcurs = '" + Int32.Parse(txtAP.Text) + "' WHERE NrMatricol = '" + txtNMatricol.Text + "' AND Materia = '"+txtMateria.Text+"'";
                command = new SqlCommand(sql_update, con);
                sda.InsertCommand = new SqlCommand(sql_update, con);
                sda.InsertCommand.ExecuteNonQuery();
                command.Dispose();

                MessageBox.Show("Informatii actualizate cu succes !");

                con.Close();
            }
            catch (System.InvalidOperationException e1)
            {
                MessageBox.Show("Studentul nu exista");
            }
            catch(System.FormatException e2)
            {
                MessageBox.Show("Date lipsa sau date introduse necorespunzator");
            }
            finally
            {
                tabel_note.Clear();
                sda_note = new SqlDataAdapter("SELECT *FROM Note ORDER BY NrMatricol", con);
                sda_note.Fill(tabel_note);
                con.Close();
            }
        }

        public void navigare_date_note(int index)
        {
            txtNMatricol.Text = tabel_note.Rows[index][0].ToString();
            txtMateria.Text = tabel_note.Rows[index][1].ToString();
            txtP1.Text = tabel_note.Rows[index][2].ToString();
            txtP2.Text = tabel_note.Rows[index][3].ToString();
            txtP3.Text = tabel_note.Rows[index][4].ToString();
            txtAP.Text = tabel_note.Rows[index][5].ToString();
        }
    }
}
