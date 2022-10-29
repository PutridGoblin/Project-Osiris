using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    [SerializeField] float lerpDuration;
    
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(int health, int damage)
    {
        StartCoroutine(AnimateHealth(health, damage));
    }

    IEnumerator AnimateHealth(int health, int damage)
    {
        slider.value = health;
        float animationTime = 0f;
        while (animationTime < lerpDuration)
        {
            animationTime += Time.deltaTime;
            float lerpValue = animationTime / lerpDuration;
            slider.value = Mathf.Lerp(health, health - damage, lerpValue);
            fill.color = gradient.Evaluate(slider.normalizedValue);
            yield return null;
        }
    }
}
