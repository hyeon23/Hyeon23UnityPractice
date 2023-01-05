using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    [SerializeField]
    private float       speed = 5.0f;           //�̵��ӵ�
    [SerializeField]
    private float       jumpForce = 8.0f;       //���� ũ��
    private Rigidbody2D rigid2D;
    [HideInInspector]
    public bool         isLongJump = false;     //����, ���� üũ

    [SerializeField]
    private LayerMask           groundLayer;        //�ٴ� �浹 üũ�� ���� ���̾�
    private CapsuleCollider2D   capsuleCollider2D;  //������Ʈ�� �浹 ���� ������Ʈ
    private bool                isGrounded;         //�ٴ� üũ
    private Vector3             footPosition;       //�� ��ġ

    [SerializeField]
    private int         maxJumpCount = 2;//�ִ� ���� ����
    private int         currentJumpCount = 0;//���� ������ ���� Ƚ��

    private void Awake()
    {
        rigid2D             = GetComponent<Rigidbody2D>();
        capsuleCollider2D   = GetComponent<CapsuleCollider2D>();
    }


    private void FixedUpdate()//���� ���� ����
    {
        Bounds bounds       = capsuleCollider2D.bounds;//Collider�� ������ ǥ�����ִ� bound
        capsuleCollider2D   = GetComponent<CapsuleCollider2D>();
        footPosition = new Vector2(bounds.center.x, bounds.min.y);
        isGrounded = Physics2D.OverlapCircle(footPosition, 0.1f, groundLayer);
        //OverlapCircle(Vector2 position, float radius, LayerMask layer): position ��ġ�� ������ ��ŭ�� �� �浹������ ������ ���� �浹�ϴ� ������Ʈ�� collider2D ������Ʈ�� ����

        if (isGrounded == true && rigid2D.velocity.y <= 0)
        {
            currentJumpCount = maxJumpCount;
        }
        //gravityScale�� ���� ����
        if(isLongJump && rigid2D.velocity.y > 0)
        {
            rigid2D.gravityScale = 1.0f;
        }
        else
        {
            rigid2D.gravityScale = 2.5f;
        }
    }

    private void OnDrawGizmos()//�����̴� ������ �ʰ�, Scene �信���� ���̴� Ray���� ������Ʈ�� �׸� �� �ִ� �Լ�
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(footPosition, 0.1f);
    }

    public void Move(float x)
    {
        rigid2D.velocity = new Vector2(x * speed, rigid2D.velocity.y);
    }

    public void Jump()
    {
        //if(isGrounded == true)
        if(currentJumpCount > 0)
        {
            rigid2D.velocity = Vector2.up * jumpForce;
            currentJumpCount--;
        }
    }
}
