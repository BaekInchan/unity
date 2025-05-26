using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;


    void Update()
    {
        /// Input System (Old - Legacy)
        /// �Է°��� ���� ��ӵ� �ý��� 
        /// �̵� -> WASD, ȭ��ǥ Ű����
        /// ���� -> Space
        /// �� ��� -> ���콺 ���� Ŭ��

        // �ε巴�� �����ϴ� ��
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // �� �������� ��
        //float h = Input.GetAxisRaw("Horizontal");
        //float v = Input.GetAxisRaw("Vertical");

        Vector3 dir  = new Vector3(h, 0, v);

        Vector3 normalDir = dir.normalized;

        //Debug.Log($"���� �Է�: {normalDir}");

        Debug.Log($"���� �Է� : {dir}");

        transform.position += dir * moveSpeed * Time.deltaTime;

        transform.LookAt(transform.position + normalDir);
    }
}