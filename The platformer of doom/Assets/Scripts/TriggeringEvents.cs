using UnityEngine;
using UnityEngine.Events;

public class TriggeringEvents : MonoBehaviour
{
    public int triggeringInteger;
    public float triggeringFloat;
    public string triggeringString;

    public UnityEvent enterTheVortex;
    public UnityEvent exitTheVortex;

    private void OnTriggerEnter(Collider other)
    {
        enterTheVortex.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        exitTheVortex.Invoke();
    }
}
