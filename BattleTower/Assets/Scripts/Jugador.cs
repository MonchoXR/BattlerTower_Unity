using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public Vector3 direccion;
    public float velocidad = 1f;
  
    [SerializeField]private int vida = 0;
 
    float timeSuma = 0f;
    float timeResta = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
       Movimiento();

      timeSuma=timeSuma+Time.deltaTime;
    
         
      if((int)(timeSuma)<6){
          
           AumentarVida();
          }
          else{
           DisminuirVida();
          }    
       
    
      
    }

    void Movimiento(){
         transform.Translate(direccion*velocidad* Time.deltaTime) ;
    
    }
    void AumentarVida(){   
    
         vida=(int)timeSuma;

        if(vida==5){
            timeResta=5;
        }
    
    }

    void DisminuirVida(){
       timeResta=timeResta-Time.deltaTime;
        vida =(int)timeResta;
        if(vida==0){
            timeSuma=0;
        }
    }
}
