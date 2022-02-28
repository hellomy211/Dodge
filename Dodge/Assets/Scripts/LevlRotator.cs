using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevlRotator : MonoBehaviour
{
    public float rotationSpeed = 60f;

    void Update()
    {
        //Rotate 메서드는 입력값(매개변수)로 X , Y, Z축에 대한 회전값을 받고, 현재 회전 상태에서 입력된 값만큼 상대적으로 더 회전함
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
