using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createBalls : MonoBehaviour
{
    //Class variable to be changed from the Unity interface
        [SerializeField] GameObject basketball;
        [SerializeField] float delay;

    // Start is called before the first frame update
    void Start()
    {
        //Call the DropBall function after 0.5 seconds 
        //and then keep calling it every 0.8 seconds
        InvokeRepeating("DropBall", 0.5f, delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DropBall()
    {
        //Generate a new random position
        Vector3 pos = new Vector3(Random.Range(-10.0f, 10.0f), 6, 0);
        
        //Create a copy of the prefab
        GameObject obj = Instantiate(basketball, pos, Quaternion.identity);
        
        //Doom the object to die in 3 seconds
        Destroy(obj, 3);
    }

}
