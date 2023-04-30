using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    private float speed = Config.PlayerSpeed;
    private GameObject ball;
    private GameObject player;
    
    void Start()
    {
    	ball = GameObject.Find("Ball");
        player = GameObject.Find("Player");
    }
    
    void Update()
    {
        float step =  speed * Time.deltaTime;
        Vector3 position;
        if(ball.transform.position.x > transform.position.x || ball.transform.position.x < player.transform.position.x)
            position = new Vector3(transform.position.x, 0, 0);
        else position = new Vector3(transform.position.x, ball.transform.position.y, 0);
            
        transform.position = Vector3.MoveTowards(transform.position, position, step);
    }
}
