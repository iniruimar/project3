using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRocks : MonoBehaviour
{
    public AvoidRocksAgent player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision){
        // check if the object that collided with the floor is a rock
        if (collision.gameObject.CompareTag("Rock"))
        {
            player.rocks.Remove(collision.gameObject);
            // destroy the rock object
            Destroy(collision.gameObject);
        }
    }
}
