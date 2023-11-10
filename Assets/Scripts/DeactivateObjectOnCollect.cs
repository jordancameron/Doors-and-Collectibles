using UnityEngine;
using UnityEngine.Events;

public class DeactivateObjectOnCollect : MonoBehaviour
{
    public UnityEvent onDeactivate;

    public int collectiblesRequired = 5;
    private int collectedCount = 0;

    public void CollectibleCollected()
    {
        collectedCount++;

        if (collectedCount >= collectiblesRequired)
        {
            DeactivateObject();
        }
    }

    private void DeactivateObject()
    {
        onDeactivate.Invoke();
    }
}

