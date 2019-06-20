using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject ProjectilePrefab;
    public GameObject Spawner;
    public float Power;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            GameObject g = Instantiate(ProjectilePrefab,
                Spawner.GetComponent<Transform>().position,
                Quaternion.identity);
            g.GetComponent<Rigidbody>().AddForce(transform.forward * Power);
            Destroy(g, 2);
        }
    }
}
