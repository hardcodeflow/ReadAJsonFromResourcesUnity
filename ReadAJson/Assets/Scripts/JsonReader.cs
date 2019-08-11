using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonReader : MonoBehaviour
{
    private List<LevelData> levels;

    // Start is called before the first frame update
    void Start()
    {
        levels = new List<LevelData>();
        TextAsset json = (TextAsset)Resources.Load("JsonData/levels_example");
        try
        {
            levels = JsonConvert.DeserializeObject<List<LevelData>>(json.ToString());
            foreach (LevelData level in levels) {
                Debug.Log("id:" + level.id + "name: " + level.name + " description: " + level.description);
            }
        }
        catch (Exception ex) {

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
