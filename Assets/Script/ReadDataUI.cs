using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase.Firestore;
using Firebase;
using Firebase.Extensions;
using TMPro;
using System;

public class ReadDataUI : MonoBehaviour
{
    private Transform content;
    private Transform data;

    public TextMeshProUGUI namaText;
    public Button btnStats;
    
    private List<Transform> dataEntryTransformList;

    private List<DataEntry> dataEntryList;

    private FirebaseFirestore db;
    private const string collectionName = "DataOrder";

    private async void Awake() 
    {
        /*  Query allCitiesQuery = db.Collection("DataOrder");
          allCitiesQuery.GetSnapshotAsync().ContinueWithOnMainThread(task =>
          {
              QuerySnapshot allCitiesQuerySnapshot = task.Result;
              foreach (DocumentSnapshot documentSnapshot in allCitiesQuerySnapshot.Documents)
              {
                  Debug
                  Debug.Log(String.Format("Document data for {0} document:", documentSnapshot.Id));
                  Dictionary<string, object> city = documentSnapshot.ToDictionary();
                  foreach (KeyValuePair<string, object> pair in city)
                  {
                      Debug.Log(String.Format("{0}: {1}", pair.Key, pair.Value));

                  }

                  // Newline to separate entries


                  Debug.Log("");
              }
          });*/

/*
        Query allCitiesQuery = db.Collection("DataOrder");
        QuerySnapshot allCitiesQuerySnapshot = await db..GetSnapshotAsync();
        foreach (DocumentSnapshot documentSnapshot in allCitiesQuerySnapshot.Documents)
        {
            Dictionary<string, object> city = documentSnapshot.ToDictionary();
            foreach (KeyValuePair<string, object> pair in city)
            {
                Debug.Log(pair.Key + " " + pair.Value);
                //Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
        }*/



        /* db.Collection("DataOrder").GetSnapshotAsync().ContinueWithOnMainThread(task =>
         {
             QuerySnapshot allCitiesQuerySnapshot = task.Result;
             foreach (DocumentSnapshot documentSnapshot in allCitiesQuerySnapshot.Documents)
             {

                   Debug.Log(String.Format("Document data for {0} document:", documentSnapshot.Id));
                 Dictionary<string, object> city = documentSnapshot.ToDictionary();
                 foreach (KeyValuePair<string, object> pair in city)
                 {
                     Debug.Log(String.Format("{0}: {1}", pair.Key, pair.Value));

                 }

                 // Newline to separate entries


                 Debug.Log("");
             }
         });
 */

        //FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
        // {
        //    FirebaseApp app = FirebaseApp.DefaultInstance;
        //    db = FirebaseFirestore.DefaultInstance;
        //    content = transform.Find("Content");
        //    data = content.Find("DataRead");

        //    data.gameObject.SetActive(false);



        //});
        // content = transform.Find("Content");
        // data = content.Find("DataRead");

        // data.gameObject.SetActive(false);

        // dataEntryList = new List<DataEntry>() 
        // {
        //     new DataEntry{ nama = "Agus" },
        //     new DataEntry{ nama = "Tio" },
        //    new DataEntry{ nama = "Tio1" },
        //     new DataEntry{ nama = "Tio2" },
        //      new DataEntry{ nama = "Tio3" },
        //  };

        // dataEntryTransformList = new List<Transform>();
        //  foreach (DataEntry dataEntry in dataEntryList)
        // {
        //      CreateDataEntryTransform(dataEntry, content, dataEntryTransformList); //, db);
        //  }


    }

    private void CreateDataEntryTransform(DataEntry dataEntry, Transform content, List<Transform> transformList)
    {
        float dataHeight = 350f;
        Transform dataTransform = Instantiate(data, content);
        RectTransform dataRectTransform = dataTransform.GetComponent<RectTransform>();
        dataRectTransform.anchoredPosition = new Vector2(0, -dataHeight * transformList.Count);
        dataTransform.gameObject.SetActive(true);

        string name = dataEntry.nama;
        dataTransform.Find ("NameText").GetComponent<TextMeshProUGUI>().text = name;

        transformList.Add(dataTransform);
    }


    /*private void Start()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
        {
            FirebaseApp app = FirebaseApp.DefaultInstance;
            db = FirebaseFirestore.DefaultInstance;

            LoadHighscores();
        });
    }*/

    void FetchDataFromFirestore()
    {
        CollectionReference collectionRef = db.Collection("DataOrder");

        collectionRef.GetSnapshotAsync().ContinueWithOnMainThread(task =>
        {
            if (task.IsFaulted)
            {
                Debug.LogError("Error fetching documents: " + task.Exception);
                return;
            }

            List<string> tableData = new List<string>();

            QuerySnapshot snapshot = task.Result;
            foreach (DocumentSnapshot documentSnapshot in snapshot.Documents)
            {
                Dictionary<string, object> data = documentSnapshot.ToDictionary();

                // Process data and add it to your tableData list
                // For example: tableData.Add(data["field_name"].ToString());
            }

            // Now you have your data in the tableData list
            DisplayDataInTable(tableData);
        });
    }

    void DisplayDataInTable(List<string> data)
    {
        // Here you can create UI elements or use a library to display the data in a table-like format
        // For example, you might create Unity UI Text or TextMeshPro elements for each data item.
    }

    private class DataEntry
    {
        public string nama ;
    }
}
