using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UC_3Scaling : MonoBehaviour
{
    //3.Scale
    //3-0.Local Scale ��� ����
    //-LocalScale => Local ��ǥ��󿡼� ũ�� ��ȯ
    //-lossyScale => World ��ǥ��󿡼� ũ�� ��ȯ
    float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        Scaling(new Vector3(Mathf.Cos(timer), Mathf.Cos(timer), Mathf.Cos(timer)));
    }

    public void Scaling(Vector3 newScale)
    {
        transform.localScale = newScale;
    }
}
