using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float playerSpeed = 8.0f;
    private float horizontalInput;
    private float verticalInput;
    private float horizontalScreenLimit = 9.5f;
    private float verticalScreenLimitTop = 2f;
    private float verticalScreenLimitBottom = 3.5f;
    private float adjustedVerticalInput;

    public GameObject bulletPrefab;

    private void Start()
    {
        
    }

    private void Update()
    {
        Movement();
        Shooting();
    }

    void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // Adjusts vertical input to stay within bounds
        adjustedVerticalInput = verticalInput;
        if ((transform.position.y >= verticalScreenLimitTop / 2 && verticalInput > 0) || (transform.position.y <= -verticalScreenLimitBottom && verticalInput < 0))
        {
            adjustedVerticalInput = 0;
        }
        transform.Translate(new Vector3(horizontalInput, adjustedVerticalInput, 0) * Time.deltaTime * playerSpeed);
        if (transform.position.x >= horizontalScreenLimit || transform.position.x <= -horizontalScreenLimit)
        {
            transform.position = new Vector3(-transform.position.x, transform.position.y, 0);
        }
        // Code to wrap around the bottom and top of screen is removed because that isn't possible anymore because of the input adjustment

    }

    void Shooting()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        }
    }
}
