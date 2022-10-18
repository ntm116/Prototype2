using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float timer = 1f;
    private float delay = 1f;

    // Update is called once per frame
    void Update()
    {
        if (timer < delay * 2) 
            timer += Time.deltaTime;
        // On spacebar press, send dog
        if (timer > delay && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timer = 0f;
        }
    }
}
