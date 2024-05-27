using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 태어날때 30% 확률로 플레이어 방향, 나머지 확률로 아래방향
// 살아가면서 그 방향으로 이동
public class Enemy : MonoBehaviour
{
    // - 방향은 태어날때 정함
    Vector3 dir;
    // - 속력
    public float speed = 5;
    // Start is called before the first frame update
    GameObject target;
    void Start()
    {
        // 플레이어 방향
        target = GameObject.Find("Player");


        // 태어날 때
        // 1. 30% 확률로 플레이어 방향, 나머지 확률로 아래방향으로
        int result = UnityEngine.Random.Range(0, 10);
        if (result < 3)
        {
            
            // dir = target - me
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
        else
        {
            // 아래방향
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
        // 1. 시각효과 공장에서 시각효과를 만들어서
        GameObject explosion = Instantiate(explosionFactory);
        // 2. 내 위치에 가져다 놓고 싶다.
        explosion.transform.position = transform.position;
        // 만일 부딪힌 대상이 총알이었다면 플레이어 오브젝트의 PlayerMove.AddScore 함수 호출
        if (other.gameObject.name.Contains("Bullet")) // 총알에 부딪혔으면
        {
            PlayerMove player = target.GetComponent<PlayerMove>();
            player.AddScore(1);
        }

        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
