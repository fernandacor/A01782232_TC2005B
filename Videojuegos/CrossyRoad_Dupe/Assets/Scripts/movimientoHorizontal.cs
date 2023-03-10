using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script allows horizontal, constant movement
//Used in farmers
// by: Fernanda Cantú Ortega A01782232 10/03/2023

public class movimientoHorizontal : MonoBehaviour
{
    //Variable set to be changed in the Unity interface
    [SerializeField] public float velocidadMovimiento;

    void Update()
    {
        //Defines movement
        transform.Translate(velocidadMovimiento * Time.deltaTime, 0 , 0);
    }
}
