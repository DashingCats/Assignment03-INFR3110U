using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollisionDestroy : MonoBehaviour
{
    public GameObject scroll;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(scroll);
    }
}
