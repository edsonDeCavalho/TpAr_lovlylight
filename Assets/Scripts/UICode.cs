using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UICode : MonoBehaviour
{
    // Start is called before the first frame update
    public void play()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    public void quite()
    {
        Application.Quit();
    }
}
