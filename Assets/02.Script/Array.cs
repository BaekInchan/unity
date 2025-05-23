using UnityEngine;

public class Array : MonoBehaviour
{
    int number1 = 1;
    private int number2 = 2;
    
    public int number3 = 3;
    [SerializeField] // unity 내에서만 접근 가능 그 외로는 접근 불가
    private int number4 = 4;
    [SerializeField] // 직렬화 Desrialize 역 직렬화
    private int number5 = 5;
}
