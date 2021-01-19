﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_time : StateMachineBehaviour
{
readonly float minTime = 1;
readonly float maxTime = 3;

float timer = 0;

string[] triggers = {"attack02", "attack"};

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
   /* override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (playAnim)
          StartCoroutine(WaitAnim()); //wait random seconds for animation
    }*/

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(timer <= 0){
			timer = Random.Range(minTime, maxTime);
			randomAnimation(animator);
		} else {
			timer -= Time.deltaTime;
		}
    }

	void randomAnimation(Animator animator){
		System.Random rnd = new System.Random();
		int animationId = rnd.Next(triggers.Length);
		string animationString = triggers[animationId];
		animator.SetTrigger(animationString);
	}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}

 /* public IEnumerator WaitAnim()
  {
      playAnim = false;              
      int randomWait = Random.Range(0, 10);                
      print ("Time" + randomWait + " Play"); //debug                
      yield return new WaitForSeconds(randomWait);                
       animation.Play("Blink");;  //Put your animation string
      playAnim = true;             
  }*/
}
