using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicatie_Produse
{
    class ProdusIT
    {
        private string categorie;
        private string denumire;
        private float pret;
        private string moneda;
        private bool produs_nou;

        public ProdusIT(string categorie, string denumire, float pret, string moneda, bool produs_nou)
        {
            this.categorie = categorie;
            this.denumire = denumire;
            this.pret = pret;
            this.moneda = moneda;
            this.produs_nou = produs_nou;
        }

        public string Categorie { get => categorie; set => categorie = value; }
        public string Denumire { get => denumire; set => denumire = value; }
        public float Pret { get => pret; set => pret = value; }
        public string Moneda { get => moneda; set => moneda = value; }
        public bool Produs_nou { get => produs_nou; set => produs_nou = value; }

        public override string ToString()
        {
            return categorie + " " + denumire + " " + pret + " " + moneda + " ";
        }
    }
}
