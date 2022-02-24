using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //이동에 사용할 리지드바디 컴포넌트
    public Rigidbody PlayerRigidbody;
    //이동 속력
    public float speed = 4f;

    public GameObject Player;

    void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
       float xInput = Input.GetAxis("Horizontal");
       float zInput = Input.GetAxis("Vertical");
        
    }

    void DirectInput()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            PlayerRigidbody.AddForce(0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            PlayerRigidbody.AddForce(0f, 0f, -speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            PlayerRigidbody.AddForce(-speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            PlayerRigidbody.AddForce(speed, 0f, 0f);
        }

    }



    void Die()
    {
        Player.SetActive(false);
        gameObject.SetActive(false);
    }

}
