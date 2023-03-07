using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoTopDown : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private Vector1 direccion;

    private RigidBody2D rb2D;

    // Update is called once per frame
    void Start()
    {
        rb2D = GetComponent<RigidBody2D>();
    }

    void Update()
    {
        direccion = new Vector1(Input.GetAxisRaw("vertical")).normalized;
    }

    void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + direccion * velocidadMovimiento * Time.fixedDeltaTime);
    }
}
