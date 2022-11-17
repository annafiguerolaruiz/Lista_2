using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3 : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y <= 79)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.Translate(0, 40f, 0);
            }
        }
        if (transform.position.y >= -79)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.Translate(0, -40f, 0);
            }
        }

        if (transform.position.x >= -79)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Translate(-40f, 0, 0);
            }
        }

        if (transform.position.x <= 79)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.Translate(40f, 0, 0);
            }
        }

    }
}
