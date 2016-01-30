using UnityEngine;
using System.Collections;

public class gui : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

		void OnGUI() {
			if (GUILayout.Button("Press Me"))
				Debug.Log("Hello!");
		GUILayout.TextArea ("War of Gods");
		}
	// Update is called once per frame
	void Update () {
	
	}
}
