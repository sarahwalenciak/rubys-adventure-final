//This code is written by Riley Bottesch specifically for the Gameplay Modification requirement!!//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonBerry : MonoBehaviour
{
    public AudioClip collectedClip;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
if (controller.health <= controller.maxHealth)
            {
            	controller.ChangeHealth(-1);
            	Destroy(gameObject);

            
            	controller.PlaySound(collectedClip);
}
        }

    }
}