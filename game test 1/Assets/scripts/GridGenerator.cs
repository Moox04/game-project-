using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour {
	public GameObject gtile;
	public GameObject gtile2;
	public Vector3 ge;
	//public Vector3 ge2;

	// Use this for initialization
	void Start () {
		for (int x = 0; x < 10; x++) {
				for(int y = 0 ;y <8;y++){
					Instantiate (gtile, ge, Quaternion.identity);
				Instantiate (gtile2, ge, Quaternion.identity);
					ge = ge + (Vector3.right*2);
				}

			Instantiate (gtile, ge, Quaternion.identity);
			Instantiate (gtile2, ge, Quaternion.identity);
			ge =( ge + (Vector3.forward*2))-( new Vector3(16f,0f,0f));
				
		}
	}
	

}
