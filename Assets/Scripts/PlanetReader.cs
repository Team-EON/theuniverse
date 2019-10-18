using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetReader : MonoBehaviour
{
    public TextAsset csv;
    // Start is called before the first frame update
    void Start()
    {
        CSVReader.DebugOutputGrid(CSVReader.SplitCsvGrid(csv.text));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
