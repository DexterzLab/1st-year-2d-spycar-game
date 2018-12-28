using UnityEngine;
using System.Collections;

public class Other_Move : MonoBehaviour {

    // https://unity3d.com/learn/tutorials/projects/space-shooter-tutorial/extending-space-shooter-enemies-more-hazards?playlist=17147 accessed 13th 10th november, published N/A

    public float speed;
    private Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.up * speed;
    }

    // Update is called once per frame
    void Update () {
	
	}

}
