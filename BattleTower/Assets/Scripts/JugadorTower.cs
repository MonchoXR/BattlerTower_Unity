using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorTower : MonoBehaviour
{
    
    public GameObject Bullet;
    public Transform posSpawn;

    public int damage;

    float tiempoOriginal;
    public float temporizador =2f;
    void Start()
    {
        tiempoOriginal = temporizador;
    }

    // Update is called once per frame
    void Update()
    {
  
        Temporizador();
    }

    void Disparo(){
          Instantiate(Bullet, posSpawn.position, transform.rotation);
      
    }

    void Temporizador(){
            temporizador -=Time.deltaTime;
            if(temporizador <=0){
                Disparo();
                ResetTemporizador();
               
                Debug.Log("Se acabo el tiempo");
            }

    }

    void ResetTemporizador(){
        temporizador = tiempoOriginal;
    }

 
}
