using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelData
{
    public int level = 1;
    public int maxDamageFromPlayerToBoss = 0;
    public int maxDamageFromBossToPlayer = 0;

    public LevelData(int level)
    {
        this.level = level;
    }
}