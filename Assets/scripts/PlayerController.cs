using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5;

    private float horizontalMovement;
    private float verticalMovement;
    Vector3 endPosition;
    Vector3 position; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");

        position.x += speed * Time.deltaTime * horizontalMovement;
        position.y += speed * Time.deltaTime * verticalMovement;

        transform.position = position;

    }
}
