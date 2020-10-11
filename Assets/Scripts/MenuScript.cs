using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Text textField;

    public void PlayGame(string page) {
        SceneManager.LoadScene(page);
    }

    public void Exit() {
        Application.Quit();
    }

    public void SetText(string text) {
        textField.text = text;
    }
}
