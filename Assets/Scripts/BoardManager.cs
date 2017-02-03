using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour {
   public GameObject panelFab;

	// Use this for initialization
	void Start () {
        
        Instantiate(panelFab, transform.position + (transform.right * -2), transform.rotation);
        Instantiate(panelFab, transform.position + (transform.right * -4), transform.rotation);
        Instantiate(panelFab, transform.position + (transform.right * -6), transform.rotation);
        Instantiate(panelFab, transform.position + (transform.right * -2) + (transform.up * 2), transform.rotation);
        Instantiate(panelFab, transform.position + (transform.right * -4) + (transform.up * 2), transform.rotation);
        Instantiate(panelFab, transform.position + (transform.right * -6) + (transform.up * 2), transform.rotation);
        Instantiate(panelFab, transform.position + (transform.right * -2) + (transform.up * -2), transform.rotation);
        Instantiate(panelFab, transform.position + (transform.right * -4) + (transform.up * -2), transform.rotation);
        Instantiate(panelFab, transform.position + (transform.right * -6) + (transform.up * -2), transform.rotation);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
