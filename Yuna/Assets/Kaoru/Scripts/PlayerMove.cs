using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Yuna
{
    public class PlayerMove : ManagedMono
    {
        [SerializeField] Rigidbody2D rb;
        [SerializeField] int speed = 10;
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
        }
    }
}
