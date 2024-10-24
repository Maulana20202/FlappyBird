using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSpawnerController : MonoBehaviour
{

    public GameObject Ground;

    // Start is called before the first frame update
    void Start()
    {
        SpawnGround();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SpawnGround()
    {
        Instantiate(Ground, this.transform.position, Quaternion.identity, this.transform);
        Invoke("SpawnGround", 5f);
    }
}
