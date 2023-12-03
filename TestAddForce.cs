// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.Events;

// public class TestAddForce : MonoBehaviour
// {

//     [SerializeField]
//     private Rigidbody2D rb2d;

//     [SerializeField]
//     private float strength=16,delay=0.15f;

//     public UnityEvent OnBegin , OnDone;

// public void playFeedback(GameObject sender){
//     StopAllCoroutines();
//     OnBegin?.Invoke();


//     Vector2 direction= new Vector2(0,1);
//     rb2d.AddForce(direction*strength,ForceMode2D.Impulse);

//     StartCoroutine(Reset());
// }

// private IEnumerator Reset() {
// yield return new WaitForSeconds(delay);
// rb2d.velocity=Vector3.zero;
// OnDone?.Invoke();
// }

// }