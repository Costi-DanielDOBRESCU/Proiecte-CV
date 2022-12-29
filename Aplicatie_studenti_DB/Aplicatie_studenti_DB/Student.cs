using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    private string nr_matricol;
    private string facultatea;
    private int an_studiu;
    private string nume;
    private string prenume;
    private int varsta;

    public Student(string nr_matricol, string facultatea, int an_studiu, string nume, string prenume, int varsta)
    {
        this.nr_matricol = nr_matricol;
        this.facultatea = facultatea;
        this.an_studiu = an_studiu;
        this.nume = nume;
        this.prenume = prenume;
        this.varsta = varsta;
    }

    public string Nr_matricol { get => nr_matricol; set => nr_matricol = value; }
    public string Facultatea { get => facultatea; set => facultatea = value; }
    public int An_studiu { get => an_studiu; set => an_studiu = value; }
    public string Nume { get => nume; set => nume = value; }
    public string Prenume { get => prenume; set => prenume = value; }
    public int Varsta { get => varsta; set => varsta = value; }

    public override string ToString()
    {
        return nr_matricol + " " + facultatea + " " + an_studiu + 
            " " + nume + " " + prenume + " " + varsta;
    }
}