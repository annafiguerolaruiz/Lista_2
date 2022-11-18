using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ex1_More_Enemies : MonoBehaviour
{
    public int spheresWaves = 1;
    public GameObject spherePrefab; 
    public float sphereEnemies = 1; 

   

    private void Start()
    {
        sphereEnemies = 1;
    }

    private Vector3 RandomPosition() 
    {
        //We instantiate enemies within the limits of the screen
        return new Vector3(Random.Range(-8, 8), Random.Range(-4, 4), 0);
    }

    void Update()
    {
        if (sphereEnemies == 0)
        {
            spheresWaves += 1; 
            sphereEnemies = spheresWaves;
            //We instantiate a new sphere on screen
            for (int i = 0; i < sphereEnemies; i++) 
            {
                Instantiate(spherePrefab, RandomPosition(), gameObject.transform.rotation);
            }
        }
    }

}
