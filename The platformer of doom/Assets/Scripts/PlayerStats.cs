using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class PlayerStats : MonoBehaviour
{
    public FloatData health;
    public UnityEvent dead;
    public UnityEvent playerRespawn;
    
    void Update()
    {
        if (health.value <= 0)
        {
            dead.Invoke();
            StartCoroutine("Delay");
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.05f);
        playerRespawn.Invoke();
    }
}