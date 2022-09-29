using GestionBornes.Modeles;
using GestionBornes.VueModeles;
using System.Collections.ObjectModel;

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
       

        // Creation des objets
        Villes ville01 = new Villes().AjoutVille("Lannion");
        Villes ville02 = new Villes().AjoutVille("Rennes");
        Villes ville03 = new Villes().AjoutVille("Lorient");
        //Mapping - insert into
        await App.Database.SaveItemAsync<Villes>(ville01);
        await App.Database.SaveItemAsync<Villes>(ville02);
        await App.Database.SaveItemAsync<Villes>(ville03);

        //creation des objets
        Techniciens technicien01 = new Techniciens().AjoutTechnicien("technicien 01");
        Techniciens technicien02 = new Techniciens().AjoutTechnicien("technicien 02");
        //mapping - insert into
        await App.Database.SaveItemAsync<Techniciens>(technicien01);
        await App.Database.SaveItemAsync<Techniciens>(technicien02);

        //creation des objets
        Bornes borne01 = new Bornes().AjoutBorne("borne 01",ville01);
        Bornes borne02 = new Bornes().AjoutBorne("borne 02",ville02);
        Bornes borne03 = new Bornes().AjoutBorne("borne 03",ville03);
		Bornes borne04 = new Bornes().AjoutBorne("borne 04",ville01);
        //mapping - insert into
        await App.Database.SaveItemAsync<Bornes>(borne01);      
        await App.Database.SaveItemAsync<Bornes>(borne02);
        await App.Database.SaveItemAsync<Bornes>(borne03);
        await App.Database.SaveItemAsync<Bornes>(borne04);

        //creation des objets
        Incidents incident01 = new Incidents().AjoutIncident("incident 01", 10,technicien02,borne04);
        Incidents incident02 = new Incidents().AjoutIncident("incident 02", 10, technicien01,borne02);
        //mapping - insert into
        await App.Database.SaveItemAsync<Incidents>(incident01);
        await App.Database.SaveItemAsync<Incidents>(incident02);

        //Creation des relation
        await App.Database.MiseAJourItemRelation(borne01);
        await App.Database.MiseAJourItemRelation(borne02); 
        await App.Database.MiseAJourItemRelation(borne03);
        await App.Database.MiseAJourItemRelation(borne04);

        await App.Database.MiseAJourItemRelation(incident01);
        await App.Database.MiseAJourItemRelation(incident02);

        await App.Database.MiseAJourItemRelation(technicien01);
        await App.Database.MiseAJourItemRelation(technicien02);


        ObservableCollection<Bornes> MaListeBornes = App.Database.GetItemsAsync<Bornes>();
        ObservableCollection<Techniciens> MaListeTechnicienq = App.Database.GetItemsAsync<Techniciens>();

        var mDB = App.Database.GetItemAvecRelations(technicien02);
        var resultat = mDB.Result;
    }
}