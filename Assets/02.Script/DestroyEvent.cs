using UnityEngine;


public class Destroy : MonoBehaviour
{

    public float destroyTime = 3f;
    void Start()
    {
        Destroy(this.gameObject, destroyTime);

        
    }
    void OnDestroy() // �ı��ɶ� ����, �ı��� �ȵǵ� ���α׷��� ���ᰡ �ȴٸ� 1�� ����
    {
        Debug.Log($"{this.gameObject.name}�� �ı��Ǿ����ϴ�");
    }
    
}
