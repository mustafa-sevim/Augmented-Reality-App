using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbtn_pic : MonoBehaviour
{
    public Animator anim;
    public VirtualButtonBehaviour vb;
    // Start is called before the first frame update
    void Start()
    {
        vb.RegisterOnButtonPressed(OnButtonPressed);
        vb.RegisterOnButtonReleased(OnButtonReleased);
    }

    // Update is called once per frame
    void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        anim.Play("billboard_picture_animation");
    }

    void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        anim.Play("billboard_picture_animation_back");
    }

}
