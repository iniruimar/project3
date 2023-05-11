using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling_Rocks : MonoBehaviour
{
    public GameObject Roca;
    public AvoidRocksAgent player;
    public float spawnRate = 1f;
    // Update is called once per frame
    void Update()
    {
        if (Random.value < spawnRate * Time.deltaTime ){
            SpawnRock();
        }
    }

    void SpawnRock(){
        GameObject rock = Instantiate(Roca, transform.position, Quaternion.identity);
        player.rocks.Add(rock.gameObject);
        float zOffset = Random.Range(-5f, 5f);
        rock.transform.position += new Vector3(0,0,zOffset);

    
    }


}
