using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HealthCollectable : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        MarshMellowController controller = other.GetComponent<MarshMellowController>();
        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
            {

                controller.ChangeHealth(1);
                Destroy(gameObject);
            }

            Debug.Log("Object that entered the trigger is: " + other);
        }
    }
}
