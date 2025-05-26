using System.Threading;
using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretHead;

    public GameObject bulletPrefab; // �Ѿ� ������
    public Transform firepos; // �߻� ��ġ

    public float timer;
    public float cooldownTime;

    void Start() // �������� ����
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update() // �����ΰ��� �ٶ󺸴� ���
    {
        turretHead.LookAt(targetTf);

        timer += Time.deltaTime;
        if(timer>= cooldownTime)
        {
            timer = 0f;

            Instantiate(bulletPrefab, firepos.position, firepos.rotation);
        }

    }

}
