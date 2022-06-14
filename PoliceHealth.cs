using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PoliceHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    public float curHealth = 0;
    public bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
        alive = true;

    }

    public void TakeDamage(float deductHealth)
    {

        if (!alive)
        {
            return;
        }

        if (curHealth <= 0)
        {
            curHealth = 0;
            alive = false;

            EnemyDead();

        }
    curHealth -= deductHealth;

    }
    void EnemyDead()
    {
        Destroy(gameObject);
    }
}
