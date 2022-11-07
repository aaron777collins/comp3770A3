using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using static System.Net.Mime.MediaTypeNames;

public class ScoreGraphics : MonoBehaviour
{
    private Data data;
    private Rect backBtn;
    private GameObject canvasGO;
    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.FindGameObjectWithTag("GameData").GetComponent<Data>();
        backBtn = new Rect(5,5, 100, 50);

        canvasGO = new GameObject();
        ScreenText.makeCanvasGO(canvasGO);

        ScreenText Score = new ScreenText("Scores", Screen.width/2, Screen.height/15, 0, 30, Color.black, canvasGO);
    
        ScreenText totalDamage = new ScreenText("Max Damage", Screen.width / 2, Screen.height / 7, 0, 24, Color.black, canvasGO);
        ScreenText onBoss = new ScreenText("On Boss From Player", Screen.width / 3, Screen.height / 4, 0, 20, Color.black, canvasGO);
        ScreenText onPlayer = new ScreenText("On Player From Boss", Screen.width / 3 * 2, Screen.height / 4, 0, 20, Color.black, canvasGO);

        for (int i = 0; i < data.numLevels; i++)
        {
            ScreenText levelTxt = new ScreenText("Level " + data.levelDatas[i].level, Screen.width / 6, Screen.height / 3 + (24 * i), 0, 20, Color.black, canvasGO);
            ScreenText onBossVal = new ScreenText(data.levelDatas[i].maxDamageFromPlayerToBoss.ToString(), Screen.width / 3, Screen.height / 3 + (24 * i), 0, 20, Color.black, canvasGO);
            ScreenText onPlayerVal = new ScreenText(data.levelDatas[i].maxDamageFromBossToPlayer.ToString(), Screen.width / 3*2, Screen.height / 3 + (24 * i), 0, 20, Color.black, canvasGO);
        }    
    
    }

    private void OnGUI()
    {
        if(GUI.Button(backBtn, "Back"))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}