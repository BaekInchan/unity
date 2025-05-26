using System.Threading;
using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretHead;

    public GameObject bulletPrefab; // 총알 프리팹
    public Transform firepos; // 발사 위치

    public float timer;
    public float cooldownTime;

    void Start() // 서브적인 세팅
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update() // 무엇인가를 바라보는 기능
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
