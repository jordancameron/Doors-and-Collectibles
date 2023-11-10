using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int requiredItems = 5;

    private int collectedItems = 0;
    public GameObject door;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void CollectItem(int itemID)
    {
        // This method is called when an item is collected
        collectedItems++;

        // Check if the required number of items has been collected
        if (collectedItems >= requiredItems)
        {
            // Deactivate the door
            if (door != null)
            {
                door.SetActive(false);
            }

            // You might want to play a sound or show a message here
        }
    }
}
