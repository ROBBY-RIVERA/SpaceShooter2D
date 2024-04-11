using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.UI;


public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private float fallingSpeed = 2.0f;
    [SerializeField]
    private float horizontalRangeMin = -9f;
    [SerializeField]
    private float horizontalRangeMax = -9f;
    [SerializeField]
    private float endZ = -10.0f;
    [SerializeField]
    private Vector2 startlocation = Vector2.zero;

    


    public static int dollar = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        //CheckRespawn();
    }

    private void Move()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - (fallingSpeed * Time.deltaTime));
    }

    /*private void CheckRespawn()
    {
        if (transform.position.y < endZ)
        {
            // respawn at a random X
            float newX = Random.Range(horizontalRangeMin, horizontalRangeMax);
            transform.position = new Vector2(newX, startlocation.y);
        }
    }
    */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null && collision.gameObject.CompareTag("Bullet") && dollar < 20)
        {
            //GameManager.Instance.SetPlayerPoints(1);
            GameObject.Find("VictoryText").GetComponent<VictoryTextController>().incrementDefeats(1);
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            dollar++;
            PickupColllects.pickupAmount++;
        }
        if (collision != null && collision.gameObject.CompareTag("Bullet") && dollar >= 20)
        {
            //GameManager.Instance.SetPlayerPoints(1);
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            
            Debug.Log("swooopity douepor");
            
        }
        if (collision != null && collision.gameObject.CompareTag("Player"))
        {
            GameObject.Find("LostText").GetComponent<LostTextController>().incrementDeath(1);
            
            Destroy(collision.gameObject);
        }
    }
}
