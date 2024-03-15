using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItems : MonoBehaviour
{
    public ScriptableItem items;

    SpriteRenderer spriteRenderer;
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        spriteRenderer.sprite = items.itemSprite;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        InventoryManager.instance.AddItem(items);
        Destroy(this.gameObject);

    }
}
