using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class EntityManagerAddonL3 : EntityManagerAddon
{
    private int level = 3;

    EntityManager entityManager;

    public override void StartCust()
    {
        entityManager = GameObject.FindGameObjectWithTag("EntityManager").GetComponent<EntityManager>();
    }

    public override void UpdateCust()
    {
        entityManager.warrior.removeHealth(Mathf.RoundToInt(entityManager.totalDamageDoneToBoss / 100f));
    }
}