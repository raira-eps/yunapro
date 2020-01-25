using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Yuna.Player
{
    //主にプレイヤーのアニメーションの制御とかに使う予定。
    //DriveとかJumpじゃなくて、ほかに使い道があるはず。。。
    public class PlayerStateController : ManagedMono
    {
        /// <summary>変更前の状態 </summary>
        private string _beforeStateName;

        public StateProcessor StateProcessor = new StateProcessor();
        public PlayerDefalt PlayerDefalt = new PlayerDefalt();
        public PlayerJump PlayerJump = new PlayerJump();
        public PlayerDrive PlayerDrive = new PlayerDrive();
        
        void Start()
        {
            StateProcessor.State = PlayerDefalt;
            PlayerDefalt.execDelegate = Default;
            PlayerDrive.execDelegate = Drive;
            PlayerJump.execDelegate = Jump;
        }
        public override void MUpdate()
        {
            Debug.Log(StateProcessor.State);
            if (StateProcessor.State == null) return;
            if (StateProcessor.State.getStateName() != _beforeStateName)
            {
                _beforeStateName = StateProcessor.State.getStateName();
                StateProcessor.Execute();
            }
        }
        public void Default()
        {
            Debug.Log("Defalt_");
        }
        public void Drive()
        {
            Debug.Log("Drive_");
        }
        public void Jump()
        {
            Debug.Log("Jump");
        }
    }
}
