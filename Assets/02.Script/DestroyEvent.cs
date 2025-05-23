using UnityEngine;


public class Destroy : MonoBehaviour
{

    public float destroyTime = 3f;
    void Start()
    {
        Destroy(this.gameObject, destroyTime);

        
    }
    void OnDestroy() // 파괴될때 실행, 파괴가 안되도 프로그램이 종료가 된다면 1번 실행
    {
        Debug.Log($"{this.gameObject.name}이 파괴되었습니다");
    }
    
}
