using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float startForce = 20.0f;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity =
        	Vector2.right * startForce;
    }
}
