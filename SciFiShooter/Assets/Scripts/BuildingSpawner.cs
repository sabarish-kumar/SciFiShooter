using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawner : MonoBehaviour
{
    #region Fields
   
    public Mesh[] meshArray;
    public Material[] materialArray;
    public GameObject buildingPrefab;
    public GameObject treePrefab;
    public BuildingProfile[] profileArray;

    

   

   
    #endregion

    #region Properties	
    #endregion

    #region Methods
    #region Unity Methods

    // Use this for internal initialization
    void Awake()
    {
       
    }

    // Use this for external initialization
    void Start()
    {
        //CITY BUILDINGS:
        //Original loop
        /*for (int i = -30; i <= 30; i += 5)
        {
            for (int j = -30; j <=30; j += 5)
            {
                int random = Random.Range(0, profileArray.Length);
                Instantiate(buildingPrefab, new Vector3(i*20, 15f, j*20) + transform.position, Quaternion.identity, this.transform).GetComponent<DeluxeTowerBlock>().SetProfile(profileArray[random]);

                
                
            }
        }*/
        //Modified loop
        for (int i = -10; i <= 10; i += 5)
        {
            for (int j = -10; j <= 10; j += 5)
            {
                int random = Random.Range(0, profileArray.Length);
                Instantiate(buildingPrefab, new Vector3(i * 20, 15f, j * 20) + transform.position, Quaternion.identity, this.transform).GetComponent<DeluxeTowerBlock>().SetProfile(profileArray[random]);



            }
        }

    }

    /*private void Update()
    {
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "GameAssets")
            {
                Debug.Log("Collision Detected");
                Destroy(collision.gameObject);
            }
        }
    }*/
   
    #endregion



    #endregion

}

