using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public Animator buttonPlatform;
    private bool marked = false;
    private void OnTriggerEnter(Collider theCollider)
    {
        if (theCollider.gameObject.CompareTag("Player"))
        {
            buttonPlatform.SetBool("ButtonPressed", true);
            if (!marked) {
                marked = true;
                FindObjectOfType<Score>().ButtonMarked();
            }
        }
    }

}
