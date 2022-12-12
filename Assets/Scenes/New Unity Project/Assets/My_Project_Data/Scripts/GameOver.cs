using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Ball")
        {
            Destroy(other.gameObject);
            Debug.Log("GameOver!");
        }
    }
}
