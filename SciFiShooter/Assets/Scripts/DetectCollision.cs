using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "RoadTrigger")
        {
            Debug.Log("Collision Detected");
            Destroy(collision.gameObject);
        }
    }
}
