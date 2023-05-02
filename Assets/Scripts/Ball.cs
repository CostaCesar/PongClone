using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private GameObject display;
    public float startForce = 20.0f;

    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
            GetComponent<Rigidbody2D>().velocity =
        	new Vector2(startForce, startForce);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        string msg = "";
        
        Debug.Log("Hit");
        if(other.gameObject.name == "Left") msg = "AI Wins!";
        else if(other.gameObject.name == "Right") msg = "Player Wins!";
        
        StartCoroutine(Restart(msg));
    }

    private IEnumerator Restart(string msg)
    {
        display.GetComponent<Message>().Display(msg);
        yield return new WaitForSecondsRealtime(4);
        display.GetComponent<Message>().Display("");
        Start();
    }
}
