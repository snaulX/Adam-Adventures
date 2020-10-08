using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement;
        if (Input.GetKeyDown(KeyCode.W))
        {
            movement = new Vector3(1, 0);
        }
        else
        {
            movement = new Vector3();
        }
        transform.Translate(movement);
    }
}
