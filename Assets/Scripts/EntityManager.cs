using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntityManager : MonoBehaviour
{

    private Data data;
    private LevelData levelData;


    public GameObject levelSpecificEntityManagerAddonObj;
    EntityManagerAddon levelSpecificEntityManagerAddon;

    List<Adventurer> adventurers = new List<Adventurer>();
    List<Adventurer> damageDealers = new List<Adventurer>();
    public Boss boss;
    public Warrior warrior;
    public Rogue rogue;
    public Mage mage;
    public Druid druid;
    public Healer priest;

    bool simulationRunning = true;

    public bool isSimulationRunning()
    {
        return simulationRunning;
    }

    // Start is called before the first frame update
    void Start()
    {

        data = GameObject.FindGameObjectWithTag("GameData").GetComponent<Data>();
        levelData = data.levelDatas.ElementAt(SceneManager.GetActiveScene().buildIndex - 3);

        levelSpecificEntityManagerAddon = levelSpecificEntityManagerAddonObj.GetComponent<EntityManagerAddon>();

        levelSpecificEntityManagerAddon.StartCust();

        simulationRunning = true;

        boss = Boss.createBoss();
        warrior = Warrior.createWarrior(boss);
        rogue = Rogue.createRogue(boss);
        mage = Mage.createMage(boss);
        druid = Druid.createDruid(boss);
        damageDealers.Add(rogue);
        damageDealers.Add(mage);
        damageDealers.Add(druid);

        priest = Healer.createHealer(damageDealers, warrior);

        boss.setBindings(damageDealers, priest, warrior);

        adventurers.Add(warrior);
        adventurers.Add(rogue);
        adventurers.Add(mage);
        adventurers.Add(druid);
        adventurers.Add(priest);

    }

    // Update is called once per frame
    void Update()
    {
        if (simulationRunning)
        {

            float bossHealth = boss.getHealth();

            levelSpecificEntityManagerAddon.UpdateCust();

            foreach(Adventurer adventurer in damageDealers)
            {
                adventurer.useAbility();
            }
            boss.useAbility();

            foreach (Adventurer adventurer in adventurers)
            {
                if (!adventurer.isAlive())
                {
                    simulationRunning = false;
                }
            }
            if (!boss.isAlive())
            {
                simulationRunning=false;
            }

            float newBossHealth = boss.getHealth();

            float diffBossHealth = bossHealth - newBossHealth;

            if (diffBossHealth > levelData.maxDamageFromPlayersToBoss)
            {
                levelData.maxDamageFromPlayersToBoss = diffBossHealth;
            }
        }
    }
}
