using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private Transform[] balls;
    float interpolateAmount;
    float slowSpeed = 0.8f;
    // Update is called once per frame
    void Update()
    {
        // creating path for balls
        interpolateAmount = (interpolateAmount + Time.deltaTime) * slowSpeed;
        for(int i = 0; i<=7; i++)
        {
            balls[i].position = Vector3.Lerp(balls[i].transform.position, points[i].position, interpolateAmount);
        }
        // balls[0].position = Vector3.Lerp(balls[0].transform.position, points[7].position, interpolateAmount);
        // balls[1].position = Vector3.Lerp(balls[1].transform.position, points[6].position, interpolateAmount);
        // balls[2].position = Vector3.Lerp(balls[2].transform.position, points[5].position, interpolateAmount);
        // balls[3].position = Vector3.Lerp(balls[3].transform.position, points[4].position, interpolateAmount);
        // balls[4].position = Vector3.Lerp(balls[4].transform.position, points[3].position, interpolateAmount);
        // balls[5].position = Vector3.Lerp(balls[5].transform.position, points[2].position, interpolateAmount);
        // balls[6].position = Vector3.Lerp(balls[6].transform.position, points[1].position, interpolateAmount);
        // balls[7].position = Vector3.Lerp(balls[7].transform.position, points[0].position, interpolateAmount);
    }
}
