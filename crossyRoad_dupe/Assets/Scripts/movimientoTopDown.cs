using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoTopDown : MonoBehaviour
{
    [SerializeField] float velocidadMovimiento;
    [SerializeField] Vector2 direccion;

    public Rigidbody2D rb2D;

    // Update is called once per frame
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        direccion = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }

    void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + direccion * velocidadMovimiento * Time.fixedDeltaTime);
    }
}
