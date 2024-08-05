using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectorScript : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;

    public GameObject cube;
    public GameObject cubeInfo;

    bool isInfo = false;

    void Start()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name == "ButtonInfo")
                {
                    if (!isInfo)
                    {
                        cubeInfo.SetActive(true);
                        isInfo = true;
                    }
                    else
                    {
                        cubeInfo.SetActive(false);
                        isInfo = false;
                    }              
                }
            }
        }        
    }
}
