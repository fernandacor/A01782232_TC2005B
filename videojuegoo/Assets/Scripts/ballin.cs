using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballin : MonoBehaviour
{
    [SerializeField] scoreAdder scoreObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Detect two elements in contact
    void OnTriggerEnter2D()
    {
        scoreObj.AddPoints(1);
    }
}
