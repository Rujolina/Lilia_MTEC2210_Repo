using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour

{
  public float speed;

  private SpriteRenderer sr;



    // Start is called before the first frame update
    void Start()
    {
      //sr = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

      if (Input.GetKey(KeyCode.D))
      {
        transform.Translate(speed * Time.deltaTime, 0, 0);

      }
      if (Input.GetKey(KeyCode.A))
      {
        transform.Translate(-(speed * Time.deltaTime), 0, 0);
      }
      if (Input.GetKey(KeyCode.W))
      {
        transform.Translate(0,speed * Time.deltaTime, 0);
      }
      if (Input.GetKey(KeyCode.S))
      {
        transform.Translate(0,speed * -(Time.deltaTime), 0);
      }

    }
}
