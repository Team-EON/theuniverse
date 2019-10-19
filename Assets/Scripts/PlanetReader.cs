using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlanetReader : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(GetText(RequestType.PLANET_NAME));
    }
    public enum RequestType {
        PLANET_NAME, PLANET_DETAILS
    };

    public PlanetReader(string filename)
    {
       //  CSVReader.DebugOutputGrid(CSVReader.SplitCsvGrid(csv.text));
    }

    IEnumerator GetText(RequestType type, string param1 = "Kepler")
    {
        string url = GetUrl(type);
        Debug.Log(url);
        UnityWebRequest www = UnityWebRequest.Get(url);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log(www.downloadHandler.text);
            
            byte[] results = www.downloadHandler.data;
        }
    }

    public string GetUrl(RequestType type)
    {
        switch (type)
        {
            case RequestType.PLANET_NAME:
                return "https://exoplanetarchive.ipac.caltech.edu/cgi-bin/nstedAPI/nph-nstedAPI?table=exoplanets&select=pl_name";
            case RequestType.PLANET_DETAILS:
                return "https://exoplanetarchive.ipac.caltech.edu/cgi-bin/nstedAPI/nph-nstedAPI?table=exoplanets&format=csv&select=pl_discmethod,pl_pnum,pl_orbper,pl_orbsmax,pl_orbeccen,pl_orbincl,pl_bmassj,pl_radj,st_dist,st_teff,rowupdate&where=plname like ";
            default:
                throw new System.Exception("Invalid requestType");
        }
    }
}
