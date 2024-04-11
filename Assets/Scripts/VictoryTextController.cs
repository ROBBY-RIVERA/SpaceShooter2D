using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryTextController : MonoBehaviour
{
    public Text winText;

    public int defeats;

    
    // Start is called before the first frame update
    void Start()
    {
        winText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (defeats >= 20)
        {
            winText.gameObject.SetActive(true);
            GameObject.Find("LostText").GetComponent<LostTextController>().incrementDeath(-1);
        }
        
    }
    public void incrementDefeats(int numb)
    {
        defeats += numb;
    }
}
