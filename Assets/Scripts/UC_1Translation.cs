using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UC_1Translation : MonoBehaviour
{
    //1. �̵�(Translation)
    float timer = 0f;
    void Update()
    {
        timer += Time.deltaTime;
        //movePosition1(new Vector3(0f, Mathf.Cos(timer), 0f));
        moveTranslate1(new Vector3(0f, Mathf.Cos(timer), 0f));
    }
    //1-1. transform.position
    //-�ش� ��ġ�� �����̵�
    private void movePosition1(Vector3 newPos)
    {
        transform.position = newPos;
    }
    //1-2. transform.Translate()
    //-�ش� Vector��ŭ�� ���� �ִ� ��
    //-60�����ӵ��� 1�� �ɶ����� ��������� ���� �ش�.
    private void moveTranslate1(Vector3 moveVec)
    {
        transform.Translate(moveVec);
    }
}
