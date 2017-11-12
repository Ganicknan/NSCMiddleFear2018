using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class firebase : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("hhttps://middlefear.firebaseio.com/");
	
	}
	
	// Update is called once per frame
	void Update () {
		DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
		reference.Child("position").Child("x").SetValueAsync(transform.position.x);
		reference.Child("position").Child("y").SetValueAsync(transform.position.y);
		reference.Child("position").Child("z").SetValueAsync(transform.position.z);
		
	}
}
