using UnityEngine;
public class Scorer : MonoBehaviour
{
    private static int _totalHitNumber = 0;

    public static int TotalHitNumber
    {
        get => _totalHitNumber;
        set
        {
            if(value > 0){
                _totalHitNumber += value; 
            }
        }
    }
}
