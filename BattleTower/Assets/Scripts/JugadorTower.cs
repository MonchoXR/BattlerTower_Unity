using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorTower : MonoBehaviour
{
    
    public GameObject Bullet;
    public Transform posSpawn;

    public int damage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            Disparo();
        }

          if(Input.GetKeyDown(KeyCode.K))
        {
            Disparo();
        }

          if(Input.GetKeyDown(KeyCode.L))
        {
            Disparo();
        }
    }

    void Disparo(){
          Instantiate(Bullet, posSpawn.position, transform.rotation);
    }
}
