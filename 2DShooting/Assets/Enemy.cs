using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// �¾�� 30% Ȯ���� �÷��̾� ����, ������ Ȯ���� �Ʒ�����
// ��ư��鼭 �� �������� �̵�
public class Enemy : MonoBehaviour
{
    // - ������ �¾�� ����
    Vector3 dir;
    // - �ӷ�
    public float speed = 5;
    // Start is called before the first frame update
    GameObject target;
    void Start()
    {
        // �÷��̾� ����
        target = GameObject.Find("Player");


        // �¾ ��
        // 1. 30% Ȯ���� �÷��̾� ����, ������ Ȯ���� �Ʒ���������
        int result = UnityEngine.Random.Range(0, 10);
        if (result < 3)
        {
            
            // dir = target - me
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
        else
        {
            // �Ʒ�����
            dir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }

    public GameObject explosionFactory;
    private void OnCollisionEnter(Collision other)
    {
        // 1. �ð�ȿ�� ���忡�� �ð�ȿ���� ����
        GameObject explosion = Instantiate(explosionFactory);
        // 2. �� ��ġ�� ������ ���� �ʹ�.
        explosion.transform.position = transform.position;
        // ���� �ε��� ����� �Ѿ��̾��ٸ� �÷��̾� ������Ʈ�� PlayerMove.AddScore �Լ� ȣ��
        if (other.gameObject.name.Contains("Bullet")) // �Ѿ˿� �ε�������
        {
            PlayerMove player = target.GetComponent<PlayerMove>();
            player.AddScore(1);
        }

        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
