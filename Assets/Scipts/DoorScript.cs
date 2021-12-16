using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorScript : MonoBehaviour
{
    ItemCollector itemCollector;

    public Sprite unlockedSprite;

    public float orangesToCollect;

    private void Awake()
    {
        itemCollector = FindObjectOfType<ItemCollector>();
    }

    private void Update()
    {
        if (itemCollector.oranges >= orangesToCollect)
        {
            Destroy(GetComponent<BoxCollider2D>());
            GetComponent<SpriteRenderer>().sprite = unlockedSprite;
        }
    }
}
