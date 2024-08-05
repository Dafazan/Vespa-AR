using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Firebase;
using Firebase.Auth;

public class FirebaseAuthLogout : MonoBehaviour
{
    Firebase.Auth.FirebaseAuth auth;
    Firebase.Auth.FirebaseUser user;
    FirebaseAuthController authController;

    public void Logout()
    {
        auth.SignOut();
        SceneManager.LoadScene("HelloScene");
    }


}
