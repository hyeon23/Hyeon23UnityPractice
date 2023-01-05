using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UC_4ScriptsBase : MonoBehaviour
{
    //0. MonoBehaviour�� ��ӹ����� GameObject�� Component�� ������ �� ����
    //-��ӹ��� ���ϸ� Component�� �������� ����

    //����
    //Awake
    //OnEnable
    //Start
    private void Awake()
    {
        //������Ʈ�� �����Ǿ� Component�� Script�� ������ �� ȣ���
        Debug.Log("Awake");
    }
    private void OnEnable()
    {
        //Ȱ�����°� �Ǹ� ȣ��
        Debug.Log("OnEnable");
    }
    private void Start()
    {
        //Awake�� �ٸ��� ���� ������Ʈ�� Ȱ��ȭ�� ��� Update ȣ�� ���� �� �ѹ� ȣ��
        Debug.Log("Start");
    }

    //������Ʈ
    //Fixed Update
    //Update
    //LateUpdate
    private void FixedUpdate()
    {
        //�����Ӱ� ������� ������ ���ϴ� ���
        Debug.Log("FixedUpdate");
    }
    int count = 0;
    private void Update()
    {
        count++;
        if(count > 100)
        {
            Destroy(gameObject);//gameObject�� ��ũ��Ʈ�� ������ ������Ʈ�� ����
        }
        else
        {
            Debug.Log("Update");
        }
    }
    private void LateUpdate()
    {
        //����� �ݿ��� �� ó���ϰ� ���� �۾�
        Debug.Log("LateUpdate");
    }

    //�Ҹ�
    //OnDisable
    //OnDestroy
    private void OnDisable()
    {
        //�� Ȱ�����°� �Ǹ� ȣ��
        Debug.Log("OnDisable");
    }
    private void OnDestroy()
    {
        //Monobehavior�� ���ŵǸ������Ʈ�� �������� ȣ��
        Debug.Log("OnDestroy");
    }
}
