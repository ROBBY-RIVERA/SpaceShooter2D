using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public Text healthText;

    

    public static int dollar = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        health -= 1;
        //Debug.Log(health);
        healthText.text = health.ToString();
    }
}
