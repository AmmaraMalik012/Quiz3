using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    private float rotationSpeed = 80f;
    private Vector3 horizontalMovement;

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = new Vector3(0f, 0f, -Input.GetAxis("Horizontal"));
        transform.Rotate(horizontalMovement * rotationSpeed * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.up), 10f);
            if(hit)
            {
                Debug.Log("Hit something : " + hit.collider.name);
            }
        }
    }
}
//i tried my best but this project is too difficult ;_;