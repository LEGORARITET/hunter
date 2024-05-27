using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private float sensytivity = 2;
    
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Mouse X") * sensytivity;

        transform.Rotate(0, horizontal, 0);

        vertical = Input.GetAxis("Mouse Y") * sensytivity;

        transform.Rotate(0,0, vertical);
    }
}
