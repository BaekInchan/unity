using UnityEngine;

public class StudyTransform : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;

    private void Update()
    {
        // ���� �������� �̵�
        //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        // ���� �������� �̵�
        //transform.localPosition += Vector3.forward * moveSpeed* Time.deltaTime;

        //// ���� �������� �̵�
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);
        
        //// ���� �������� �̵�
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        //// ���� �������� ȸ��
        ////float angle = transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime;
        ////float localX = transform.rotation.eulerAngles.x;
        ////float localZ = transform.rotation.eulerAngles.z;


        ////transform.rotation = Quaternion.Euler(localX, angle, localZ);
        
        //// ���� �������� ȸ��
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); // Space.Slef ����
        
        //// ���� �������� ȸ��
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);

        // Ư�� ��ġ�� �ֺ��� ȸ��
        //transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);

        transform.LookAt(Vector3.zero);

    }
}
