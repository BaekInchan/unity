using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1;
    public int number2;
    // ¸É¹ö º¯¼ö

    void Start()
    {
        int add_Result = AddMethod();

        int minus_Result = MinusMethod();

        Debug.Log($"´õÇÑ°ª : {add_Result} / »« °ª : {minus_Result}");

        
    }

        
        
    
    int AddMethod()
    {
        int result = number1 + number2;

        return result;
    }

    int MinusMethod()
    {
        int result = number1 - number2;
        
        return result;
    }
}
