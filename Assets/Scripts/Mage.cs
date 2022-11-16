using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Mage : Adventurer
{
    Boss boss;
    public static Mage createMage(Boss boss)
    {
        return new Mage(5f, 30f, 1000f, boss);
    }

    private Mage(float minDamage, float maxDamage, float health, Boss boss) : base(minDamage, maxDamage, health)
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