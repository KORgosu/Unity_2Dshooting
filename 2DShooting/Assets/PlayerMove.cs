using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 사용자의 입력에 따라 플레이어를 이동하고 싶다.

public class PlayerMove : MonoBehaviour
{

    public float speed = 5;
    // Start is called before the first frame update

    //스코어 점수
    public int score = 0;
    public Background bg;
    int checkPoint = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. 사용자의 입력을 받는다
        // 2. 방향을 만든다.
        // 3. 그 방향으로 플레이어를 이동시킨다.

        float h = Input.GetAxis("Horizontal"); // right : -1~1
        float v = Input.GetAxis("Vertical"); // up : -1~1
        float runspeed;

        Vector3 dir = Vector3.right * h + Vector3.up * v;

        //문제 발생 (대각선 이동시 루트2의 크기를 가지고 있어 속력이 더 빠름)
        //정규화 필요

        dir.Normalize();

        if (Input.GetKey(KeyCode.LeftShift))
        {
            runspeed = speed * 2;
        }
        else
        {
            runspeed = speed;
        }
        
        //이동공식 P = P0 + vt
        transform.position += dir * runspeed * Time.deltaTime;

        if (score % 10 == 0 && score > checkPoint)
        {
            bg.ScrollSpeedUp(20.0f);
            checkPoint = score;
        }
    }

    // 점수 획득을 위한 함수
    public void AddScore(int point)
    {
        // 매개변수 포인트를 통해서 받은 값을 스코어 변수에 누적
        score += point;
    }
}
