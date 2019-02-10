using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundImpact : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If the stone impacts with the Ground collider
        if (collision.gameObject.tag.Equals("Stone"))
        {
            // Remove the link to the parent
            collision.gameObject.transform.parent = null;

            // Rename the object tag
            collision.gameObject.tag = "DroppedStone";
        }
    }
}
