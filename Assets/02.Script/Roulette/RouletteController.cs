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
        

        //  ���콺 ���� ��ư�� ������ �� ȸ���ϴ� ���
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = 5f;
        }

        // Ű���� �����̽� ��ư�� ������ �� �����ϴ� ���
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }
        // rotSpeed = rotSpeed * 0.98f;
        if (isStop == true)
        {
            rotSpeed *= 0.98f; // ����ӵ����� Ư�� ����ŭ ���̴� ���
            if (rotSpeed < 0.01f)
            {
                rotSpeed = 0f;
                isStop = false;
            }
        }

        
    }


}
