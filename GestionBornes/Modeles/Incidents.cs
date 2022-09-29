using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBornes.Modeles
{
    [Table("Incidents")]
    public class Incidents
    {
        #region Attributs
        private int _id;
        private string _description;
        private int _cout;
        private List<Techniciens> _lesTechniciens;

        #endregion

        #region Constructeurs

        public Incidents()
        {

        }



        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get => _id; set => _id = value; }
        public string Description { get => _description; set => _description = value; }
        public int Cout { get => _cout; set => _cout = value; }
        [ForeignKey(typeof(Bornes))]
        public int BorneId { get; set; }
        [ManyToMany(typeof(Intervenir))]
        public List<Techniciens> LesTechniciens { get => _lesTechniciens; set => _lesTechniciens = value; }
        #endregion

        #region Methodes

        public Incidents AjoutIncident(string description, int cout, Techniciens leTechnicien, Bornes laBorne)
        {
            this.Id = 0;
            this.Description = description;
            this.Cout = cout;
            this.LesTechniciens = new List<Techniciens>();
            this.AjoutTechnicien(leTechnicien);
            laBorne.AjoutIncident(this);

            return this;
        }
        public void AjoutTechnicien(Techniciens leTechnicien)
        {
            this.LesTechniciens.Add(leTechnicien);
        }
        #endregion
    }
}
