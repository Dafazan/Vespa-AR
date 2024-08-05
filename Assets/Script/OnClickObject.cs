using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnClickObject : MonoBehaviour
{
    //public GameObject bodyVespa;
    public GameObject inputBodyVespa;
    public GameObject[] nonInputBodyVespa;

    /* public void OnMouseUpAsButton()
    {
        inputBodyVespa.SetActive(true);
        nonInputBodyVespa[0].gameObject.SetActive(false);
    } */

    public void OnClickBtnBody()
    {
        inputBodyVespa.SetActive(true);
        nonInputBodyVespa[0].gameObject.SetActive(false);
        nonInputBodyVespa[1].gameObject.SetActive(false);
        nonInputBodyVespa[2].gameObject.SetActive(false);
        nonInputBodyVespa[3].gameObject.SetActive(false);
        nonInputBodyVespa[4].gameObject.SetActive(false);
        nonInputBodyVespa[5].gameObject.SetActive(false);
    }

    public void hidePanel()
    {
        inputBodyVespa.SetActive(false);
    }
}
