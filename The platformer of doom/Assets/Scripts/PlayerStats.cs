using UnityEngine;
using UnityEngine.Events;

public class PlayerStats : MonoBehaviour
{
    public IntData health;
    public UnityEvent dead;
    
    void Update()
    {
        if (health.value < 1)
        {
            dead.Invoke();
        }
    }
}
