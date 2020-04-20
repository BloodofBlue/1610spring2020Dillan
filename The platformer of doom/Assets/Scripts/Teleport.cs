using UnityEngine;
using UnityEngine.Events;

public class Teleport : MonoBehaviour
{
    public FloatData health;
    public UnityEvent alive;
    public UnityEvent respawn;
    void Update()
    {
        if (health.value > 0)
        {
            alive.Invoke();
        }

        if (health.value <= 0)
        {
            respawn.Invoke();
        }
    }
}
