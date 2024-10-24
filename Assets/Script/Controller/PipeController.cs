using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    [SerializeField] private float Speed;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PipeDestroy());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Speed * Time.deltaTime);
    }


    IEnumerator PipeDestroy()
    {
        yield return new WaitForSeconds(15f);

        Destroy(this.gameObject);
    }
}
