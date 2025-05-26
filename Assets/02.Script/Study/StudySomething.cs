using UnityEngine;

public class StudySomething : MonoBehaviour
{
    public int currentLevel = 10;

    public int maxLevel = 99;

    private void Start()
    {
        string msg = currentLevel >= maxLevel ? "현재 만렙입니다." : "현재 만렙이 아닙니다."; // 조건 ? 참일때 : 거짓일때

        int levelPoint = currentLevel >= maxLevel ? 0 : 1;

        currentLevel += levelPoint;

        Debug.Log(msg);
    }
}
