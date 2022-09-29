using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBornes.Modeles
{
    [Table("Bornes")]
    public class Bornes
    {
        #region Attributs

        private int _Id;
        private string _Description;

        private List<Incidents> _lesIncidents;
        private Villes _laVille;

        #endregion

        #region Constructeurs

        public Bornes()
        {
        }


        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get => _Id; set => _Id = value; }
        public string Description { get => _Description; set => _Description = value; }
        [OneToMany]
        public List<Incidents> LesIncidents { get => _lesIncidents; set => _lesIncidents = value; }

        [ForeignKey(typeof(Villes))]
        public int VilleId { get; set; }
        [ManyToOne(nameof(VilleId))]
        public Villes LaVille { get => _laVille; set => _laVille = value; }

        #endregion

        #region Methodes

        public Bornes AjoutBorne(string description,Villes laville)
        {
            this.Id = 0;
            this.Description = description;
            this.LaVille = laville; 
            this.LesIncidents = new List<Incidents>();

            return this;
        }

        public void AjoutIncident(Incidents leIncident)
        {
            this.LesIncidents.Add(leIncident);
        }

        #endregion
    }
}
