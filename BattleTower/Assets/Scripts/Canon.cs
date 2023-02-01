using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
  public Vector3 dirBullet;
  public float TimeDestroy=4f;
  public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dirBullet*speed*Time.deltaTime);
        Destroy(gameObject,TimeDestroy);

        if(Input.GetKeyDown(KeyCode.Space)){
          transform.localScale += new Vector3(0.2f,0.2f, 0.2f);
        }
    }
}
