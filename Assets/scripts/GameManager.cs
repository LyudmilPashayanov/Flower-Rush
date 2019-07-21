using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameOver = false;
    public bool gameWon = false;
    public GameObject GameOverUI;
    public GameObject InstructionText;
    public GameObject WinGameUI;
    public GameObject youDrownedUI;
    public void Start()
    {
        StartCoroutine(DeleteObject(InstructionText, 15.0f));
    }
    IEnumerator DeleteObject(GameObject objectText, float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(objectText);
    }
    public void endGame()
    {
        if (gameOver == false)
        {
            gameOver = true;
            
           Invoke( "setGUIActive",1f);
            Debug.Log("Game OVER");
           
        }
    }
    public void youDrowned()
    {
        if (gameOver == false)
        {
            gameOver = true;

            Invoke("drownUI", 2f);
            Debug.Log("Game OVER");

        }
    }
    public void drownUI()
    {
        youDrownedUI.SetActive(true);
    }
    public void winGame()
    {
        if(gameWon == false)
        {
            gameWon = true;
            Invoke("setLevelCompleteActive", 1f);
            Debug.Log("Game won");
        }
    }
    public void setLevelCompleteActive()
    {
        WinGameUI.SetActive(true);
    }
        public void setGUIActive()
    {
        GameOverUI.SetActive(true);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
