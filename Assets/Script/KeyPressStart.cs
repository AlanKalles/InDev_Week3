using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPressStart : MonoBehaviour
{
    private Rigidbody2D grascale;
    // Start is called before the first frame update
    void Start()
    {
        grascale = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")){
            grascale.gravityScale = 1;
            Debug.Log("add");
        }
    }
}
