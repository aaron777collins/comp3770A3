using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class EntityManagerAddonL2 : EntityManagerAddon
{
    private int level = 2;
    EntityManager entityManager;

    public override void StartCust()
    {
        // no extra addon so this is filler
        entityManager = GameObject.FindGameObjectWithTag("EntityManager").GetComponent<EntityManager>();
    }

    public override void UpdateCust()
    {
        // no extra addon so this is filler
        if(entityManager.warrior.getHealth() <= 1500f)
        {
            float rand = Random.Range(0, 1);
            if (rand <= 0.5f)
            {
                // big heal no cost
                entityManager.priest.bigHealNoCost();
            } else
            {
                // small heal no cost
                entityManager.priest.smallHealNoCost();
            }
        }
    }
}