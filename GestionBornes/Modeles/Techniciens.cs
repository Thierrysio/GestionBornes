using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBornes.Modeles
{
    [Table("Techniciens")]
    public class Techniciens
    {
        #region Attributs
        private int _id;
        private string _nom;
        private List<Incidents> _lesIncidents;
        #endregion

        #region Constructeurs

        public Techniciens()
        {
        }



        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        [ManyToMany(typeof(Intervenir))]
        public List<Incidents> LesIncidents { get => _lesIncidents; set => _lesIncidents = value; }
        #endregion

        #region Methodes

        public Techniciens AjoutTechnicien(string nom)
        {
            this.Id = 0;
            this.Nom = nom;
            this.LesIncidents = new List<Incidents>();

            return this;
        }

        #endregion
    }
}
