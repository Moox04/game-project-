using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class gameManeger : MonoBehaviour {
	//List<MeshRenderer> ground;
	public Transform startpnt;
	public Transform endpnt;
	SceneManager scenem;
	public playerMovement pm;
	public tileGenerator sd;


	//public MeshRenderer[] ground2;
	//public MeshRenderer[] ground3;

	// Use this for initialization
	public void restart2(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex,LoadSceneMode.Single);

	}
	public void restart(){
		PlayerPrefs.SetFloat ("score", 0f);
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex,LoadSceneMode.Single);

	}
	void Start () {
	//Scene currentScene = SceneManager.GetActiveScene ();
		//string sceneName = currentScene.name;
		//if(sceneName == "SampleScene"){
			//Invoke ("hidelvl", 5f);
				Invoke ("allowMove", 5f);
		sd.ns = PlayerPrefs.GetFloat("score");


	//	}
	

	}
	void Update(){
		// ns = PlayerPrefs.GetFloat ("score");

	}
	public void ld (){
		int nextlvl = (SceneManager.GetActiveScene ().buildIndex) + 1;
		SceneManager.LoadScene (nextlvl);
	}
	
	// Update is called once per frame
	/*void hidelvl () {
		foreach(MeshRenderer sd  in ground){
			sd.enabled = false;
		}
	}*/
	void allowMove(){
		pm.enabled = true;
	}

}
