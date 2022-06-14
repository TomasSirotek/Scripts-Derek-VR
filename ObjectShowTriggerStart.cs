using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectShowTriggerStart : MonoBehaviour
{
   public void ToggleVisibility()
    {
       Renderer rend = gameObject.GetComponent<Renderer>();

       if(!rend.enabled)
        rend.enabled= true;
   
    }

}
