using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlane : MonoBehaviour
{
    Camera maincam;
    RaycastHit hitInfo;
    public Transform stonePrefab;

    private void Awake()
    {
        maincam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = maincam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                //StonePlacer.PlaceStone(hitInfo.point, stonePrefab);
                ICommand command = new PlaceStoneCommand(hitInfo.point, stonePrefab);
                CommandInvoker.AddCommand(command);
            }
        }
    }
}
