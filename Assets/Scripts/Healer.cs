using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Healer : Adventurer
{
    private float mana;
    private float initialMana;
    List<Adventurer> damageDealers;
    Warrior warrior;

    public static Healer createHealer(List<Adventurer> damageDealers, Warrior warrior)
    {
        return new Healer(0f, 0f, 900f, 1000f, damageDealers, warrior);
    }

    private Healer(float minDamage, float maxDamage, float health, float mana, List<Adventurer> damageDealers, Warrior warrior) : base(minDamage, maxDamage, health)
    {
        this.mana = mana;
        this.initialMana = mana;
        this.damageDealers = damageDealers;
        this.warrior = warrior;
    }

    public float getMana()
    {
        return this.mana;
    }

    public float getInitialMana()
    {
        return this.initialMana;
    }

    // should be called once per timestep
    public void regenMana()
    {
        mana += 3;
        if (mana > initialMana)
        {
            mana = initialMana;
        }
    }

    public void smallHeal()
    {

        float rand = Random.Range(1, 3);
        if (rand <=2)
        {
            // select itself to heal
            heal(15);
        } else
        {
            //heal a damage dealer
            int numDealers = damageDealers.Count();
            int dealerIndex = Random.Range(0, numDealers - 1);
            damageDealers.ElementAt(dealerIndex).heal(15);
        }

        // then decrease 5 mana
        mana -= 5;
    }

    public void bigHeal()
    {

        // Heal tank
        warrior.heal(25);

        // then decrease 10 mana
        mana -= 10;
    }

    public override void useAbility()
    {
        // use mana to heal, etc
        smallHeal();
        bigHeal();
        regenMana();

    }
}