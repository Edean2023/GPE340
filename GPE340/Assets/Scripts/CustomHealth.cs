using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomHealth : MonoBehaviour
{
    public int healthUI = 5;
    // number of hearts visible
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    
    public void healthBar()
    {
        if (healthUI > numOfHearts)
        {
            healthUI = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < healthUI)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    
}
