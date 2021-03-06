﻿using UnityEngine;
using System.Collections;

public class ToadCollision : MonoBehaviour {

    public Transform explosionPrefab;
    public int scoreValue;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision c)
    {

        if (c.collider.name == "fishing_boat" || c.collider.name == "Shooting_Wave(Clone)")
        {
            ContactPoint contact = c.contacts[0];
            Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
            Vector3 pos = contact.point;
            Instantiate(explosionPrefab, pos, rot);
            // Add corresponding score
            scoreManager.UpdateScore(scoreValue);

            // Destroy all part of the toad
            Destroy(gameObject);
            GameObject wepon = GetComponent<MeshCollider>().gameObject;
            Destroy(wepon);
        }

        if (c.collider.name == "Shooting_Wave(Clone)")
        {
            Destroy(c.gameObject);
        }
    }
}
