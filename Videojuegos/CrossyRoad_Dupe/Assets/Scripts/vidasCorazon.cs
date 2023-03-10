using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Logic manager script, controls winning, losing, and life system

public class vidasCorazon : MonoBehaviour
{
    [SerializeField] GameObject vaquita;

    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite corazonLleno;
    public Sprite corazonVacio;

    public GameObject gameOverText;
    public GameObject youWinText;


    void Start()
    {
        gameOverText.SetActive(false);
        youWinText.SetActive(false);
    }

    void Update()
    {
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        if (health == 0)
        {
            Destroy(vaquita, 1);
            gameOverText.SetActive(true);
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < health)
            {
                hearts[i].sprite = corazonLleno;
            }
            else
            {
                hearts[i].sprite = corazonVacio;
            }

            if(i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "enemy")
        {
            health = health - 1;
        }

        if (other.gameObject.tag == "checkpoint")
        {
            youWinText.SetActive(true);
        }
    }
}