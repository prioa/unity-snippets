using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomHeightSpawner : MonoBehaviour {

    // Set delay for every Spawn
    public float delay = 1;
    private float timer = 0;

    // Set GameObject (object thats gonna spawn random)
    public GameObject object;

    // Set height variation limit
    public float height;

    
    void Start () {
        // Initialize first random Object on Script start
        GameObject newObject = Instantiate(object);
        // Set Random position for first Object
        newObject.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    void Update () {
        // If delay (in sec) is over
        if (timer > delay) {
            {
                // Initialize random Object on Script start
                GameObject newObject = Instantiate(object);
                // Set Random position for Object
                newObject.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
                // Destroy Object after 15s
                Destroy(newObject, 15);
                // Reset timer to start loop again
                timer = 0;
            }
        }
        timer += Time.deltaTime;
    }
}
