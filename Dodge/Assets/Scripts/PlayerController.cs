using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //�̵��� ����� ������ٵ� ������Ʈ
    public Rigidbody PlayerRigidbody;
    //�̵� �ӷ�
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

        //���� �̵� �ӵ��� �Է°��� �̵� �ӷ��� ����� ����
        float xspeed = xInput * speed;
        float zspeed = zInput * speed;


        //vector3 �ӵ��� (xSpeed, 0f . zSpeed) ����
        Vector3 newVelocity = new Vector3(xspeed, 0, zspeed);
        //������ٵ��� �ӵ��� newVelocity�� �Ҵ�
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
        //���� �����ϴ� GameMananger Ÿ���� ������Ʈ�� ã�Ƽ� ��������
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }

}
