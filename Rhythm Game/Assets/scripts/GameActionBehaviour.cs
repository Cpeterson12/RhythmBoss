using UnityEngine;
using UnityEngine.Events;
[CreateAssetMenu]
public class GameActionBehaviour : ScriptableObject
{
    public UnityAction raise;

    public void RaiseAction()
    {
        raise?.Invoke();
    }
}
