using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public Transform pipe;
    public float init_random_time;
    public float end_random_time;
    public bool appear_when_start;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        if (appear_when_start)
        {
            Transform obstacle;
            obstacle = pipe;
            Instantiate(obstacle, new Vector3(transform.position.x, Random.Range(-2.5f, 2.5f), 0), Quaternion.identity);
        }
        else
        {
            appear_when_start= true;
        }
        float randomInterval = Random.Range(init_random_time, end_random_time);

        Invoke("Spawn", randomInterval);

    }
}
