using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{

    public GameObject DataObject;

    // Start is called before the first frame update
    void Start()
    {
        Object.DontDestroyOnLoad(DataObject);
        Data data = DataObject.GetComponent<Data>();

        SceneManager.LoadScene("Main Menu");
    }

}
