using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timer;
    public float spawnTime = 0.5f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timer > spawnTime)
        {
            timer = 0f; 
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
