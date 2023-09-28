using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

public static class Modele
{
    private static SIO2MusicAtout_BoulaamailEntities maConnexion;
    private static int Action;//1 ajour/2modif
    private static COMPOSITEUR compochoisi;

    public static int Action1 { get => Action; set => Action = value; }
    public static COMPOSITEUR Compochoisi { get => compochoisi; set => compochoisi = value; }
    public static COMPOSITEUR Trvcompo(int id)
    {
        COMPOSITEUR rtn;
        rtn = maConnexion.COMPOSITEUR.Where(x => x.idCompositeur == id).ToList()[0];
        return rtn;
    }

    public static void init()
    {
        /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
        maConnexion = new SIO2MusicAtout_BoulaamailEntities();
        
    }
    public static List<VILLE> listeville()
    {
        return maConnexion.VILLE.ToList();
    }
    public static List<SALLE> listsalle()
    {
        return maConnexion.SALLE.ToList();
    }
    public static List<BATIMENT> listbatment()
    {
        return maConnexion.BATIMENT.ToList();
    }
    public static List<TYPEOEUVRE> listtypeoeuvre()
    {
        return maConnexion.TYPEOEUVRE.ToList();
    }
    public static List<NATIONALITE> listnationalite()
    {
        return maConnexion.NATIONALITE.ToList();
    }
    public static List<STYLE>liststyle()
    {
        return maConnexion.STYLE.ToList();
    }
    public static List<COMPOSITEUR> listcompositeur()
    {
        return maConnexion.COMPOSITEUR.ToList();
    }
}

