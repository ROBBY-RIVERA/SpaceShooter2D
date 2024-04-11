using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End : MonoBehaviour
{
    // Text Hint content
    public static string message; // Message content
    public static Text textHint; // Onscreen text object

    //Text On timer
    public static bool textOn = false;
    private float timer = 0.0f;
    public static float textOnTime = 10f;


    // Start is called before the first frame update
    void Start()
    {
        textHint = GetComponent<Text>();
        timer = 0.0f;
        textOn = false;
        textHint.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (textOn)
        {
            textHint.enabled = true;
            textHint.text = message;
            timer += Time.deltaTime;
        }
        if (timer >= textOnTime)
        {
            textOn = false;
            textHint.enabled = false;
            timer = 0.0f;
        }


    }
}
