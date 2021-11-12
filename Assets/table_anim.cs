using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class table_anim : MonoBehaviour
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

    public void TableRotation()
    {
        if(turn == 0){
            anim.Play("rotateTable1");
            anim.speed = 1f;
            turn++;
        }
        else if(turn == 1){
            anim.Play("rotateTable2");
            anim.speed = 1f;
            turn++;
        }
        else if(turn == 2){
            anim.Play("rotateTable3");
            anim.speed = 1f;
            turn++;
        }
        else if(turn == 3){
            anim.Play("rotateTable4");
            anim.speed = 1f;
            turn = 0;
        }
    }

}
