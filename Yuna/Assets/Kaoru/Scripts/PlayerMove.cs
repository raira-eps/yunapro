using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Yuna
{
    public class PlayerMove : ManagedMono
    {
        Rigidbody2D rb;
        Vector2 vec = new Vector2(150, 0);
        [SerializeField] int a;
        [SerializeField] int b;
        private void Start()
        {
            rb = this.gameObject.GetComponent<Rigidbody2D>();
        }
        public override void MUpdate()
        {
            a++;
        }
        public override void MFixedUpdate()
        {
            b++;
        }
    }
}
