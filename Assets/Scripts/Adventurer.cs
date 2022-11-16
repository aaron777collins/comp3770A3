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
    private float initialHealth;
    private bool alive;
    private float totalDamage;
    
    public float getTotalDamage()
    {
        return totalDamage;
    }

    public void addDamageToTotal(float x)
    {
        totalDamage += x;
    }
    
    public Adventurer(float minDamage, float maxDamage, float health)
    {
        this.minDamage = minDamage;
        this.maxDamage = maxDamage;
        this.health = health;
        this.initialHealth = health;
        this.alive = true;
        this.totalDamage = 0;
    }

    public float getDamageCalc()
    {
        return Random.Range(minDamage, maxDamage);
    }

    public float getHealth()
    {
        return health;
    }

    public float getInitialHealth()
    {
        return initialHealth;
    }

    public virtual void removeHealth(float x) { 
        health -= x;
        if (health <= 0f)
        {
            health = 0f;
            die();
        }
    }

    public void heal(float x)
    {
        health += x;
        if (health > initialHealth)
        {
            health = initialHealth;
        }
    }

    public bool isAlive()
    {
        return alive;
    }

    public void die()
    {
        alive = false;
    }


    public abstract void useAbility();

}