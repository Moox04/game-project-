using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevels : MonoBehaviour {

	public void startarcade(){
		SceneManager.LoadScene ("Arcadelvl");
	}
	public void startlevles(){
		SceneManager.LoadScene ("SampleScene");
	}
}
