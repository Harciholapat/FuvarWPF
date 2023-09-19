using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat
{
    internal class Fuvar
    {
        int azon;
        string indulasiIdo;
        int idotartam;
        double megtettTav;
        double viteldij;
        double borravalo;
        string fizetesiMod;

        public Fuvar(int azon, string indulasiIdo, int idotartam, double megtettTav, double viteldij, double borravalo, string fizetesiMod)
        {
            this.azon = azon;
            this.indulasiIdo = indulasiIdo;
            this.idotartam = idotartam;
            this.megtettTav = megtettTav;
            this.viteldij = viteldij;
            this.borravalo = borravalo;
            this.fizetesiMod = fizetesiMod;
        }

        public int Azon { get => azon; }
        public string IndulasiIdo { get => indulasiIdo; }
        public int Idotartam { get => idotartam; }
        public double MegtettTav { get => megtettTav; }
        public double Viteldij { get => viteldij; }
        public double Borravalo { get => borravalo; }
        public string FizetesiMod { get => fizetesiMod; }
    }
}
