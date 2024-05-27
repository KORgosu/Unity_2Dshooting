using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �����ð����� �����忡�� ���� ���� �� ��ġ�� ������ ����ʹ�
public class EnemyManager : MonoBehaviour
{
    // ������
    public GameObject enemyFactory;
    // - ����ð�
    float currentTime;
    // - �����ð�
    public float creatTime = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. �ð��� �帣�ٰ�
        currentTime += Time.deltaTime;
        // 2. �����ð��� �Ǹ�
        if (currentTime > creatTime)
        {
            GameObject enemy = Instantiate(enemyFactory);
            enemy.transform.position = transform.position;
            currentTime = 0;
        }
        // 3. �� ���忡�� ���� ����
        // 4. �� ��ġ�� ������ ���´�.
        // 5. ����ð��� 0���� �ʱ�ȭ
    }
}
