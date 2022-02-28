using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject BulletPrefab;
    //�ּ� ���� �ֱ�
    public float spawnRateMin = 0.5f;
    //�ִ� ���� �ֱ�
    public float spawnRateMax = 3f;
    

    //���� ���� �ֱ�
    private float spawnRate;
    //�߻��� ���
    private Transform target;
    //�ֱ� ���� �������� ���� �ð�
    private float timeAfterSpawn;


    void Start()
    {
        //�ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        timeAfterSpawn = 0f;

        //ź�� ���� ������ spawnRateMin�� spawnRateMax ���̿��� ���� �� ����
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);

        //PlayerController ������Ʈ�� ���� ���� ������Ʈ�� ã�Ƽ� �� ������Ʈ�� ��ġ���� ������
        target = FindObjectOfType<PlayerController>().transform;
    }

    void Update()
    {
        //TimeAfterSpawn ����
        timeAfterSpawn += Time.deltaTime;

        //�ֱ� ���� ������������ ������ �ð��� ���� �ֱ⺸�� ũ�ų� ���ٸ�
        if(timeAfterSpawn >= spawnRate)
        {
            //bulletPrefab�� �������� transform.position��ġ�� transform.rotation ȸ������ ����
            GameObject bullet = Instantiate(BulletPrefab, transform.position, transform.rotation);

            //������ bullet ���� ������Ʈ�� ���� ������ target�� ���ϵ��� ȸ��
            bullet.transform.LookAt(target);

            //������ ���� ������ �ٽ� ����
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);

            //������ �ð��� ����
            timeAfterSpawn = 0f;
        }




    }

}
