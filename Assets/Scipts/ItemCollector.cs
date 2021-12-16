using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public int oranges = 0;

    public Text orangesText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("orange"))
        {
            Destroy(collision.gameObject);
            oranges++;
            orangesText.text = "oranges: " + oranges;
        }
    }
}
