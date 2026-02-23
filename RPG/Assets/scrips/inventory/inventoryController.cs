using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class inventoryController : MonoBehaviour
{
    public Image[] slotImage;

    void Start()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        for (int i = 0; i < slotImage.Length; i++)
        {
            if (GameManager.instance.slots[i] != null)
            {
                slotImage[i].sprite = GameManager.instance.slots[i].itemSprite;
                slotImage[i].enabled = true;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("item") == true)
        {
            for (int i = 0; i < GameManager.instance.slots.Length; i++)
            {
                itemType item = col.GetComponent<itemType>();
                GameManager.instance.collectedItems.Add(item.objectType.itemId);


                if (GameManager.instance.slots[i] == null || GameManager.instance.slots[i] == item.objectType)
                {
                    GameManager.instance.slots[i] = item.objectType;
                    GameManager.instance.slots[i].name = item.name;
                    GameManager.instance.slotAmount[i]++;
                    slotImage[i].sprite = item.objectType.itemSprite;
                    slotImage[i].enabled = true;
                    Destroy(col.gameObject);
                    break;
                }
            }
        }
    }
}
