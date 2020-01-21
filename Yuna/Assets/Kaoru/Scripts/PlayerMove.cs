using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Yuna.Player
{
    public class PlayerMove : ManagedMono
    {
        [SerializeField] Rigidbody2D rb;
        [SerializeField] float speed = 10;
        [SerializeField] float jumpForce = 10;
        private void Start()
        {

        }
        public override void MFixedUpdate()
        {
            Move();
        }
        void Move()
        {
            if (Input.GetKey(KeyCode.D))
            {
                Vector2 vec = new Vector2(speed, 0);
                rb.AddForce(vec * 100);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                Vector2 vec = new Vector2(speed, 0);
                rb.AddForce(vec * -100);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Vector2 vec = new Vector2(0, jumpForce);
                rb.AddForce(vec * 100);
            }
        }
    }
}
