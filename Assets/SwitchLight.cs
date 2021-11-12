using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLight : MonoBehaviour
{
    private static int turn = 0;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Switch()
    {
        if(turn == 0){
            anim.Play("light_switchOff");
            anim.speed = 10f;
            turn++;
        }
        else if(turn == 1){
            anim.Play("light_switchOn");
            anim.speed = 10f;
            turn = 0;
        }
    }
}
