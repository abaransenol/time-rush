using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleManager : MonoBehaviour
{
    Animator animations;

    // Start is called before the first frame update
    void Start()
    {
        animations = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        animations.SetBool("is_touched",true);
    }
    void Destroy1()
    {
        Destroy(gameObject);
    }
}
