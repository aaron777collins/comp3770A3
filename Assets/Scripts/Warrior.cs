using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Warrior : Adventurer
{
    Boss boss;
    public static Warrior createWarrior(Boss boss)
    {
        return new Warrior(5f, 10f, 3000f, boss);
    }

    private Warrior(float minDamage, float maxDamage, float health, Boss boss) : base(minDamage, maxDamage, health)
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