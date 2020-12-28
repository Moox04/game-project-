using UnityEngine.SceneManagement;
using UnityEngine;

public class playerWhereabout : MonoBehaviour {
	bool n = true;
	public gameManeger gm;
	public tileGenerator sd;
	void FixedUpdate()
	{
		RaycastHit hit;
		while( n ){
			if (Physics.Raycast (transform.position, -Vector3.up, out hit)) {
				//return;//print ("Found an object - distance: " + hit.distance);
				if(hit.collider.tag == "endpnt"){
					gm.ld ();
				}
				if (hit.collider.tag == "endpntarc") {
					sd.ns =  PlayerPrefs.GetFloat ("score");
					sd.ns++;
					//gm.arcscore = gm.arcscore + gm.ns;
					PlayerPrefs.SetFloat ("score", sd.ns);
					gm.restart2 ();
					print ("ok something is wrong!");
					n = false;

				}
				//print ("sa" + hit.collider.tag.ToString ());
				return;
			} else {
				//print ("nothing found!");
				gm.restart();
				print ("FUCK ME!");
				n = false;
			}
		}
	}

}
