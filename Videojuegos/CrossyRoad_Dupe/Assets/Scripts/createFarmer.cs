using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script defines constant spawning of new enemies
// by: Fernanda Cantú Ortega A01782232 10/03/2023

public class createFarmer : MonoBehaviour
{
    //Class variable to be changed from the Unity interface
        [SerializeField] GameObject enemySpawn;
        [SerializeField] GameObject enemySpawn2;
        [SerializeField] float delay;
        [SerializeField] float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        //Call the EnterEnemy function after 0.5 seconds
        InvokeRepeating("EnterEnemy", 0.5f, delay);
    }

    void Update()
    {
        //Defines movement
        transform.Translate(velocidad * Time.deltaTime, 0, 0); 
    }

    void EnterEnemy()
    {
        //Generate a new random position for FARMERS
        Vector3 posFar = new Vector3(Random.Range(-10, 10), -2.44f, 0);
        Vector3 posFarA = new Vector3(Random.Range(-10, 10), -0.47f, 0);
        Vector3 posFarB = new Vector3(Random.Range(-10, 10), 1.54f, 0);
        Vector3 posFarC = new Vector3(Random.Range(-10, 10), 3.44f, 0);

        //Generate a new random position for SHARKS
        Vector3 posSh = new Vector3(Random.Range(-10, 10), -3.44f, 0);
        Vector3 posShA = new Vector3(Random.Range(-10, 10), -1.47f, 0);
        Vector3 posShB = new Vector3(Random.Range(-10, 10), 0.53f, 0);
        Vector3 posShC = new Vector3(Random.Range(-10, 10), 2.47f, 0);
        
        //Create a copy of the prefab of FARMERS
        GameObject objFar = Instantiate(enemySpawn, posFar, Quaternion.identity);
        GameObject objFarA = Instantiate(enemySpawn, posFarA, Quaternion.identity);
        GameObject objFarB = Instantiate(enemySpawn, posFarB, Quaternion.identity);
        GameObject objFarC = Instantiate(enemySpawn, posFarC, Quaternion.identity);

        //Create a copy of the prefab of SHARKS
        GameObject objSh = Instantiate(enemySpawn2, posSh, Quaternion.identity);
        GameObject objShA = Instantiate(enemySpawn2, posShA, Quaternion.identity);
        GameObject objShB = Instantiate(enemySpawn2, posShB, Quaternion.identity);
        GameObject objShC = Instantiate(enemySpawn2, posShC, Quaternion.identity);

        //DESTROY!!! (in 5 seconds)
        Destroy(objFar, 5);
        Destroy(objFarA, 5);
        Destroy(objFarB, 5);
        Destroy(objFarC, 5);
        Destroy(objSh, 5);
        Destroy(objShA, 5);
        Destroy(objShB, 5);
        Destroy(objShC, 5);
    }
}
