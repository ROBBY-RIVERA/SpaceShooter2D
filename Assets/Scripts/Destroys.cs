using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupColllects : MonoBehaviour
{
    // Pikckup collect logic
    [SerializeField] public static int pickupAmount = 0;

    // Cash Money
    public static int dollar = 0;

    // This is our HUD image UI object
    [SerializeField] public static Image hud;

    // Pickup sprites
    [SerializeField] Sprite pickup1tex;
    [SerializeField] Sprite pickup2tex;
    [SerializeField] Sprite pickup3tex;
    [SerializeField] Sprite pickup4tex;
    [SerializeField] Sprite pickup5tex;
    [SerializeField] Sprite pickup6tex;
    [SerializeField] Sprite pickup7tex;
    [SerializeField] Sprite pickup0tex;
    [SerializeField] Sprite pickup8tex;
    [SerializeField] Sprite pickup9tex;
    [SerializeField] Sprite pickup11tex;
    [SerializeField] Sprite pickup12tex;
    [SerializeField] Sprite pickup13tex;
    [SerializeField] Sprite pickup14tex;
    [SerializeField] Sprite pickup15tex;
    [SerializeField] Sprite pickup16tex;
    [SerializeField] Sprite pickup17tex;
    [SerializeField] Sprite pickup20tex;
    [SerializeField] Sprite pickup18tex;
    [SerializeField] Sprite pickup19tex;
    [SerializeField] Sprite pickup10tex;
    


    // Start is called before the first frame update
    void Start()
    {
        // Find the HUD image object
        hud = gameObject.GetComponentInChildren<Image>();

        // Hide HUD on start
        hud.enabled = false;

        // Set initial pickAmount value to 0
        pickupAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (pickupAmount == 1)
        {
            hud.sprite = pickup1tex;
            hud.enabled = true;
        }
        else if (pickupAmount == 2)
        {
            hud.sprite = pickup2tex;
        }
        else if (pickupAmount == 3)
        {
            hud.sprite = pickup3tex;
        }
        else if (pickupAmount == 4)
        {
            hud.sprite = pickup4tex;
        }
        else if (pickupAmount == 5)
        {
            hud.sprite = pickup5tex;
        }
        else if (pickupAmount == 6)
        {
            hud.sprite = pickup6tex;
        }
        else if (pickupAmount == 7)
        {
            hud.sprite = pickup7tex;
        }
        else if (pickupAmount == 8)
        {
            hud.sprite = pickup8tex;
        }
        else if (pickupAmount == 9)
        {
            hud.sprite = pickup9tex;
        }
        else if (pickupAmount == 10)
        {
            hud.sprite = pickup10tex;
        }
        else if (pickupAmount == 11)
        {
            hud.sprite = pickup11tex;
        }
        else if (pickupAmount == 12)
        {
            hud.sprite = pickup12tex;
        }
        else if (pickupAmount == 13)
        {
            hud.sprite = pickup13tex;
        }
        else if (pickupAmount == 14)
        {
            hud.sprite = pickup14tex;
        }
        else if (pickupAmount == 15)
        {
            hud.sprite = pickup15tex;
        }
        else if (pickupAmount == 16)
        {
            hud.sprite = pickup16tex;
        }
        else if (pickupAmount == 17)
        {
            hud.sprite = pickup17tex;
        }
        else if (pickupAmount == 18)
        {
            hud.sprite = pickup18tex;
        }
        else if (pickupAmount == 19)
        {
            hud.sprite = pickup19tex;
        }
        else if (pickupAmount == 20)
        {
            hud.sprite = pickup20tex;
        }

        else
        {
            hud.sprite = pickup0tex;
        }
    }
}
