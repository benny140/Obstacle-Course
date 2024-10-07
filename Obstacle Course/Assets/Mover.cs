using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    float xVelocity = 0.1f;

    [SerializeField]
    float yVelocity = 0.1f;

    [SerializeField]
    float zVelocity = 0.1f;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal");
        float yValue = Input.GetAxis("Vertical");
        transform.Translate(xValue * xVelocity, 0, yValue * yVelocity);
    }
}
