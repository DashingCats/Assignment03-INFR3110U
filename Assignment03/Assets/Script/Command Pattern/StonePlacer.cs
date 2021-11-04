using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StonePlacer : MonoBehaviour
{
    static List<Transform> stones;
    public static void PlaceStone(Vector3 position, Transform stone)
    {
        Transform newStone = Instantiate(stone, position, Quaternion.identity);
        //newStone.GetComponentInChildren<MeshRenderer>().material.color = Color;
        if (stones == null)
        {
            stones = new List<Transform>();
        }
        stones.Add(newStone);
    }

    public static void RemoveStone(Vector3 position)
    {
        for (int i = 0; i < stones.Count; i++)
        {
            if (stones[i].position == position)
            {
                GameObject.Destroy(stones[i].gameObject);
                stones.RemoveAt(i);
                break;
            }
        }
    }
}
