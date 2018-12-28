using UnityEngine;
using System.Collections;

public class HelicopterShooting : MonoBehaviour {



    public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);

    public GameObject bulletPrefab;

    public float fireDelay = 0.25f;
    float cooldownTimer = 2;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        cooldownTimer -= Time.deltaTime;

        if (cooldownTimer <= 0)
        {
            //ENEMY SHOOTING
            cooldownTimer = fireDelay;

            Vector3 offest = transform.rotation * bulletOffset;

            Instantiate(bulletPrefab, transform.position + offest, transform.rotation);
        }
	
	}
}
