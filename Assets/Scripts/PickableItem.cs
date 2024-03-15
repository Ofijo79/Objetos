using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItem : MonoBehaviour
{
    public ScriptableItem item;

    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        spriteRenderer.sprite = item.itemSprite;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        InventoryManager.instance.AddItem(item);
        Destroy(this.gameObject);    
    }
}
