using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
     public float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        Rotation();
    }

    private void Rotation(){
        transform.Rotate(Vector3.right * speed);
    }
}
