using UnityEngine;

public class itemType : MonoBehaviour
{
    public Objects objectType;
    void Start()
    {
        if (GameManager.instance.collectedItems.Contains(objectType.itemId))
        {
            Destroy(gameObject);
        }
    }
}
