using UnityEngine;
using UnityEngine.UI;
public class tileGenerator : MonoBehaviour {
	public GameObject tile;
	public float ns;
	public Text fs;
	// Use this for initialization
	void Start () {
		Instantiate (tile, transform.position + transform.TransformDirection (Vector3.forward)*2, Quaternion.identity);
	}
	void Update(){
		fs.text = "Score : " + ns;
	}
}
