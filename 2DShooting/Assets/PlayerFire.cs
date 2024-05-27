using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 사용자가 마우스 왼쪽 버튼을 누르면 총알을 발사한다.
// (Bullet prefab을 읽어와서 총구 위치에 가져다 놓고싶다.)

public class PlayerFire : MonoBehaviour
{

    //총알공장
    public GameObject bulletFactory;

    //총구위치
    public GameObject firePosition;

    //총알개수
    public int bulletCount = 1;

    //총알발사 가능 체크
    public bool canFire = true;

    //총알간격
    float spacing = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. 만약 사용자가 마우스 왼쪽버튼을 누르면
        if (Input.GetButtonDown("Fire1"))
        {
            if (canFire == true)
            {
                // 총알의 총 간격 = (총알의 수 -1) * 총알간격
                float totalSpacing = (bulletCount - 1) * spacing;

                // 총알의 최초위치 = x: -(총알의 총 간격 / 2) y: 0 z: 0
                Vector3 firstPos = firePosition.transform.position - new Vector3(totalSpacing * 0.5f, 0, 0);
                // 총알의 총 개수만큼 반복시행
                for (int i = 0; i < bulletCount; i++)
                {
                    // 총알 만들고
                    GameObject bullet = Instantiate(bulletFactory);

                    bullet.transform.position = firstPos + new Vector3(i * 1.5f, 0, 0);

                }
                // 2. 총알공장에서 총알을 만들어서
                // 3. 총구 위치에 가져다 놓고 싶다.

                //bullet.transform.position = firePosition.transform.position;
            }
        }
        
    }
}
