using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//  Y 방향으로 스크롤한다. (Vector2)

public class Background : MonoBehaviour
{
    Material mat;
    public float speed = 0.1f;
    public float finalSpeed = 0;
    // MeshRenderer > Material > OffsetY
    // Start is called before the first frame update
    void Start()
    {
        // 태어날때 MeshRenderer를 가져와서
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        // 그 안에 있는 meterial 을 기억하고싶다.
        mat = renderer.material;

        finalSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        // 살아가면서 Material 의 OffsetY 값을 증가시키고 싶다.
        mat.mainTextureOffset += Vector2.up * finalSpeed * Time.deltaTime;
    }

    public void ScrollSpeedUp(float increaseRate)
    {
        // 백분율로 입력받은 매개변수의 값을 실제 적용값으로 환산한다.
        float rate = increaseRate * 0.01f;

        // 기본 스크롤 속도에 반영
        finalSpeed += speed * rate;
    }
}
