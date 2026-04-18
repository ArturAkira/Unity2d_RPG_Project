using System.IO;
using UnityEngine;

public class itemType : MonoBehaviour
{
    public Objects objectType;
    [SerializeField] private classes classes;
    private SpriteRenderer sr;
    public int index;
    void Start()
    {
        objectType = classes.itemSetter(index);
        classes.itemSetter(index);
        if (GameManager.instance.collectedItems.Contains(objectType.itemId))
        {
            Destroy(gameObject);
        }
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = objectType.itemSprite;
    }
}
