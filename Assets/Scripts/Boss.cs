using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : Adventurer
{
    private Data data;
    List<Adventurer> damageDealers;
    Healer healer;
    Warrior warrior;
    private LevelData levelData;
    public static Boss createBoss()
    {
        return new Boss(0f, 0f, 5000f);
    }

    private Boss(float minDamage, float maxDamage, float health) : base(minDamage, maxDamage, health)
    {
        data = GameObject.FindGameObjectWithTag("GameData").GetComponent<Data>();
        levelData = data.levelDatas.ElementAt(SceneManager.GetActiveScene().buildIndex-3);
    }

    public void setBindings(List<Adventurer> damageDealers, Healer healer, Warrior warrior)
    {
        this.damageDealers = damageDealers;
        this.healer = healer;
        this.warrior = warrior;
    }

    public override void useAbility()
    {
        int totalDamageToParty = 0;
        //5-20 damage to damage dealers and healers
        foreach(Adventurer damager in damageDealers)
        {
            int dmg2 = Random.Range(5, 20);
            totalDamageToParty += dmg2;
            damager.removeHealth(dmg2);
        }
        int dmg = Random.Range(5, 20);
        totalDamageToParty += dmg;
        healer.removeHealth(dmg);
        // 40-50 damage to tank
        dmg = Random.Range(40, 50);
        totalDamageToParty += dmg;
        warrior.removeHealth(dmg);

        if (totalDamageToParty > levelData.maxDamageFromBossToPlayers)
        {
            levelData.maxDamageFromBossToPlayers = (float)totalDamageToParty;
        }
    }
}