using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UC_2Rotation : MonoBehaviour
{
    //2.Rotation
    //2-0.Euler Angle ==> Quternion���� ��ȯ�� ���
    //-Gymbol lock ������ �ذ��ϱ� ���� Unity Engine ���������� Quternion ���

    float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        //RotateGameObject(new Vector3(0f, (Mathf.Cos(timer) * 0.5f + 0.5f) * 360f, 0f));
        //RotateControlForward(new Vector3(Mathf.Cos(timer), 0f, Mathf.Sin(timer)));
        //LookPosition(new Vector3(Mathf.Cos(timer), 0f, Mathf.Sin(timer)));
        LookGameObject(lookingObject);
    }
    //2-1. Euler�� ����� Rotation ���� ȸ�� 
    public void RotateGameObject(Vector3 rotation)
    {
        transform.rotation = Quaternion.Euler(rotation);
    }
    //2-2. �ٶ󺸴� ������ �������ִ� LookAt �Լ�
    public void LookPosition(Vector3 pos)
    {
        transform.LookAt(pos);
    }

    [SerializeField]
    private Transform lookingObject;
    //2-2-1. LookGameObject �Լ�'
    //-ȸ�� or ������ ��� <����>
    public void LookGameObject(Transform lookobj)
    {
        transform.LookAt(lookobj);
    }

    //2-3. forward�� ����� ȸ��
    //-forward�� �ٶ󺸰��� �ϴ� �������� �����ϸ�, ȭ���� ������ ���ϰ� ����
    public void RotateControlForward(Vector3 dir)
    {
        transform.forward = dir;
    }
}
