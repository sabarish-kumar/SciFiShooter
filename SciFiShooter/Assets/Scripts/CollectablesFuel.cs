using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablesFuel : MonoBehaviour
{ 
    void OnTriggerEnter(Collider other)
    {

        ScoringSystem.theFuel = 100;
        Destroy(gameObject);

    }
}
