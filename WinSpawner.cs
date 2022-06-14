using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSpawner : MonoBehaviour
{

    public GameObject table;
    public GameObject restartButton;


    // Start is called before the first frame update
    void Start()
    {

    }
    void SpawnWin()
    {
        Instantiate(table, transform.position, transform.rotation);
        Instantiate(restartButton, transform.position, transform.rotation);



    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.SpawnReward && GameManager.Instance.NumberOfStations == 0)
        {
            SpawnWin();
            GameManager.Instance.numberOfStations++;
        }
    }

}
