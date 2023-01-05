using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UC_7Instantiate : MonoBehaviour
{
    [SerializeField]
    private GameObject boxPrefab;
    [SerializeField]
    private GameObject[] prefabArray;
    [SerializeField]
    private int objectSpawnCount = 30;
    [SerializeField]
    private Transform[] spawnPointArray;
    private void Awake()
    {
        Instantiate(boxPrefab);
        Instantiate(boxPrefab);

        Instantiate(boxPrefab, new Vector3(3, 3, 0), Quaternion.identity);//Prefab, ������ġ, ���������� �����ϴ� ����
        //Quterniono.identity = ȸ�� �� (0, 0, 0)

        //Euler: �츮�� ���� �ƴ� 0 ~ 360�� ���� ǥ�����
        //����ӵ��� ������, ������ ������ �߻�

        //Quternion: 4����, 3���� ���Ϳ�ҿ� 1���� ��Į���ҷ� ����(4���� -1 ~ 1 ��)
        //������ ������ ����ǥ���� ����� => ���Ϸ��� ���ʹϾ����� �����ϴ� �Լ� Quaternion.Euler
        Quaternion EuToQua = Quaternion.Euler(0,0,0);

        //transform.rotation: ���ʹϾ��� �̿��� ȸ������
        //transform.localScale: ���Ϸ��� �̿��� Scale��

        //Instantiate�� ��ȯ ���� GameObject�̱� ������ GameObject�� ������ ���� �� ����
        GameObject clone = Instantiate(boxPrefab, Vector3.zero, EuToQua);
        //��� ������ ���� ������Ʈ�� �̸� ����
        clone.name = "Box01";
        //��� ������ ���� ������Ʈ�� ���� ����
        clone.GetComponent<SpriteRenderer>().color = Color.black;
        //��� ������ ���� ������Ʈ�� ��ġ ����
        clone.transform.position = new Vector3(2, 1, 0);
        //��� ������ ���� ������Ʈ�� ũ�� ����
        clone.transform.localScale = new Vector3(3, 2, 1 );

        //Instantiate Ȱ�� ����
        //1. 10���� ������Ʈ�� �ܻ��� ����� ȸ�� �̵��ϴ� ���� �̹���
        for(int i = 0; i < 10; i++)
        {
            Vector3 position = new Vector3(-4.5f + i, 0, 0);
            Quaternion rotation = Quaternion.Euler(0, 0, i * 10);
            Instantiate(boxPrefab, position, rotation);
        }

        //2. 10 X 10 ����� ���� ������ �� ����
        for (int y = 0; y < 10; y++)
        {
            for(int x = 0; x < 10; x++)
            {   
                if(x == y)//\
                    continue;
                if (x == y || x + y == 9)//X
                    continue;
                if (x + y == 4 || x - y == 5 || y - x == 5 || x + y == 14)//������
                    continue;
                Vector3 position = new Vector3(-4.5f + x, 4.5f - y, 0);
                Instantiate(boxPrefab, position, Quaternion.identity);
            }
        }

        //3. ���� �������� ���� ������Ʈ ����
        for(int i = 0; i < 10; i++)
        {
            int index = Random.Range(0, prefabArray.Length);
            Vector3 position = new Vector3(-4.5f + i, 0, 0);
            Instantiate(prefabArray[index], position, Quaternion.identity);
        }

        //4. ���� �Լ��� ���� ������ ��ġ�� Prefab ����
        for(int i = 0; i < objectSpawnCount; i++)
        {
            int index = Random.Range(0, prefabArray.Length);
            float x = Random.Range(-7.5f, 7.5f);
            float y = Random.Range(-4.5f, 4.5f);
            Vector3 position = new Vector3(x, y, 0);
            Instantiate(prefabArray[index], position, Quaternion.identity);
        }

        //5. ���� Ư�� ��ġ���� ���� ������ �����ϱ�
        for(int i = 0; i < objectSpawnCount; i++)
        {
            int prefabIndex = Random.Range(0, prefabArray.Length);
            int spawnIndex = Random.Range(0, spawnPointArray.Length);

            Vector3 position = spawnPointArray[spawnIndex].position;
            GameObject C = Instantiate(prefabArray[prefabIndex], position, Quaternion.identity);
        }
    }

    void Update()
    {
        
    }
}
