using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject prefab;
    public Transform rifleTransform;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyUp(KeyCode.Space))
        {
            // Instantiate a prefab in 2d space at the transform of the parent
            //Vector3 newPosition = new Vector3(400f, transform.position.y + 300.0f, transform.position.z);
            Quaternion quaternion = Quaternion.Euler(0f, 0f, 0f);
            Instantiate(prefab, rifleTransform.position, quaternion);
            // clone.transform.position = transform.position;
            // Debug.Log(clone.transform.position);
        }
    }
}
