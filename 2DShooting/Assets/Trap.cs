using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{

    // 트리거에 충돌했을 때
    // 플레이어가 가진 PlayerFire 스크립트를 가져온다.
    // 만일 플레이어가 맞다면 가져온 PlayerFire에 총알 발사 가능변수를 False로 바꾼다.

    // 트리거로부터 빠져나갔을 때
    // 플레이어가 가진 PlayerFire 스크립트를 가져와서
    // 만일 플레이어가 맞다면, 가져온 PlayerFire에 총알 발사 가능변수를 true로 바꾼다.


    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerFire pFire = other.GetComponent<PlayerFire>();

        if (pFire)
        {
            pFire.canFire = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PlayerFire pFire = other.GetComponent<PlayerFire>();

        if (pFire)
        {
            pFire.canFire = true;
        }
    }
}
