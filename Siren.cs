using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Siren : MonoBehaviour
{
    // Start is called before the first frame update
    [ SerializeField ] Light redLight;
    [ SerializeField ] Light blueLight;

     [ SerializeField ] int speed;

    private Vector3 redTemp;
    private Vector3 blueTemp;

    // Update is called once per frame
    void Update()
    {
       redTemp.y += speed * Time.deltaTime;
       blueTemp.y -= speed * Time.deltaTime;

       redLight.transform.eulerAngles  = redTemp;
       blueLight.transform.eulerAngles  = blueTemp;
    }
}
