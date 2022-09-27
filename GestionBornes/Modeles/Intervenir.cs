using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBornes.Modeles
{
    public class Intervenir
    {
        #region Attributs


        #endregion

        #region Constructeurs

        public Intervenir()
        {
        }

        #endregion

        #region Getters/Setters
        [ForeignKey(typeof(Incidents))]
        public int IncidentsId { get; set; }
        [ForeignKey(typeof(Techniciens))]
        public int TechniciensId { get; set; }
        #endregion

        #region Methodes

        #endregion
    }
}
