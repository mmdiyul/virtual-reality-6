using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void PlayGame(string page) {
        SceneManager.LoadScene(page);
    }

    public void Exit() {
        Application.Quit();
    }
}
