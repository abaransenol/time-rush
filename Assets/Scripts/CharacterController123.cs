using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController123 : MonoBehaviour
{
    Rigidbody2D charphysic;
    public float Boost = 1f;
    public float jumpspeed = 1f;
    bool facingright = true;
    bool isgrounded = false;
    Animator animations;
    // Start is called before the first frame update
    void Start()
    {
        charphysic = GetComponent<Rigidbody2D>();
        animations = GetComponent<Animator>();
    }
    void Awake()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Horizontalmove();
        if (charphysic.velocity.x < 0 && facingright) 
        {
            FlipFace();
        }  
        else if (charphysic.velocity.x >0 && !facingright)
        {
            FlipFace();
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            Jump();
        }
    }
    void Horizontalmove()
    {
        charphysic.velocity = new Vector2(Input.GetAxis("Horizontal") * Boost, charphysic.velocity.y);
        animations.SetFloat("CharSpeed", Mathf.Abs(charphysic.velocity.x));
    }
    void FixedUpdate()
    {
        
    }
    void FlipFace()
    {
        facingright = !facingright;
        Vector3 TempLocScal = transform.localScale;
        TempLocScal.x *= -1;
        transform.localScale = TempLocScal;
    }
    void Jump()
    {
        charphysic.AddForce(new Vector2(0f,jumpspeed));

    }
    void OnGroundCheck()
    {
        //isgrounded = Physics2D.OverlapCircle();
    }
}
