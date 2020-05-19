using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCollectables : MonoBehaviour
{
    public GameObject coll;
    void Start()
    {
        Invoke("ActiColl", (float)0.1f);
    }

    public void ActiColl()
    {
        ScoringSystem.theHealth = 100;
        gameObject.SetActive(coll);
    }
}
