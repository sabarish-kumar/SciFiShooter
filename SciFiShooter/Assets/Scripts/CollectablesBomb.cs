using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablesBomb : MonoBehaviour
{
   
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        ScoringSystem.theHealth -= 5;
        Destroy(gameObject);

    }
}
