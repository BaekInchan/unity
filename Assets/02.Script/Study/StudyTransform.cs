using UnityEngine;

public class StudyTransform : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;

    private void Update()
    {
        // 월드 방향으로 이동
        //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        // 월드 방향으로 이동
        //transform.localPosition += Vector3.forward * moveSpeed* Time.deltaTime;

        //// 월드 방향으로 이동
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);
        
        //// 로컬 방향으로 이동
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        //// 월드 방향으로 회전
        ////float angle = transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime;
        ////float localX = transform.rotation.eulerAngles.x;
        ////float localZ = transform.rotation.eulerAngles.z;


        ////transform.rotation = Quaternion.Euler(localX, angle, localZ);
        
        //// 로컬 방향으로 회전
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); // Space.Slef 생략
        
        //// 월드 방향으로 회전
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);

        // 특정 위치의 주변을 회전
        //transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);

        transform.LookAt(Vector3.zero);

    }
}
