using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
<<<<<<< Updated upstream
    public int value = 1;
=======
    public string value = 1;
>>>>>>> Stashed changes

    public void ChangeValue(int number)
    {
        value += number;
    }
}
