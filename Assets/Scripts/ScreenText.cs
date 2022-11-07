using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScreenText 
{
    public Text textComponent;
    public Font arial;
    public ScreenText(String textStr, float x, float y, float z, int fontSize, Color color, GameObject canvasGO)
    {

        // Load the Arial font from the Unity Resources folder.
        arial = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");

        // Create the Text GameObject.
        GameObject textGO = new GameObject();
        textGO.transform.parent = canvasGO.transform;
        textGO.AddComponent<Text>();

        // Set Text component properties.
        textComponent = textGO.GetComponent<Text>();
        textComponent.font = arial;
        textComponent.text = textStr;
        textComponent.fontSize = fontSize;
        textComponent.color = color;
        textComponent.alignment = TextAnchor.MiddleCenter;

        // Provide Text position and size using RectTransform.
        RectTransform rectTransform;
        rectTransform = textComponent.GetComponent<RectTransform>();
        rectTransform.localPosition = new Vector3(-Screen.width/2 + x, Screen.height / 2 - y, z);
        rectTransform.sizeDelta = new Vector2(Screen.width, Screen.height);
    }

    public static void makeCanvasGO(GameObject canvasGO)
    {
        canvasGO.name = "Canvas";
        canvasGO.AddComponent<Canvas>();
        canvasGO.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;
        canvasGO.AddComponent<CanvasScaler>();
        canvasGO.AddComponent<GraphicRaycaster>();
    }
}
