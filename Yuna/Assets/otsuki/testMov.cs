using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Yuna
{
    public class testMov : ManagedMono
    {
        private Animator anim = null;
        public float speed = 2.0f;
        // Start is called before the first frame update
        void Start()
        {
            anim = GetComponent<Animator>();
        }
        public override void MUpdate()
        {
            Vector3 mov = Vector3.zero;
            if (Input.GetKey(KeyCode.UpArrow))
            {
                mov += Vector3.up * speed;
                anim.SetBool("moveUp", true);
                anim.SetBool("goDown", false);
                anim.SetBool("moveRight", false);
                anim.SetBool("moveLeft", false);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                mov += Vector3.down * speed;
                anim.SetBool("goDown", true);
                anim.SetBool("moveUp", false);
                anim.SetBool("moveRight", false);
                anim.SetBool("moveLeft", false);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                mov += Vector3.right * speed;
                anim.SetBool("moveRight", true);
                anim.SetBool("moveUp", false);
                anim.SetBool("goDown", false);
                anim.SetBool("moveLeft", false);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                mov += Vector3.left * speed;
                anim.SetBool("moveLeft", true);
                anim.SetBool("moveUp", false);
                anim.SetBool("goDown", false);
                anim.SetBool("moveRight", false);
            }
            transform.position += mov;
        }
    }
}
