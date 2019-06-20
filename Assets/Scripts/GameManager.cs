using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static int coinTotal = 0;
    public static float timeTotal = 0;
    public static float zVelocityAdj = 1;
    public float waitToLoad = 0;
    public static string levelCompStatus = "";

    public Transform blockSimple;
    public Transform blockHole1;
    public Transform blockHoleM1;
    public Transform blockHole2;
    public Transform blockHoleM2;


    public int zScenePosition;

    public Transform coinObj;
    public Transform obstObj;
    public Transform wallObj;

    public int randNumb;

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
            timeTotal += Time.deltaTime;

            if (levelCompStatus == "Fail")
            {
                waitToLoad += Time.deltaTime;
                SceneManager.LoadScene("GameOver");

            }

            if (waitToLoad > 1)
            {
                SceneManager.LoadScene("LevelClear1");
            }
        }
    }
}
