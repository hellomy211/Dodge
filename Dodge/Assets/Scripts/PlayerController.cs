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

        //실제 이동 속도를 입력값과 이동 속력을 사용해 결정
        float xspeed = xInput * speed;
        float zspeed = zInput * speed;


        //vector3 속도를 (xSpeed, 0f . zSpeed) 생성
        Vector3 newVelocity = new Vector3(xspeed, 0, zspeed);
        //리지드바디의 속도에 newVelocity를 할당
        PlayerRigidbody.velocity = newVelocity;


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



    public void Die()
    {
        Player.SetActive(false);
        //씬에 존재하는 GameMananger 타입의 오브젝트를 찾아서 가져오기
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }

}
