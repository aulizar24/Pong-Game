using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed=20;
    public Rigidbody2D sesuatu;
    public Animator animtr;
    void Start()
    {
		  sesuatu.velocity = new Vector2(-1,-1)*speed;
      animtr.SetBool("IsMove", true);  
    }

    // Update is called once per frame
    void Update()
    {
        if(sesuatu.velocity.x > 0){ //bola ke kanan
            sesuatu.GetComponent<Transform>().localScale = new Vector3(1,1,1);
        } else {
            sesuatu.GetComponent<Transform>().localScale = new Vector3(-1,1,1);
        }
    }
    void OnCollisionEnter2D(Collision2D other){
      if(other.collider.name=="TembokKanan"||other.collider.name=="TembokKiri"){
        StartCoroutine(jeda());
      }
    }
    IEnumerator jeda(){
      sesuatu.velocity = Vector2.zero; // kecepatan 0
      animtr.SetBool("IsMove", false);
      sesuatu.GetComponent<Transform>().position = new Vector2(0,0);
      yield return new WaitForSeconds(1);
      sesuatu.velocity = new Vector2(-1,-1)*speed;
      animtr.SetBool("IsMove", true);   
    }
}
