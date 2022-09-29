using GestionBornes.Modeles;
using GestionBornes.VueModeles;

namespace GestionBornes.Vues;

public partial class BornesVue : ContentPage
{
	BornesVueModele vueModele;
    public BornesVue()
	{
		InitializeComponent();
		BindingContext = vueModele = new BornesVueModele();

		this.Test();
	}

	public async void Test()
	{
		Villes ville01 = new Villes().AjoutVille("Lannion");
        Villes ville02 = new Villes().AjoutVille("Rennes");
        Villes ville03 = new Villes().AjoutVille("Lorient");

		Techniciens technicien01 = new Techniciens().AjoutTechnicien("technicien 01");
        Techniciens technicien02 = new Techniciens().AjoutTechnicien("technicien 02");

		Bornes borne01 = new Bornes().AjoutBorne("borne 01");
        Bornes borne02 = new Bornes().AjoutBorne("borne 02");
        Bornes borne03 = new Bornes().AjoutBorne("borne 03");
		Bornes borne04 = new Bornes().AjoutBorne("borne 04");

		Incidents incident01 = new Incidents().AjoutIncident("incident 01", 10);
        Incidents incident02 = new Incidents().AjoutIncident("incident 02", 10);

		borne01.LaVille = ville01;
		borne02.LaVille = ville02;
		borne03.LaVille = ville03;
		borne04.LaVille	= ville01

		incident01.LesTechniciens.Add(technicien02);
		borne04.LesIncidents.Add(incident01);
    }
}