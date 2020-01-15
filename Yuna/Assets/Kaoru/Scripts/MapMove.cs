using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yuna
{
    public class MapMove : ManagedMono
    {
        Transform trans;
        [SerializeField] float speed;
        private void Start()
        {
            trans = this.gameObject.GetComponent<Transform>();
        }
        public override void MFixedUpdate()
        {
            Vector3 pos = trans.position;
            pos.x -= speed;
            trans.position = pos;
        }

    }
}