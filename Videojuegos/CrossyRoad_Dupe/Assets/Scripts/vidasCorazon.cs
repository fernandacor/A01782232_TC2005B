using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Logic manager script, controls winning, losing, and life system
// by: Fernanda Cantú Ortega A01782232 10/03/2023

public class vidasCorazon : MonoBehaviour
{
    //defines object to whom the script applies to
    [SerializeField] GameObject vaquita; //defines object to whom the script applies to

    //allows to change the number of health and hearts the game starts with (from 0-10)
    public int health;
    public int numOfHearts;

    //defines sprites that belong to a full life and an empty life
    public Image[] hearts;
    public Sprite corazonLleno;
    public Sprite corazonVacio;

    //allows to select the texts used from the unity interface
    public GameObject gameOverText;
    public GameObject youWinText;


    void Start()
    {
        //the game starts without either of the texts
        gameOverText.SetActive(false);
        youWinText.SetActive(false);
    }

    void Update()
    {
        //sets an equality between health and number of hearts
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        //if all health is lost, you lose the game
        if (health == 0)
        {
            Destroy(vaquita, 1);
            gameOverText.SetActive(true);
        }

        //for loop to define when a full or empty heart is shown
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
        //if the player touches a trigger with the tag "enemy", health is lost
        if(other.gameObject.tag == "enemy")
        {
            health = health - 1;
        }

        //if the player touches the object tagged "checkpoint", you win
        if (other.gameObject.tag == "checkpoint")
        {
            youWinText.SetActive(true);
        }
    }
}