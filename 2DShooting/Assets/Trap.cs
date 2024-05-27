using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{

    // Ʈ���ſ� �浹���� ��
    // �÷��̾ ���� PlayerFire ��ũ��Ʈ�� �����´�.
    // ���� �÷��̾ �´ٸ� ������ PlayerFire�� �Ѿ� �߻� ���ɺ����� False�� �ٲ۴�.

    // Ʈ���ŷκ��� ���������� ��
    // �÷��̾ ���� PlayerFire ��ũ��Ʈ�� �����ͼ�
    // ���� �÷��̾ �´ٸ�, ������ PlayerFire�� �Ѿ� �߻� ���ɺ����� true�� �ٲ۴�.


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
