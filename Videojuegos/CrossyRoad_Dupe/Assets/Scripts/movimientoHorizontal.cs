using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script allows horizontal, constant movement
//Used in farmers

public class movimientoHorizontal : MonoBehaviour
{
    //Variable set to be changed in the Unity interface
    [SerializeField] public float velocidadMovimiento;

    void Update()
    {
        transform.Translate(velocidadMovimiento * Time.deltaTime, 0 , 0);
    }
}
