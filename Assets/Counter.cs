using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    private int count = 0;
    public Text text;
    public void countUp()
    {
        count += 100;
        text.text = "Score: " + count;
    }
}
