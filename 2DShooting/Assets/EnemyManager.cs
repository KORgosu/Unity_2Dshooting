using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 일정시간마다 적공장에서 적을 만들어서 내 위치에 가져다 놓고싶다
public class EnemyManager : MonoBehaviour
{
    // 적공장
    public GameObject enemyFactory;
    // - 현재시간
    float currentTime;
    // - 생성시간
    public float creatTime = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. 시간이 흐르다가
        currentTime += Time.deltaTime;
        // 2. 생성시간이 되면
        if (currentTime > creatTime)
        {
            GameObject enemy = Instantiate(enemyFactory);
            enemy.transform.position = transform.position;
            currentTime = 0;
        }
        // 3. 적 공장에서 적을 만들어서
        // 4. 내 위치에 가져다 놓는다.
        // 5. 현재시간을 0으로 초기화
    }
}
