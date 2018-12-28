using UnityEngine;
using System.Collections;

public class Boundary : MonoBehaviour {

    Rigidbody rigidbody;
    public float xMin, xMax, yMin, yMax;

	void FixedUpdate()
    {
        rigidbody.position = new Vector3(Mathf.Clamp (rigidbody.position.x, xMin, xMax), Mathf.Clamp (rigidbody.position.y, yMin, yMax));
    }

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
}
