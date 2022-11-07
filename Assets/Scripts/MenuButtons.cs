using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour


{

    public int m_buttonW = 100;
    public int m_buttonH = 50;
    public int m_buttonSpacing = 10;
    public int m_nbutton = 5;

    Rect[] m_buttonsRect;
    // Start is called before the first frame update
    void Start() {

        m_buttonsRect = new Rect[m_nbutton];
        for (int i = 0; i < m_nbutton; i++) {
            m_buttonsRect[i] = new Rect(Screen.width/2 - m_buttonW/2, Screen.height / 2 - (m_nbutton * (m_buttonH + m_buttonSpacing) /2) + (i * (m_buttonH + m_buttonSpacing)), m_buttonW, m_buttonH);
        }
    }

    // Update is called once per frame
    void Update() {

    }

    void OnGUI() {
        for (int i = 0; i < m_nbutton; i++) {
            if (i == 0) {
                if (GUI.Button(m_buttonsRect[i], "Scores"))
                {
                    SceneManager.LoadScene("Scores");
                }
            } else if (i == m_nbutton-1)
            {
                if (GUI.Button(m_buttonsRect[i], "Exit"))
                {
                    Application.Quit();
                    EditorApplication.isPlaying = false;
                }
            }
            else
            {
                if (GUI.Button(m_buttonsRect[i], "Level" + i)) {
                    SceneManager.LoadScene("Level" + i);
                }
            }

        }

    }
}