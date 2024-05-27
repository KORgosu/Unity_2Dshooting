using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//  Y �������� ��ũ���Ѵ�. (Vector2)

public class Background : MonoBehaviour
{
    Material mat;
    public float speed = 0.1f;
    public float finalSpeed = 0;
    // MeshRenderer > Material > OffsetY
    // Start is called before the first frame update
    void Start()
    {
        // �¾�� MeshRenderer�� �����ͼ�
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        // �� �ȿ� �ִ� meterial �� ����ϰ�ʹ�.
        mat = renderer.material;

        finalSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        // ��ư��鼭 Material �� OffsetY ���� ������Ű�� �ʹ�.
        mat.mainTextureOffset += Vector2.up * finalSpeed * Time.deltaTime;
    }

    public void ScrollSpeedUp(float increaseRate)
    {
        // ������� �Է¹��� �Ű������� ���� ���� ���밪���� ȯ���Ѵ�.
        float rate = increaseRate * 0.01f;

        // �⺻ ��ũ�� �ӵ��� �ݿ�
        finalSpeed += speed * rate;
    }
}
