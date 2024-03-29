using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    public float distance;

    private bool moovingLeft = true;

    public Transform groundDetection;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if (groundInfo.collider == false)
        {
            if (moovingLeft == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                moovingLeft = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                moovingLeft = true;
            }
        }
    }
}
