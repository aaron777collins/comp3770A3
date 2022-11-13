using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public List<LevelData> levelDatas = new List<LevelData>();
    public int numLevels = 3;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numLevels; i++)
        {
            levelDatas.Add(new LevelData(i+1));
        }


    }

    // Update is called once per frame
    //void Update()
    //{

    //}
}