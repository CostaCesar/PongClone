using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Message : MonoBehaviour
{
    public void Display(string msg)
    {
        Debug.Log("Show Text");
        TMP_Text show = GetComponent<TMP_Text>();
        show.text = msg;
    }
}
