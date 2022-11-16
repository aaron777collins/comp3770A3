using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Rogue : Adventurer
{
    Boss boss;
    public static Rogue createRogue(Boss boss)
    {
        return new Rogue(15f, 25f, 1500f,boss);
    }

    private Rogue(float minDamage, float maxDamage, float health, Boss boss) : base(minDamage, maxDamage, health)
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