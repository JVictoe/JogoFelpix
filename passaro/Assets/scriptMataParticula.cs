using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptMataParticula : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("MataParticula", 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MataParticula()
    {
        Destroy(gameObject);
    }
}
