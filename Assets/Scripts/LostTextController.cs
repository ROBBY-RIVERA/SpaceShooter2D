using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LostTextController : MonoBehaviour
{
    public Text lostText;
    

    public int death;
    // Start is called before the first frame update
    void Start()
    {
        lostText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (death == 1)
        {
            lostText.gameObject.SetActive(true);
            //GameObject.Find("VictoryText").GetComponent<VictoryTextController>().winText.gameObject.SetActive(false);
        }
    }
    public void incrementDeath(int number)
    {
        death += number;
    }
}
