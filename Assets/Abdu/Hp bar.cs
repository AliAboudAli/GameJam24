using UnityEngine;
using UnityEngine.UI;

public class Hpbar : MonoBehaviour
{
    public Slider slider; // Reference to the Slider component

    void Start()
    {
        slider = GetComponent<Slider>(); // Get the Slider component attached to this GameObject
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }
}