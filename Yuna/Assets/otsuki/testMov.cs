using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Yuna
{
    public class testMov : ManagedMono
    {
#if false
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
#endif

#if true
        private Animator anim;
        [SerializeField] float speed = 0f;
        string setAnimState = null;

        private void Start()
        {
            anim = GetComponent<Animator>();
        }
        public override void MFixedUpdate()
        {
            Move();
        }
        void Move()
        {
            bool isWalk = false;
            int direction = -1;
            Vector3 move = Vector3.zero;
            float correction = 1f;
            if (Input.GetKey(KeyCode.UpArrow))
            {
                correction = 0.75f;
                move += Vector3.up;
                direction = 2;
                isWalk = true;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                correction = 0.75f;
                move += Vector3.down;
                direction = 0;
                isWalk = true;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                move += Vector3.right;
                direction = 1;
                transform.localScale = new Vector3(1, 1, 1);
                isWalk = true;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                move += Vector3.left;
                direction = 1;
                transform.localScale = new Vector3(-1,1,1);
                isWalk = true;
            }


            anim.SetBool("isWalk", isWalk);
            anim.SetInteger("direction", direction);

            transform.position += move * speed * correction;
        }
#endif
    }

}
