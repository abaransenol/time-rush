using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Manager : MonoBehaviour
{
    public BoxCollider2D fireCollider;
    void Start()
    {
    }


    void EnableCollider()
        {
            fireCollider.enabled = true;
        }
    
    void DisableCollider()
        {
            fireCollider.enabled = false;
        }
    
}
