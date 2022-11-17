using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    private Ex1_More_Enemies Enemies;

    void Start()
    {
        Enemies = FindObjectOfType<Ex1_More_Enemies>();
    }

    private void OnMouseDown() //We eliminate enemies and the counter is updated while notifying us of how many enemies are left on the scene
    {
        Enemies.sphereEnemies -= 1;
        Destroy(gameObject);
    }


}
