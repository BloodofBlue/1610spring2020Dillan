using UnityEngine;
using UnityEngine.Events;

public class PlayerStats : MonoBehaviour
{
    public FloatData health;
    public UnityEvent dead;
    
    void Update()
    {
        if (health.value <= 0)
        {
            dead.Invoke();
        }
    }
}
