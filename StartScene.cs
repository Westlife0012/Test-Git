using UnityEngine;
using System.Collections;

public class StartScene : MonoBehaviour {

	public MovieTexture myMovie;
	private AudioSource myAudio;
	private bool isPlay=true;
	// Use this for initialization
	void Start () {
		myMovie.Play ();
		myMovie.loop = true;
		myAudio =this.GetComponent<AudioSource> ();
		myAudio.Play ();
		myAudio.loop = true;
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	public void movieJump(){
		Application.LoadLevel ("SkillCD");
	}
	public void moviePause()
	{
		if (isPlay) {
			myMovie.Pause ();
			myAudio.Pause ();
			isPlay = false;
		} else {
			myMovie.Play ();
			myAudio.Play ();
			isPlay = true;
		}
	}
}
