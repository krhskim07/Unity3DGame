using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    public int LoadByIndex;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (LoadByIndex == 1)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 4 * GameManager.zVelocityAdj);

        }
        if (LoadByIndex == 4)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0 * GameManager.zVelocityAdj);
        }
    }
}
