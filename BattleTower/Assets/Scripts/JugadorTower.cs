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
        Disparo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Disparo(){
          Instantiate(Bullet, posSpawn.position, transform.rotation);
    }
}
