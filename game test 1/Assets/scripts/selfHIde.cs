using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class selfHIde : MonoBehaviour {
	public MeshRenderer meshrnd;


	void Start () {
		Invoke ("hide",5f);
	}
	public void hide(){
		if(gameObject.tag != "startpnt" && gameObject.tag != "endpnt")
			meshrnd.enabled = false;
	}

}
