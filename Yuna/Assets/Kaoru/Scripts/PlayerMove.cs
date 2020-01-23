using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Yuna.Player
{
    public class PlayerMove : ManagedMono
    {
        [SerializeField] Rigidbody2D rb;
        /// <summary>トロッコの左右移動スピード：デフォルト値100</summary>
        [SerializeField] float speed=10;
        /// <summary>トロッコのジャンプ上昇値：デフォルト値100</summary>
        [SerializeField] float jumpForce = 100;
        private bool isGround = true;
        private bool jumpProp = true;
        public override void MFixedUpdate()
        {
            Move();
        }
        void StateManager()
        {

        }
        void Move()
        {
            Vector2 vec = Vector2.zero;
            Vector2 jump = Vector2.zero;
            if (isGround)//接地中
            {
                jumpProp = true;
                if (Input.GetKey(KeyCode.D))
                {
                    vec = new Vector2(speed, 0);
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    vec = new Vector2(-speed, 0);
                }
                rb.AddForce(vec * 100);
            }
            else//空中(左右移動スピード落とす？)
            {
                
            }
            if (jumpProp)
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    isGround = false;
                    jump = new Vector2(0, jumpForce);
                    jumpProp = false;
                }
            }

            rb.AddForce((vec + jump) * 100);
        }
        private void OnCollisionEnter2D(Collision2D c)
        {
            if (c.gameObject.tag == "Ground")
            {
                isGround = true;
            }
        }
    }
}
