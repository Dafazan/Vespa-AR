using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResetKodeWarnaForm : MonoBehaviour
{
    [SerializeField] TMP_InputField KodeWarana;

    public void ResetKodeWarna()
    {
        KodeWarana.text = "-";
    }
}
