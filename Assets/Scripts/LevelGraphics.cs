using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelGraphics : MonoBehaviour
{
    GameObject canvasGO;
    private Rect backBtn;
    public GameObject entityManagerObj;
    EntityManager entityManager;

    ScreenText BossHealthTxt;
    ScreenText BossDamageTxt;
    ScreenText PriestTxtHP;
    ScreenText PriestTxtMP;
    ScreenText PriestTxtDMG;
    ScreenText DruidTxt;
    ScreenText DruidDMG;
    ScreenText MageTxt;
    ScreenText MageDMG;
    ScreenText RogueTxt;
    ScreenText RogueDMG;
    ScreenText WarriorTxt;
    ScreenText WarriorDMG;

    public void Start()
    {

        entityManager = entityManagerObj.GetComponent<EntityManager>();

        backBtn = new Rect(5, 5, 100, 50);
        canvasGO = new GameObject();
        ScreenText.makeCanvasGO(canvasGO);

        ScreenText Boss = new ScreenText("Boss", Screen.width / 2, Screen.height / 15, 0, 30, Color.black, canvasGO);
        BossHealthTxt = new ScreenText("HP: " + entityManager.boss.getHealth().ToString() + " / " + entityManager.boss.getInitialHealth().ToString(), Screen.width / 2, Screen.height / 15 + 35, 0, 30, Color.black, canvasGO);
        BossDamageTxt = new ScreenText("TD: " + entityManager.boss.getTotalDamage().ToString(), Screen.width / 2, Screen.height / 15 + 70, 0, 30, Color.black, canvasGO);


        ScreenText Priest = new ScreenText("Priest", Screen.width / 8, Screen.height / 2, 0, 30, Color.black, canvasGO);
        PriestTxtHP = new ScreenText("HP: " + entityManager.priest.getHealth().ToString() + " / " + entityManager.priest.getInitialHealth().ToString(), Screen.width / 8, Screen.height / 2 + 35, 0, 30, Color.black, canvasGO);
        PriestTxtMP = new ScreenText("MP: " + entityManager.priest.getMana().ToString() + " / " + entityManager.priest.getInitialMana().ToString(), Screen.width / 8, Screen.height / 2 + 70, 0, 30, Color.black, canvasGO);
        PriestTxtDMG = new ScreenText("TD: " + entityManager.priest.getTotalDamage().ToString(), Screen.width / 8, Screen.height / 2 + 105, 0, 30, Color.black, canvasGO);


        ScreenText Druid = new ScreenText("Druid", Screen.width / 8 + 150, Screen.height / 2 + 100, 0, 30, Color.black, canvasGO);
        DruidTxt = new ScreenText("HP: " + entityManager.druid.getHealth().ToString() + " / " + entityManager.druid.getInitialHealth().ToString(), Screen.width / 8 + 150, Screen.height / 2 + 135, 0, 30, Color.black, canvasGO);
        DruidDMG = new ScreenText("TD: " + entityManager.druid.getTotalDamage().ToString(), Screen.width / 8 + 150, Screen.height / 2 + 170, 0, 30, Color.black, canvasGO);

        ScreenText Mage = new ScreenText("Mage", Screen.width / 2, Screen.height / 2 + 100, 0, 30, Color.black, canvasGO);
        MageTxt = new ScreenText("HP: " + entityManager.mage.getHealth().ToString() + " / " + entityManager.mage.getInitialHealth().ToString(), Screen.width / 2, Screen.height / 2 + 135, 0, 30, Color.black, canvasGO);
        MageDMG = new ScreenText("TD: " + entityManager.mage.getTotalDamage().ToString(), Screen.width / 2, Screen.height / 2 + 170, 0, 30, Color.black, canvasGO);


        ScreenText Rogue = new ScreenText("Rogue", Screen.width - (Screen.width / 8 + 150), Screen.height / 2 + 100, 0, 30, Color.black, canvasGO);
        RogueTxt = new ScreenText("HP: " + entityManager.rogue.getHealth().ToString() + " / " + entityManager.rogue.getInitialHealth().ToString(), Screen.width - (Screen.width / 8 + 150), Screen.height / 2 + 135, 0, 30, Color.black, canvasGO);
        RogueDMG = new ScreenText("TD: " + entityManager.rogue.getTotalDamage().ToString(), Screen.width - (Screen.width / 8 + 150), Screen.height / 2 + 170, 0, 30, Color.black, canvasGO);


        ScreenText Warrior = new ScreenText("Warrior", Screen.width - (Screen.width / 8), Screen.height / 2, 0, 30, Color.black, canvasGO);
        WarriorTxt = new ScreenText("HP: " + entityManager.warrior.getHealth().ToString() + " / " + entityManager.warrior.getInitialHealth().ToString(), Screen.width - (Screen.width / 8), Screen.height / 2 + 35, 0, 30, Color.black, canvasGO);
        WarriorDMG = new ScreenText("TD: " + entityManager.warrior.getTotalDamage().ToString(), Screen.width - (Screen.width / 8), Screen.height / 2 + 70, 0, 30, Color.black, canvasGO);


    }

    public void Update()
    {
        BossHealthTxt.textComponent.text = "HP: " + entityManager.boss.getHealth().ToString() + " / " + entityManager.boss.getInitialHealth().ToString();
        BossDamageTxt.textComponent.text = "TD: " + entityManager.boss.getTotalDamage().ToString();
        PriestTxtHP.textComponent.text = "HP: " + entityManager.priest.getHealth().ToString() + " / " + entityManager.priest.getInitialHealth().ToString();
        PriestTxtMP.textComponent.text = "MP: " + entityManager.priest.getMana().ToString() + " / " + entityManager.priest.getInitialMana().ToString();
        PriestTxtDMG.textComponent.text = "TD: " + entityManager.priest.getTotalDamage().ToString();
        DruidTxt.textComponent.text = "HP: " + entityManager.druid.getHealth().ToString() + " / " + entityManager.druid.getInitialHealth().ToString();
        DruidDMG.textComponent.text = "TD: " + entityManager.druid.getTotalDamage().ToString();
        MageTxt.textComponent.text = "HP: " + entityManager.mage.getHealth().ToString() + " / " + entityManager.mage.getInitialHealth().ToString();
        MageDMG.textComponent.text = "TD: " + entityManager.mage.getTotalDamage().ToString();
        RogueTxt.textComponent.text = "HP: " + entityManager.rogue.getHealth().ToString() + " / " + entityManager.rogue.getInitialHealth().ToString();
        RogueDMG.textComponent.text = "TD: " + entityManager.rogue.getTotalDamage().ToString();
        WarriorTxt.textComponent.text = "HP: " + entityManager.warrior.getHealth().ToString() + " / " + entityManager.warrior.getInitialHealth().ToString();
        WarriorDMG.textComponent.text = "TD: " + entityManager.warrior.getTotalDamage().ToString();
    }

    private void OnGUI()
    {
        if (!entityManager.isSimulationRunning())
        {
            if (GUI.Button(backBtn, "Back"))
            {
                EntityManager.writer.close();
                SceneManager.LoadScene("Main Menu");
            }
        }
    }
}