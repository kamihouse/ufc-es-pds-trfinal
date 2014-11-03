using UnityEngine;
using System.Collections;

public class DadoGUI : MonoBehaviour {

	string valorDado1 = "Valor Dado 1";
	string valorDado2 = "Valor Dado 2";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		valorDado1 = GUI.TextField(new Rect(770, 250, 120, 20), valorDado1, 25);
		valorDado2 = GUI.TextField(new Rect(770, 275, 120, 20), valorDado2, 25);

		if (GUI.Button(new Rect(790, 305, 80, 30), "Jogar Dado"))
			Debug.Log("Dado 1: "+valorDado1+"; Dado 2: "+valorDado2);
	}
}
