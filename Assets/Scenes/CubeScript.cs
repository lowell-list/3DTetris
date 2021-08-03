using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Define the speed at which the object moves.
        float moveSpeed = 10;

        // Get the value of the Horizontal input axis.
        float horizontalInput = Input.GetAxis("Horizontal");

        // Get the value of the Vertical input axis.
        float verticalInput = Input.GetAxis("Vertical");

        // Y hover
        float hoverY = Mathf.Sin(Time.time) * 0.125f;

        // Move the object to XYZ coordinates.
        transform.Translate(new Vector3(horizontalInput, hoverY, verticalInput) * moveSpeed * Time.deltaTime, Space.World);
    }
}
