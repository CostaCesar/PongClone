using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 1;
    
    void Start()
    {
    	rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        float yMove = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector3(0, yMove, 0) * speed;
    }
}
