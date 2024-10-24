using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnController : MonoBehaviour
{
    public GameObject Pipe;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void SpawnPipe()
    {
        Instantiate(Pipe, new Vector3(this.transform.position.x, Random.Range(-2,2), this.transform.position.z), Quaternion.identity, this.transform);
        Invoke("SpawnPipe", 3f);
    }
}
