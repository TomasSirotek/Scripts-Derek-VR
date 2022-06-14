using System.Collections;
using UnityEngine;

public class DamageWeapon : MonoBehaviour
{
    public float damage = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {


        other.gameObject.GetComponent<PoliceHealth>().TakeDamage(damage);




    }
}
