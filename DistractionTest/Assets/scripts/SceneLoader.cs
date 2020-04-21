using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    public static int nextScene = 0;
    public GameObject title;

    public string[] SceneToBeLoaded = new string[] {
        "Base","Audio","Visual"
    };
    // Update is called once per frame
    void Update()
    {
        title.GetComponent<TMPro.TextMeshProUGUI>().text = SceneToBeLoaded[nextScene];

        if (Input.GetKeyDown(KeyCode.Space))
        {
            nextScene++;
            SceneManager.LoadScene("ProblemScene" + nextScene.ToString());
        }
    }
}
