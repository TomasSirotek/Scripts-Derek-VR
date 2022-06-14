using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject nagent;
    public GameObject goalObject;
    public GameObject carPolice;
    public AudioClip SireneAudio;
    void SpawnAgent()
    {
        GameObject na = (GameObject)Instantiate(nagent, this.transform.position, Quaternion.identity);
        na.GetComponent<agentWalk>().goal = goalObject.transform;



    }

    void SpawnCar()
    {
        Instantiate(carPolice, transform.position, transform.rotation);

    }
    void PlaySiren()
    {
        AudioSource.PlayClipAtPoint(SireneAudio, transform.position);

    }


    void Update()
    {
        if (GameManager.Instance.SpawnEnemies && GameManager.Instance.NumberOfAgents < 5 && GameManager.Instance.NumberOfPolice == 0)
        {
            SpawnAgent();
            SpawnAgent();
            SpawnAgent();
            SpawnAgent();

            GameManager.Instance.NumberOfAgents++;
            GameManager.Instance.NumberOfAgents++;
            GameManager.Instance.NumberOfAgents++;
            GameManager.Instance.NumberOfAgents++;

            SpawnCar();
            GameManager.Instance.NumberOfPolice++;

            PlaySiren();




        }
        {


        }
    }
}



