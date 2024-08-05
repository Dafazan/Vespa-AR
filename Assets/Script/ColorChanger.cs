using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Material[] BodyColorMat;
    Material CurMat;
    Renderer renderer;

    [SerializeField] TMP_InputField kodeWarna;

    // Start is called before the first frame update
    void Start()
    {
        renderer = this.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //renderer
    public void White()
    {
        kodeWarna.text = "#FFFFF";
        renderer.material = BodyColorMat[0];
        CurMat = renderer.material;
    }

    public void WhiteD()
    {
        kodeWarna.text = "#EBE2C8";
        renderer.material = BodyColorMat[1];
        CurMat = renderer.material;
    }

    public void Brown() {
        kodeWarna.text = "#A79074";
        renderer.material = BodyColorMat[2];
        CurMat = renderer.material;
    }

    public void AGrey() {
        kodeWarna.text = "#869094";
        renderer.material = BodyColorMat[3];
        CurMat = renderer.material;
    }
    public void PBlack()
    {
        kodeWarna.text = "#1A212F";
        renderer.material = BodyColorMat[4];
        CurMat = renderer.material;
    }
    public void BlackD()
    {
        kodeWarna.text = "#030306";
        renderer.material = BodyColorMat[5];
        CurMat = renderer.material;
    }
    public void Yellow()
    {
        kodeWarna.text = "#FCDB00";
        renderer.material = BodyColorMat[6];
        CurMat = renderer.material;
    }
    public void Bumblebee()
    {
        kodeWarna.text = "#F7A904";
        renderer.material = BodyColorMat[7];
        CurMat = renderer.material;
    }
    public void ROrange()
    {
        kodeWarna.text = "#EF4D09";
        renderer.material = BodyColorMat[8];
        CurMat = renderer.material;
    }
    public void FRed()
    {
        kodeWarna.text = "#E90119";
        renderer.material = BodyColorMat[9];
        CurMat = renderer.material;
    }
    public void Maroon()
    {
        kodeWarna.text = "#861B23";
        renderer.material = BodyColorMat[10];
        CurMat = renderer.material;
    }
    public void KGreen()
    {
        kodeWarna.text = "#77BC2C";
        renderer.material = BodyColorMat[11];
        CurMat = renderer.material;
    }
    public void Tosca()
    {
        kodeWarna.text = "#36BAE2";
        renderer.material = BodyColorMat[12];
        CurMat = renderer.material;
    }
    public void DBlue()
    {
        kodeWarna.text = "#4F8DBF";
        renderer.material = BodyColorMat[13];
        CurMat = renderer.material;
    }

    public void LBlue()
    {
        kodeWarna.text = "#197FC3";
        renderer.material = BodyColorMat[14];
        CurMat = renderer.material;
    }
    public void Blue()
    {
        kodeWarna.text = "#0A479D";
        renderer.material = BodyColorMat[15];
        CurMat = renderer.material;
    }
    public void Violet()
    {
        kodeWarna.text = "#332386";
        renderer.material = BodyColorMat[16];
        CurMat = renderer.material;
    }
    public void Magenta()
    {
        kodeWarna.text = "#E60344";
        renderer.material = BodyColorMat[17];
        CurMat = renderer.material;
    }
    public void DGreen()
    {
        kodeWarna.text = "#50806D";
        renderer.material = BodyColorMat[18];
        CurMat = renderer.material;
    }


}
