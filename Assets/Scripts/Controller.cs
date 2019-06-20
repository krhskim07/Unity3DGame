using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{

    public float horizonVel = 0;
    public int laneNum = 1;
    public string controlLocked = "n";

    public int LoadByIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Movement of the player
        if (LoadByIndex == 1)
        {
            Rigidbody r = GetComponent<Rigidbody>();

            r.velocity = new Vector3(horizonVel, 0, 4);

            if ((Input.GetKey(KeyCode.RightArrow)) && (laneNum < 5) && (controlLocked == "n"))
            {
                horizonVel = 4;
                StartCoroutine(StopSlide());
                laneNum += 2;
                controlLocked = "y";
            }
            if ((Input.GetKey(KeyCode.LeftArrow)) && (laneNum > -1) && (controlLocked == "n"))
            {
                horizonVel = -4;
                StartCoroutine(StopSlide());
                laneNum -= 2;
                controlLocked = "y";
            }
        }

        if (LoadByIndex == 4)
        {
            Rigidbody r = GetComponent<Rigidbody>();

            r.velocity = new Vector3(horizonVel, 0, 4);

            if ((Input.GetKey(KeyCode.RightArrow)) && (laneNum < 5) && (controlLocked == "n"))
            {
                horizonVel = 4;
                StartCoroutine(StopSlide());
                laneNum += 2;
                controlLocked = "y";
            }
            if ((Input.GetKey(KeyCode.LeftArrow)) && (laneNum > -1) && (controlLocked == "n"))
            {
                horizonVel = -4;
                StartCoroutine(StopSlide());
                laneNum -= 2;
                controlLocked = "y";
            }
        }
        
       
    }

    // When player enter in collision with gameobject
    private void OnCollisionEnter(Collision other)
    {
        Rigidbody r = GetComponent<Rigidbody>();

        //Quand le rigidbody entre en collision avec le mur
        if (other.gameObject.tag == "wall")
        {
            Destroy(gameObject);
            GameManager.zVelocityAdj = 1;
            GameManager.levelCompStatus = "Fail";
        }

        

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Exit")
        {
            GameManager.levelCompStatus = "Cleared !";
            SceneManager.LoadScene("LevelClear1");
        }
        if (other.gameObject.name == "Exit2")
        {
            GameManager.levelCompStatus = "Cleared !";
            SceneManager.LoadScene("LevelClear2");
        }

        if (other.gameObject.name == "Coin")
        {
            Destroy(other.gameObject);
            GameManager.coinTotal += 1;
        }
    }

    IEnumerator StopSlide()
    {
        yield return new WaitForSeconds(.5f);
        horizonVel = 0;
        controlLocked = "n";
    }
}
