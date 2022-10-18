using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 10.0f;

    [SerializeField]
    private float xRange = 10.0f;

    [SerializeField]
    private GameObject projectilePrefab;

    private float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        transform.Translate(speed * horizontalInput * Time.deltaTime * Vector3.right);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("projectile");
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
    }
}
