using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif 

public class TitleManager : MonoBehaviour
{
    //public Button startButton;
    //public Button quitButton;
    public TMP_InputField playerNameField;
    public Text highScoreText;
    //public InputField playerNameField;
    // Start is called before the first frame update
    void Start()
    {
        ScoreManager.Instance.LoadPlayerData();
        highScoreText.text = "High Score: " + ScoreManager.Instance.highScorePlayerName + " : " + ScoreManager.Instance.highScorePlayerScore; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame() {
        if (ScoreManager.Instance != null)
        {
            ScoreManager.Instance.currentPlayerName = playerNameField.text;
        }
        SceneManager.LoadScene("main");
    }

    public void QuitGame() {
        //MainManager.Instance.SaveColor();
        #if UNITY_EDITOR
                EditorApplication.ExitPlaymode();
        #else
                Application.Quit(); // original code to quit Unity player
        #endif
    }
}
