using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;


    void Update()
    {
        /// Input System (Old - Legacy)
        /// 입력값에 대한 약속된 시스템 
        /// 이동 -> WASD, 화살표 키보드
        /// 점프 -> Space
        /// 총 쏘기 -> 마우스 왼쪽 클릭

        // 부드럽게 증감하는 값
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 딱 떨어지는 값
        //float h = Input.GetAxisRaw("Horizontal");
        //float v = Input.GetAxisRaw("Vertical");

        Vector3 dir  = new Vector3(h, 0, v);

        Vector3 normalDir = dir.normalized;

        //Debug.Log($"현재 입력: {normalDir}");

        Debug.Log($"현재 입력 : {dir}");

        transform.position += dir * moveSpeed * Time.deltaTime;

        transform.LookAt(transform.position + normalDir);
    }
}