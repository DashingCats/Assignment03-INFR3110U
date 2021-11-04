using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollPickup : MonoBehaviour
{
    public Text text;

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Scroll")
        {
            text.text = "Scroll Collected";

        }
    }
}
