using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
	public float speed = 5f;
	public float maxSpeed;  //Sin usar 

	private int[] objetosColeccionados = new int[3];	//guarda los objetos que se han coleccionado
	//hacer una variable para el objeto que tenga actualmente

    void Update()
    {
		Movement();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Objeto")
		{
			Object.Destroy(collision.gameObject);
		}
	}
	void Movement()
	{
		if (Input.GetKey(KeyCode.A))
			this.transform.Translate(new Vector3(-speed * Time.deltaTime, 0f, 0f));
		if (Input.GetKey(KeyCode.D))
			this.transform.Translate(new Vector3(+speed * Time.deltaTime, 0f, 0f));
		if (Input.GetKey(KeyCode.W))
			this.transform.Translate(new Vector3(0f, +speed * Time.deltaTime, 0f));
		if (Input.GetKey(KeyCode.S))
			this.transform.Translate(new Vector3(0f, -speed * Time.deltaTime, 0f));
	}
}
