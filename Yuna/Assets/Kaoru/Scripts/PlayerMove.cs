using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Yuna.Player
{
    public class PlayerMove : ManagedMono
    {
        Rigidbody2D rb;
        PlayerStateController stateCtrl;

        /// <summary>トロッコの左右移動スピード：デフォルト値100</summary>
        [SerializeField] float speed = 10;
        /// <summary>トロッコのジャンプ上昇値：デフォルト値100</summary>
        [SerializeField] float jumpForce = 100;
        /// <summary>トロッコのスピード閾値：デフォルト値500</summary>
        [SerializeField] float speedThreshold = 500;

        private bool isGround = true;
        private bool jumpProp = true;

        private void Start()
        {
            stateCtrl = new PlayerStateController();
            rb = this.gameObject.GetComponent<Rigidbody2D>();
        }
        public override void MFixedUpdate()
        {
            Move();
        }
        void Move()
        {
            Vector2 vec = Vector2.zero;
            Vector2 jump = Vector2.zero;
            if (isGround && rb.velocity.magnitude < speedThreshold)//接地中
            {
                jumpProp = true;
                if (Input.GetKey(KeyCode.D))
                {
                    vec = new Vector2(speed, 0);
                    stateCtrl.Drive();
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    vec = new Vector2(-speed, 0);
                    stateCtrl.Drive();
                }
            }
            else//空中(左右移動スピード落とす？)
            {
                Debug.Log("SpeedLimit/InSky");
                if (rb.velocity.magnitude < speedThreshold)
                {
                    if (Input.GetKey(KeyCode.D))
                    {
                        vec = new Vector2(speed / 4, 0);
                        stateCtrl.Drive();
                    }
                    else if (Input.GetKey(KeyCode.A))
                    {
                        vec = new Vector2(-speed / 4, 0);
                        stateCtrl.Drive();
                    }
                }
            }
            if (jumpProp)
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    stateCtrl.Jump();
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
