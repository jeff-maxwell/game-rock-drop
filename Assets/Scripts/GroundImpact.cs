using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundImpact : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Stone"))
        {
            collision.gameObject.transform.parent = null;
            collision.gameObject.tag = "DroppedStone";
        }
    }
}
