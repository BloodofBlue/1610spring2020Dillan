using UnityEngine;
using UnityEngine.Events;

public class StartEvent : MonoBehaviour
{
    public UnityEvent gameStart;

    void Start()
    {
        gameStart.Invoke();
    }
}
