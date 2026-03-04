//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Harjoitus20
//{
//    internal class Opiskelija
//    {
//    }
//}

using MySql.Data.MySqlClient;
using System.Data;

class OPISKELIJA
{
    Yhdista yhteys = new Yhdista();

    public bool lisaaOpiskelija(string enimi, string snimi, string puh, string email, int onro)
    {
        MySqlCommand komento = new MySqlCommand();
        string lisayskysely =
            "INSERT INTO yhteystiedot (etunimi, sukunimi, puhelin, sahkoposti, opiskelijanumero) " +
            "VALUES (@enm, @snm, @puh, @eml, @onro);";

        komento.CommandText = lisayskysely;
        komento.Connection = yhteys.otaYhteys();

        komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
        komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
        komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
        komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
        komento.Parameters.Add("@onro", MySqlDbType.UInt32).Value = onro;

        yhteys.avaaYhteys();
        bool ok = komento.ExecuteNonQuery() == 1;
        yhteys.suljeYhteys();
        return ok;
    }

   
    public DataTable haeOpiskelijat()
    {
        MySqlCommand komento = new MySqlCommand(
            "SELECT cid, etunimi, sukunimi, puhelin, sahkoposti, opiskelijanumero FROM yhteystiedot",
            yhteys.otaYhteys()
        );

        MySqlDataAdapter adapteri = new MySqlDataAdapter();
        DataTable taulu = new DataTable();

        adapteri.SelectCommand = komento;
        adapteri.Fill(taulu);

        return taulu;
    }
    public bool paivitaOpiskelija(int cid, string enimi, string snimi, string puh, string email, int onro)
    {
        MySqlCommand komento = new MySqlCommand();
        string paivitys =
            "UPDATE yhteystiedot SET etunimi=@enm, sukunimi=@snm, puhelin=@puh, " +
            "sahkoposti=@eml, opiskelijanumero=@onro WHERE cid=@cid";

        komento.CommandText = paivitys;
        komento.Connection = yhteys.otaYhteys();

        komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
        komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
        komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
        komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
        komento.Parameters.Add("@onro", MySqlDbType.UInt32).Value = onro;
        komento.Parameters.Add("@cid", MySqlDbType.UInt32).Value = cid;

        yhteys.avaaYhteys();
        bool ok = komento.ExecuteNonQuery() == 1;
        yhteys.suljeYhteys();
        return ok;
    }
    public bool poistaOpiskelija(string ktunnus)
    {
        MySqlCommand komento = new MySqlCommand();
        string poistokysely = "DELETE FROM yhteystiedot WHERE oid = @ktu";
        komento.CommandText = poistokysely;
        komento.Connection = yhteys.otaYhteys();
        //@ktu
        komento.Parameters.Add("@ktu", MySqlDbType.UInt32).Value=ktunnus;

        yhteys.avaaYhteys();
        bool ok = komento.ExecuteNonQuery() == 1;
        yhteys.suljeYhteys();
        return ok;
    }
}
