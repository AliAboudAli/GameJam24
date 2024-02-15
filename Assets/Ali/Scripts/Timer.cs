using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timer;
    public float RemainingTime;

    void Update()
    {
        if (RemainingTime > 0)
        {
            RemainingTime -= Time.deltaTime;
        }
        else if (RemainingTime < 0)
        {
            RemainingTime = 0;
            timer.color = Color.red;
            //gameover to back to main menu

            int minutes = Mathf.FloorToInt(RemainingTime / 60);
            int seconds = Mathf.FloorToInt(RemainingTime % 60);
            timer.text = string.Format("{0:00}:{1:00}", minutes, seconds); // Corrected format
        }
    }
}