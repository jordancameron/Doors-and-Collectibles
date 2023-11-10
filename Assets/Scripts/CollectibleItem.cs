using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    // You can set a unique ID for each collectible item
    public int collectibleID = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Call the method to collect the item
            Collect();
        }
    }

    void Collect()
    {
        // You might want to play a sound or particle effect here
        // For now, let's just deactivate the collectible item
        gameObject.SetActive(false);

        // Notify the GameManager that an item has been collected
        GameManager.Instance.CollectItem(collectibleID);
    }
}
