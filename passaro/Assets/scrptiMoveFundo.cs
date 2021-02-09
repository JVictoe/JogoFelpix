using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrptiMoveFundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -5.25f)
        {
            transform.position = new Vector2(10.5f, 0);
        }
    }
}
