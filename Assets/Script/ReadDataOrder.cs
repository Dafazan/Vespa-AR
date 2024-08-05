using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Extensions;
using Firebase.Firestore;

public class ReadDataOrder : MonoBehaviour
{
    private FirebaseFirestore db;
    private const string collectionName = "DataOrder";

    private void Start()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
        {
            FirebaseApp app = FirebaseApp.DefaultInstance;
            db = FirebaseFirestore.DefaultInstance;
        });
    }

    public void AddHighscore(string name)
    {
        Dictionary<string, object> DataOrder = new Dictionary<string, object>
        {
            { "UserName", name },
        };

        db.Collection(collectionName).AddAsync(DataOrder);
    }
}
