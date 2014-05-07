using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public AudioClip[] soundClips;
	private float timer = 0.0f;
	
	void Update()
	{
		timer += Time.fixedDeltaTime;
	}

	void OnTriggerEnter(Collider other)
	{
		string itemTag = other.gameObject.tag;
		
		if(itemTag == "Goal" && GameManager.GetPower() == 3)
		{
			audio.clip = soundClips[4];
			audio.PlayOneShot(audio.clip);
			
			GameManager.CompleteLevel();
		}
		
		else if(itemTag == "Collectible")
		{

			audio.clip = soundClips[0];
			audio.PlayOneShot(audio.clip);

		}
		else if(itemTag == "Switch")
		{
			audio.clip = soundClips[2];
			audio.PlayOneShot(audio.clip);
		}
		else if(itemTag == "Change Ball")
		{
			audio.clip = soundClips[1];
			audio.PlayOneShot(audio.clip);
		}
		else if (itemTag == "Electric")
		{
			audio.clip = soundClips[3];
			audio.PlayOneShot(audio.clip);
		}
		else if (itemTag == "Enemy" || itemTag == "Hurts")
		{
			audio.clip = soundClips[5];
			audio.PlayOneShot(audio.clip);
		}



		
	}
}