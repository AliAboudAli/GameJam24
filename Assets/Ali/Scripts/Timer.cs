using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer: MonoBehaviour
{
    public TextMeshProUGUI countdownText;
    private int timer = 90;
    private bool isGameOver = false;
    public string gameOverSceneName;

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
        Debug.Log("Game Over");
        SceneManager.LoadScene("End");
    }
}