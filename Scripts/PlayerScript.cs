using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
	public float speed;
	public float maxSpeed;
	private Vector3 position;


    void Update()
    {
		Vector3 aux = this.transform.position;
        if(Input.GetKey(KeyCode.A))
		{
			this.transform.position = new Vector3(aux.x - speed * Time.deltaTime, aux.y, 0f);
		}
		if (Input.GetKey(KeyCode.D))
		{
			this.transform.position = new Vector3(aux.x + speed * Time.deltaTime, aux.y, 0f);
		}
		if (Input.GetKey(KeyCode.W))
		{
			this.transform.position = new Vector3(aux.x, aux.y + speed * Time.deltaTime, 0f);
		}
		if (Input.GetKey(KeyCode.S))
		{
			this.transform.position = new Vector3(aux.x, aux.y - speed * Time.deltaTime, 0f);
		}
	}
}
