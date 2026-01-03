using UnityEngine;
using UnityEngine.UI; // UI ke liye zaroori hai

public class HealthBar : MonoBehaviour
{
    public Slider slider; // Screen par dikhne wali patti

    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(float health)
    {
        slider.value = health;
    }
}
