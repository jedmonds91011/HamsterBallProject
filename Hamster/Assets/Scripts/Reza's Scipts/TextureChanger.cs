using UnityEngine;
using System.Collections;

public class TextureChanger : MonoBehaviour {

	public GameObject character;
	public Texture newTexture;
	private Texture oldTexture;
	private Shader newShader;
	private Shader oldShader;
	//private bool recentlyChanged = false;
	private float timer;

	//On start, the texture/shader assigned to the public texture slot in editor
	//is stored as the material/shader of the item this script is attached to
	void Start () 
	{
		newShader = Shader.Find ("Diffuse");
		gameObject.renderer.material.mainTexture = newTexture;
		gameObject.renderer.material.shader = newShader;
		oldShader = Shader.Find ("Transparent/Diffuse");
		timer = 2f;
	}

	void Update()
	{
		timer += Time.deltaTime;
	}

	// When the target (assigned in editor) object enters the trigger
	//their material/shader is changed to the material/shader that was
	//placed in the public slot within the editor.
	//then the old material/shader are stored in private varibales
	//This allows the object to switch materials multiple times. 
	void OnTriggerEnter (Collider collider) 
	{
		if (timer >= 2)
			{
			oldTexture = character.renderer.material.mainTexture;
			oldShader = character.renderer.material.shader;

			gameObject.renderer.material.mainTexture = oldTexture;
			gameObject.renderer.material.shader = oldShader;

			character.renderer.material.mainTexture = newTexture;
			character.renderer.material.shader = newShader;

			newTexture = oldTexture;
			newShader = oldShader;
			//recentlyChanged = true;
			timer = 0;
			} 
	}

}
