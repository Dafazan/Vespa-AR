using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Clicking : MonoBehaviour
{

    Ray ray;
    RaycastHit hit;

    //Bool Indikasi Aktif Tombol
    private bool BDepan = false;
    private bool BDepanTengah = false;
    private bool BTengah = false;
    private bool BKanan = false;
    private bool BKiri = false;
    private bool BSpakborDepan = false;
    private bool BSteering = false;

    //vespa2
    //private bool BDepanB, BDepanTengahB, BTengahB, BKananB, BKiriB, BSpakborDepanB, BSteeringB = false;
  

    //Untuk Tombol
    public GameObject BodyDepan;
    public GameObject BodyDepanTengah;
    public GameObject BodyTengah;
    public GameObject BodyKanan;
    public GameObject BodyKiri;
    public GameObject SpakborDepan;
    public GameObject Steering;
    //Vespa2
    /*public GameObject BodyDepanB;
    public GameObject BodyDepanTengahB;
    public GameObject BodyTengahB;
    public GameObject BodyKananB;
    public GameObject BodyKiriB;
    public GameObject SpakborDepanB;
    public GameObject SteeringB;*/

    //Untuk Objek Vespa
    public GameObject ObjBodyDepan;
    public GameObject ObjBodyDepanTengah;
    public GameObject ObjBodyTengah;
    public GameObject ObjBodyKanan;
    public GameObject ObjBodyKiri;
    public GameObject ObjSpakborDepan;
    public GameObject ObjSteering;
    //Vespa2
    /*public GameObject ObjBodyDepanB;
    public GameObject ObjBodyDepanTengahB;
    public GameObject ObjBodyTengahB;
    public GameObject ObjBodyKananB;
    public GameObject ObjBodyKiriB;
    public GameObject ObjSpakborDepanB;
    public GameObject ObjSteeringB;*/

    public GameObject Adv;



    void Start()
    {
        // Initialise ray
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    }

    void Update()
    {
        if ((!BDepan) && (!BDepanTengah) && (!BTengah) && (!BKanan) && (!BKiri) && (!BSpakborDepan) && (!BSteering))
        {
            Adv.SetActive(true);
        }
        else
        {
            Adv.SetActive(false);
        }


       

        if (Input.GetMouseButtonDown(0))
        {
            
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {

                //Body Depan
                if (hit.collider.gameObject.name == "BodyDepan")
                {
                    if (!BDepan)
                    {
                        BDepan = true;
                        BodyDepan.SetActive(true);
                        BodyDepanTengah.SetActive(false);
                        BodyTengah.SetActive(false);
                        BodyKanan.SetActive(false);
                        BodyKiri.SetActive(false);
                        SpakborDepan.SetActive(false);
                        Steering.SetActive(false);
                    }
                    else
                    {
                        BDepan = false;
                        BodyDepan.SetActive(false);
                    }
                }


                //Steering
                if (hit.collider.gameObject.name == "Steering")
                {
                    if (!BSteering)
                    {
                        BSteering = true;
                        Steering.SetActive(true);
                        BodyDepan.SetActive(false);
                        BodyDepanTengah.SetActive(false);
                        BodyTengah.SetActive(false);
                        BodyKanan.SetActive(false);
                        BodyKiri.SetActive(false);
                        SpakborDepan.SetActive(false);
                   
                    }
                    else
                    {
                        BSteering = false;
                        Steering.SetActive(false);
                    }
                }
               

                //Body Depan Tengah
                if (hit.collider.gameObject.name == "BodyDepanTengah")
                {
                    if (!BDepanTengah)
                    {
                        BDepanTengah = true;
                        BodyDepanTengah.SetActive(true);

                        BodyDepan.SetActive(false);
                        
                        BodyTengah.SetActive(false);
                        BodyKanan.SetActive(false);
                        BodyKiri.SetActive(false);
                        SpakborDepan.SetActive(false);
                        Steering.SetActive(false);
                    }
                    else
                    {
                        BDepanTengah = false;
                        BodyDepanTengah.SetActive(false);
                    }
                }
                
                
                //Body Kanan
                if (hit.collider.gameObject.name == "BodyKanan")
                {
                    if (!BKanan)
                    {
                        BKanan = true;
                        BodyKanan.SetActive(true);
                        BodyDepan.SetActive(false);
                        BodyDepanTengah.SetActive(false);
                        BodyTengah.SetActive(false);
                       
                        BodyKiri.SetActive(false);
                        SpakborDepan.SetActive(false);
                        Steering.SetActive(false);
                    }
                    else
                    {
                        BKanan = false;
                        BodyKanan.SetActive(false);
                    }
                }
               

                //Body Kiri
                if (hit.collider.gameObject.name == "BodyKiri")
                {
                    if (!BKiri)
                    {
                        BKiri = true;
                        BodyKiri.SetActive(true);
                        BodyDepan.SetActive(false);
                        BodyDepanTengah.SetActive(false);
                        BodyTengah.SetActive(false);
                        BodyKanan.SetActive(false);
                        
                        SpakborDepan.SetActive(false);
                        Steering.SetActive(false);
                    }
                    else
                    {
                        BKiri = false;
                        BodyKiri.SetActive(false);
                    }
                }
               

                //Body Tengah
                if (hit.collider.gameObject.name == "BodyTengah")
                {
                    if (!BTengah)
                    {
                        BTengah = true;
                        BodyTengah.SetActive(true);
                        BodyDepan.SetActive(false);
                        BodyDepanTengah.SetActive(false);
                        
                        BodyKanan.SetActive(false);
                        BodyKiri.SetActive(false);
                        SpakborDepan.SetActive(false);
                        Steering.SetActive(false);
                    }
                    else
                    {
                        BTengah = false;
                        BodyTengah.SetActive(false);
                    }
                }
               

                //Spakbor Depan
                if (hit.collider.gameObject.name == "SpakborDepan")
                {
                    if (!BSpakborDepan)
                    {
                        BSpakborDepan = true;
                        SpakborDepan.SetActive(true);
                        BodyDepan.SetActive(false);
                        BodyDepanTengah.SetActive(false);
                        BodyTengah.SetActive(false);
                        BodyKanan.SetActive(false);
                        BodyKiri.SetActive(false);
                        
                        Steering.SetActive(false);
                    }
                    else
                    {
                        BSpakborDepan = false;
                        SpakborDepan.SetActive(false);
                    }
                }

                /*//Vespa2
                //Body Depan
                if (hit.collider.gameObject.name == "bodyDepanB")
                {
                    if (!BDepanB)
                    {
                        BDepanB = true;
                        BodyDepanB.SetActive(true);
                        BodyDepanTengahB.SetActive(false);
                        BodyTengahB.SetActive(false);
                        BodyKananB.SetActive(false);
                        BodyKiriB.SetActive(false);
                        SpakborDepanB.SetActive(false);
                        SteeringB.SetActive(false);
                    }
                    else
                    {
                        BDepanB = false;
                        BodyDepanB.SetActive(false);
                    }
                }


                //Steering
                if (hit.collider.gameObject.name == "SteeringB")
                {
                    if (!BSteeringB)
                    {
                        BSteeringB = true;
                        SteeringB.SetActive(true);
                        BodyDepanB.SetActive(false);
                        BodyDepanTengahB.SetActive(false);
                        BodyTengahB.SetActive(false);
                        BodyKananB.SetActive(false);
                        BodyKiriB.SetActive(false);
                        SpakborDepanB.SetActive(false);

                    }
                    else
                    {
                        BSteeringB = false;
                        SteeringB.SetActive(false);
                    }
                }


                //Body Depan Tengah
                if (hit.collider.gameObject.name == "BodyDepanTengahB")
                {
                   
                    if (!BDepanTengahB)
                    {
                        BDepanTengahB = true;
                        BodyDepanTengahB.SetActive(true);

                        BodyDepanB.SetActive(false);

                        BodyTengahB.SetActive(false);
                        BodyKananB.SetActive(false);
                        BodyKiriB.SetActive(false);
                        SpakborDepanB.SetActive(false);
                        SteeringB.SetActive(false);
                    }
                    else
                    {
                        BDepanTengahB = false;
                        BodyDepanTengahB.SetActive(false);
                    }
                }


                //Body Kanan
                if (hit.collider.gameObject.name == "BodyKananB")
                {
                    if (!BKananB)
                    {
                        BKananB = true;
                        BodyKananB.SetActive(true);
                        BodyDepanB.SetActive(false);
                        BodyDepanTengahB.SetActive(false);
                        BodyTengahB.SetActive(false);

                        BodyKiriB.SetActive(false);
                        SpakborDepanB.SetActive(false);
                        SteeringB.SetActive(false);
                    }
                    else
                    {
                        BKananB = false;
                        BodyKananB.SetActive(false);
                    }
                }


                //Body Kiri
                if (hit.collider.gameObject.name == "BodyKiriB")
                {
                    if (!BKiriB)
                    {
                        BKiriB = true;
                        BodyKiriB.SetActive(true);
                        BodyDepanB.SetActive(false);
                        BodyDepanTengahB.SetActive(false);
                        BodyTengahB.SetActive(false);
                        BodyKananB.SetActive(false);

                        SpakborDepanB.SetActive(false);
                        SteeringB.SetActive(false);
                    }
                    else
                    {
                        BKiriB = false;
                        BodyKiriB.SetActive(false);
                    }
                }


                //Body Tengah
                if (hit.collider.gameObject.name == "BodyTengahB")
                {
                    if (!BTengahB)
                    {
                        BTengahB = true;
                        BodyTengahB.SetActive(true);
                        BodyDepanB.SetActive(false);
                        BodyDepanTengahB.SetActive(false);

                        BodyKananB.SetActive(false);
                        BodyKiriB.SetActive(false);
                        SpakborDepanB.SetActive(false);
                        SteeringB.SetActive(false);
                    }
                    else
                    {
                        BTengahB = false;
                        BodyTengahB.SetActive(false);
                    }
                }


                //Spakbor Depan
                if (hit.collider.gameObject.name == "SpakborDepanB")
                {
                    if (!BSpakborDepanB)
                    {
                        BSpakborDepanB = true;
                        SpakborDepanB.SetActive(true);
                        BodyDepanB.SetActive(false);
                        BodyDepanTengahB.SetActive(false);
                        BodyTengahB.SetActive(false);
                        BodyKananB.SetActive(false);
                        BodyKiriB.SetActive(false);

                        SteeringB.SetActive(false);
                    }
                    else
                    {
                        BSpakborDepanB = false;
                        SpakborDepanB.SetActive(false);
                    }
                }*/



                //if (hit.collider.gameObject.name == "BlueSD")
                //{
                //    ObjSpakborDepan.GetComponent<ColorChanger>().BlueColor();
                //}
                //if (hit.collider.gameObject.name == "RedSD")
                //{
                //    ObjSpakborDepan.GetComponent<ColorChanger>().RedColor();
                //}
                //if (hit.collider.gameObject.name == "GreenSD")
                //{
                //    ObjSpakborDepan.GetComponent<ColorChanger>().GreenColor();
                //}
                //if (hit.collider.gameObject.name == "YellowSD")
                //{
                //    ObjSpakborDepan.GetComponent<ColorChanger>().YellowColor();
                //}

            }

        }
    }
}
