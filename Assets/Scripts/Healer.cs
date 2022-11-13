using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Healer : Adventurer
{
    private float mana;
    public float Mana { get => mana;}

    public static Healer createHealer()
    {
        return new Healer(0f, 0f, 900f, 1000f);
    }

    private Healer(float minDamage, float maxDamage, float health, float mana) : base(minDamage, maxDamage, health)
    {
        this.mana = mana;
    }

    public override void useAbility()
    {
        // use mana to heal, etc
        throw new System.NotImplementedException();
    }
}