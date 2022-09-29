using GestionBornes.Services;
using GestionBornes.Vues;

namespace GestionBornes;

public partial class App : Application
{
    static GestionDatabase database;
    public App()
    {
        InitializeComponent();

        MainPage = new BornesVue();
    }
    public static GestionDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new GestionDatabase();
            }
            return database;
        }
    }
}
