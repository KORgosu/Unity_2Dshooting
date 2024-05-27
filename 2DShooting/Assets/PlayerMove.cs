using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ������� �Է¿� ���� �÷��̾ �̵��ϰ� �ʹ�.

public class PlayerMove : MonoBehaviour
{

    public float speed = 5;
    // Start is called before the first frame update

    //���ھ� ����
    public int score = 0;
    public Background bg;
    int checkPoint = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. ������� �Է��� �޴´�
        // 2. ������ �����.
        // 3. �� �������� �÷��̾ �̵���Ų��.

        float h = Input.GetAxis("Horizontal"); // right : -1~1
        float v = Input.GetAxis("Vertical"); // up : -1~1
        float runspeed;

        Vector3 dir = Vector3.right * h + Vector3.up * v;

        //���� �߻� (�밢�� �̵��� ��Ʈ2�� ũ�⸦ ������ �־� �ӷ��� �� ����)
        //����ȭ �ʿ�

        dir.Normalize();

        if (Input.GetKey(KeyCode.LeftShift))
        {
            runspeed = speed * 2;
        }
        else
        {
            runspeed = speed;
        }
        
        //�̵����� P = P0 + vt
        transform.position += dir * runspeed * Time.deltaTime;

        if (score % 10 == 0 && score > checkPoint)
        {
            bg.ScrollSpeedUp(20.0f);
            checkPoint = score;
        }
    }

    // ���� ȹ���� ���� �Լ�
    public void AddScore(int point)
    {
        // �Ű����� ����Ʈ�� ���ؼ� ���� ���� ���ھ� ������ ����
        score += point;
    }
}
