using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    Rigidbody go;
    [Header("速度")]
    [Range(3, 120)]
    public float speed = 3;
    [Header("跳躍")]
    [Range(3, 120)]
    public float jump = 3;
    [Header("是否接觸地面")]
    public bool isGround;


    // Use this for initialization
    void Start()
    {
        go = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
        Jump();
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGround = true;
        Debug.Log("touch" + collision.gameObject);
    }

    private void Walk()
    {
        go.AddForce(new Vector3(speed * Input.GetAxis("Horizontal"), 0, 0));
        go.AddForce(new Vector3(0, 0, speed * Input.GetAxis("Vertical")));

    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            isGround = false;
            go.AddForce(new Vector3(0, jump, 0));
        }

    }
}
