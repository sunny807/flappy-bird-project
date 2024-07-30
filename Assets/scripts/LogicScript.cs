using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int playerscore;
    public Text scoretext;
    public GameObject gameoverscreen;

    [ContextMenu("increase score")]
    public void addScore(int ScoreToAdd )
    {
        playerscore = playerscore + ScoreToAdd;
        scoretext.text = playerscore.ToString(); 
        
    }
    public void Restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
    public void gameover()
    {
        gameoverscreen.SetActive(true);
    }
}
