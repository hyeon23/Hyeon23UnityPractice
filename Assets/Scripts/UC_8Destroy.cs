using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UC_8Destroy : MonoBehaviour
{
    [SerializeField]
    private GameObject playerObject;
    private SpriteRenderer spriteRenderer;
    private Vector2 limitMin = new Vector2(-7.5f, -4.5f);
    private Vector2 limitMax = new Vector2(7.5f, 4.5f);
    private float time;
    //Destroy�Լ��� ���� ������Ʈ �Ӹ� �ƴ϶� ������Ʈ���� ���� �����ϴ�.
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        //Ư�� ���� ������Ʈ�� ������ ������Ʈ ����
        Destroy(playerObject.GetComponent<PlayerController>());
        //���� ������Ʈ ����
        Destroy(playerObject);
        //Ư�� �ð� �� ������Ʈ ����
        //Destroy(playerObject, time);

        //������Ʈ�� Ư�� ��ġ�� ����� ��, ����
        if (transform.position.x < limitMin.x || transform.position.x > limitMax.x || transform.position.y < limitMin.y || transform.position.y > limitMax.y)
        {
            Destroy(gameObject);
        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        StartCoroutine("HitAnimation");
    }
    private IEnumerator HitAnimation()
    {
        spriteRenderer.color = Color.red;

        yield return new WaitForSeconds(0.1f);

        spriteRenderer.color = Color.white;
    }
}
