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
        timeAfterSpawn = 0;

        //ź�� ���� ������ spawnRateMin�� spawnRateMax ���̿��� ���� �� ����
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);



        //PlayerController ������Ʈ�� ���� ���� ������Ʈ�� ã�Ƽ� �� ������Ʈ�� ��ġ���� ������
        target = FindObjectOfType<PlayerController>().transform;
    }

    void Update()
    {


        Instantiate(BulletPrefab);
    }
}
