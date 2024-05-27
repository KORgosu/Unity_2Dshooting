using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ����ڰ� ���콺 ���� ��ư�� ������ �Ѿ��� �߻��Ѵ�.
// (Bullet prefab�� �о�ͼ� �ѱ� ��ġ�� ������ ����ʹ�.)

public class PlayerFire : MonoBehaviour
{

    //�Ѿ˰���
    public GameObject bulletFactory;

    //�ѱ���ġ
    public GameObject firePosition;

    //�Ѿ˰���
    public int bulletCount = 1;

    //�Ѿ˹߻� ���� üũ
    public bool canFire = true;

    //�Ѿ˰���
    float spacing = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. ���� ����ڰ� ���콺 ���ʹ�ư�� ������
        if (Input.GetButtonDown("Fire1"))
        {
            if (canFire == true)
            {
                // �Ѿ��� �� ���� = (�Ѿ��� �� -1) * �Ѿ˰���
                float totalSpacing = (bulletCount - 1) * spacing;

                // �Ѿ��� ������ġ = x: -(�Ѿ��� �� ���� / 2) y: 0 z: 0
                Vector3 firstPos = firePosition.transform.position - new Vector3(totalSpacing * 0.5f, 0, 0);
                // �Ѿ��� �� ������ŭ �ݺ�����
                for (int i = 0; i < bulletCount; i++)
                {
                    // �Ѿ� �����
                    GameObject bullet = Instantiate(bulletFactory);

                    bullet.transform.position = firstPos + new Vector3(i * 1.5f, 0, 0);

                }
                // 2. �Ѿ˰��忡�� �Ѿ��� ����
                // 3. �ѱ� ��ġ�� ������ ���� �ʹ�.

                //bullet.transform.position = firePosition.transform.position;
            }
        }
        
    }
}
