using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer: MonoBehaviour
{
    public TextMeshProUGUI countdownText;
    private int timer = 9;
    private bool isGameOver = false;

    void Start()
    {
        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        while (timer >= 0 && !isGameOver)
        {
            countdownText.text = timer.ToString();
            yield return new WaitForSeconds(1);
            timer--;
        }

        if (!isGameOver)
        {
            countdownText.color = Color.red;
            countdownText.text = "0";
            Time.timeScale = 0;
            GameOver();
            //Debug.Log(":Freeze time " +  Time.timeScale);
        }
    }

    void GameOver()
    {
        //moet een ref komen van de fucntie die moet hier
        //debug laten om de gameover functie te testen
        Debug.Log("Game Over");
        
    }
}