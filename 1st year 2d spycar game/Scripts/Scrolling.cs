using UnityEngine;
using System.Collections;

public class Scrolling : MonoBehaviour {

    // https://unity3d.com/learn/tutorials/topics/2d-game-creation/2d-scrolling-backgrounds accessed 10th november, published N/A

    public float scrollSpeed;

    Renderer renderer;

    // Use this for initialization
    void Start () {
        renderer = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        float y = Mathf.Repeat(Time.time * scrollSpeed, 1);
        Vector2 offset = new Vector2(0, y);
        renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
