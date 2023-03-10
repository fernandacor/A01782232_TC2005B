using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script for the player character to move vertically

public class movimientoVertical : MonoBehaviour
{
    [SerializeField] public Vector2 direccion;
    [SerializeField] public float velocidadMovimiento;
    Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direccion = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }

    void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + direccion * velocidadMovimiento * Time.fixedDeltaTime);
    }
}
