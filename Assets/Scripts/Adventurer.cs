using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public abstract class Adventurer 
{
    private float minDamage;
    private float maxDamage;
    private float health;
    
    public float getDamageCalc()
    {
        return Random.Range(minDamage, maxDamage);
    }

    public float getHealth()
    {
        return health;
    }

    public void removeHealth(float x) { 
        health -= x;
        if (health <= 0f)
        {
            health = 0f;
            die();
        }
    }

    public void die()
    {
        // TODO: Implement
    }


    public abstract void useAbility();

    public Adventurer(float minDamage, float maxDamage, float health)
    {
        this.minDamage = minDamage;
        this.maxDamage = maxDamage;
        this.health = health;
    }
}