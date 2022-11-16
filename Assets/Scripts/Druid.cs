using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Druid : Adventurer
{

    Boss boss;

    public static Druid createDruid(Boss boss)
    {
        return new Druid(5f, 15f, 1250f, boss);
    }

    private Druid(float minDamage, float maxDamage, float health, Boss boss) : base(minDamage, maxDamage, health)
    {
        this.boss = boss;
    }

    public override void useAbility()
    {
        float damage = this.getDamageCalc();
        this.addDamageToTotal(damage);
        boss.removeHealth(damage);
    }
}