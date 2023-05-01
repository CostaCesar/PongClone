using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField]
    Sprite[] images;
    private bool updating;
    // Update is called once per frame
    void Update()
    {
        if(updating == false)
            StartCoroutine(NextFrame());
    }

    private IEnumerator NextFrame()
    {
        updating = true;
        for(int i = 0; i < images.Length; i++)
        {
            GetComponent<SpriteRenderer>().sprite = images[i];
            yield return new WaitForSecondsRealtime(Random.Range(0.2f, 0.33f));
        }
        updating = false;
    }
}
