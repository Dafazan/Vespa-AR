using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Firestore;
using UnityEngine.UI;
using TMPro;
using Vuforia;
using Firebase.Extensions;
using UnityEngine.SceneManagement;
//using System;

public class CloudFirestore : MonoBehaviour
{
    FirebaseFirestore db;
    Dictionary<string, object> user;

    public GameObject FormOrderPanel, notificationPanel;
    public TextMeshProUGUI notif_Title_Text, notif_Message_Text;
    //SceneManagement sm = new SceneManagement();



    //public int id = Random.Range(0, 10000);

    [SerializeField] TMP_InputField Tanggal, Username, BodyDepan, BodyDepanTengah, BodyKanan, BodyKiri, BodyTengah, SpakborDepan, Steering, NoHp, NoKendaraan;
    // Start is called before the first frame update
    void Start()
    {
        db = FirebaseFirestore.DefaultInstance;
    }

    void Update()
    {
        System.DateTime dt = System.DateTime.Now;
        Tanggal.text = dt.Day.ToString() + "/" + dt.Month.ToString() + "/" + dt.Year.ToString();
    } 

    public void SaveData()
    {
        DocumentReference Addref = db.Collection("DataOrder").Document();
        user = new Dictionary<string, object> 
        {
            {"id", Addref.Id} ,
            {"Tanggal", Tanggal.text },
            {"Status", "Proses" },
            {"UserName", Username.text },
            {"BodyDepan", BodyDepan.text },
            {"BodyDepanTengah", BodyDepanTengah.text },
            {"BodyKanan", BodyKanan.text },
            {"BodyKiri", BodyKiri.text },
            {"BodyTengah", BodyTengah.text },
            {"SpakborDepan", SpakborDepan.text },
            {"Steering", Steering.text },
            {"NoHp", NoHp.text },
            {"NoKendaraan", NoKendaraan.text },
        };

        Addref.SetAsync(user).ContinueWithOnMainThread(task =>
        {
            if (task.IsCompleted)
            {
                showNotificationMessage("Success", "Data order Berhasil ditambahkan");
                Debug.Log("Order berhasil ditambahkan");
                
            }
            else
            {
                Debug.Log("Order gagal ditambahkan");
            }

            
        });
    }
    

    public void OpenSubmitPanel()
    {
        FormOrderPanel.SetActive(true);
    }

    public void CloseSubmitPanel()
    {
        FormOrderPanel.SetActive(false);
    }

    private void showNotificationMessage(string title, string message)
    {
        notif_Title_Text.text = "" + title;
        notif_Message_Text.text = "" + message;

        notificationPanel.SetActive(true);
    }

    public void CloseNotif_Panel()
    {

        SceneManager.LoadScene("LoginScreen");
    }
}
