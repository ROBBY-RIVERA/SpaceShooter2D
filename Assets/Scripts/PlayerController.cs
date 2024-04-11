using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am a player!");
        //transform.position = new Vector3(transform.position.x -300f, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.Rotate(new Vector3(5.0f, 5));
        // transform.position = new Vector3(transform.position.x - 1.0f, transform.position.y, transform.position.z);
        //float speed = 10.0f;
        float direction = Input.GetAxis("Horizontal");
        float verticalDirection = Input.GetAxis("Vertical");
        transform.Translate(speed * Time.deltaTime * new Vector2(direction, verticalDirection));
        //transform.Translate(speed * Vector2.right * Time.deltaTime);
    }
}
