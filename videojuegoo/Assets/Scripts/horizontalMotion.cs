using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Move a GameObject horizontally using the arrow keys or AD

public class horizontalMotion : MonoBehaviour
{
    Vector3 move;

    [SerializeField] float speed;
    [SerializeField] float limit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxis("Horizontal");

        if (transform.position.x < -limit && move.x < 0)
        {
            move.x = 0;
        }
        else if (transform.position.x > limit && move.x > 0)
        {
            move.x = 0;
        }

        transform.Translate(move * speed * Time.deltaTime);
    }
}
