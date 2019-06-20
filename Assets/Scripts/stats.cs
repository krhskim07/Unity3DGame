using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(gameObject.name == "coinText")
        //{
        //    GetComponent<TextMesh>().text = "Coins : " + GameManager.coinTotal;

        //}

        if (gameObject.name == "timeText")
        {
            GetComponent<TextMesh>().text = "Time Total : " + GameManager.timeTotal;
        }

        if (gameObject.name == "runStatus")
        {
            GetComponent<TextMesh>().text = GameManager.levelCompStatus;
        }
    }
}
