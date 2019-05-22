using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinLoseCondition : MonoBehaviour
{
    public GameObject[] Animals;
    public GameObject[] Enemies;
    public bool isWin;
    public bool isLose;
    float timeLeft = 100f;
    public Text howManyTimes;
    public Text howManySheeps;
    public Text howManyEnemies;
    public int sheepCount;
    public int enemiesCount;
    public GameObject winScreen;
    public GameObject loseScreen;
    
    

    // Start is called before the first frame update
    void Start()
    {
        Animals = GameObject.FindGameObjectsWithTag("Animal");
        Enemies = GameObject.FindGameObjectsWithTag("E_Animal");
        
        isWin = false;
        isLose = false;
        sheepCount = GameObject.FindGameObjectsWithTag("Animal").Length;
        enemiesCount = GameObject.FindGameObjectsWithTag("E_Animal").Length;

        winScreen.SetActive(false);
        loseScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft.ToString("0");
        howManyTimes.text = timeLeft + "  seconds to win!";
        howManySheeps.text = sheepCount + "  stags to save!";
        howManyEnemies.text = enemiesCount + "  panthers to kill ";
        timeLeft -= Time.deltaTime;
    
        for (int i = 1; i < Animals.Length; i++)
        {
            
            Debug.Log("show" + sheepCount);
                if (sheepCount <= 0)
            {
                isLose = true;
            }
           


        }
        for (int i = 0; i < Enemies.Length; i++)
        {
            if (enemiesCount <= 0)
            {
                isWin = true;
            }
        }
        

        if (timeLeft < 0 && !isLose)
        {
            isWin = true;
        }
        if (isWin)
        {
            YouWin();
        }
        if (isLose)
        {
            YouLose();
        }
     }
    public void YouWin()
    {
        winScreen.SetActive(true);
        Time.timeScale = 0;
        if (Input.GetKey(KeyCode.R))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(1);

        }
    }
    public void YouLose()
    {
        loseScreen.SetActive(true);
        Time.timeScale = 0;
        if (Input.GetKey(KeyCode.R))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(1);
        }
    }

}
