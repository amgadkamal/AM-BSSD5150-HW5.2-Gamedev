using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class gamecontrol : MonoBehaviour
{  
    [SerializeField]   
     private GameObject spawnPoint; 
     private Rigidbody2D rb; 
     
     private void OnTriggerEnter2D(Collider2D collision)                                                                 
        {                                                                                                                   
            if (collision.gameObject.tag == "goal")                                                                         
            {                                                                                                               
                this.gameObject.transform.SetPositionAndRotation(spawnPoint.transform.position, Quaternion.identity);       
            }                                                                                                               
        }  
     
     private void OncollisionEnter2D(Collision2D collision)       
     {                                                            
         rb.AddForce(new Vector2(0, 300), ForceMode2D.Impulse);   
     }                                                            
}
