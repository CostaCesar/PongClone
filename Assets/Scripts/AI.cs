using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    private float speed = Config.PlayerSpeed;
    private GameObject ball;
    
    void Start()
    {
    	ball = GameObject.Find("Ball");
    }
    
    void Update()
    {
        float step =  speed * Time.deltaTime;
        Vector3 position = new Vector3(transform.position.x, ball.transform.position.y, 0);
        transform.position = Vector3.MoveTowards(transform.position, position, step);
    }
}
