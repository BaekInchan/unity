using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed;

    private bool isStop;

    void Start()
    {
        rotSpeed = 0f;
    }

    private void Update()
    {
        transform.Rotate(Vector3.forward * rotSpeed);
        //transform.Rotate(0f, 0f, rotSpeed);
        

        //  마우스 왼쪽 버튼을 눌렀을 때 회전하는 기능
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = 5f;
        }

        // 키보드 스페이스 버튼을 눌렀을 때 정지하는 기능
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }
        // rotSpeed = rotSpeed * 0.98f;
        if (isStop == true)
        {
            rotSpeed *= 0.98f; // 현재속도에서 특정 값만큼 줄이는 기능
            if (rotSpeed < 0.01f)
            {
                rotSpeed = 0f;
                isStop = false;
            }
        }

        
    }


}
