using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelData
{
    public int level = 1;
    public float maxDamageFromPlayersToBoss = 0;
    public float maxDamageFromBossToPlayers = 0;

    public LevelData(int level)
    {
        this.level = level;
    }
}