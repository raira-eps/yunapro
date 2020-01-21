using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yuna.Player
{
    ///<summary>ステートの実行を管理するクラス</summary>
    public class StateProcessor
    {
        public PlayerState State { set; get; }
        /// <summary>実行ブリッジ</summary>
        public void Execute()
        {
            State.Execute();
        }

    }

    /// <summary>
    /// ステート処理クラス
    /// </summary>
    public abstract class PlayerState
    {

        public delegate void executeState();
        public executeState execDelegate;

        /// <summary>
        /// 実行処理
        /// </summary>
        public virtual void Execute()
        {
            if (execDelegate != null)
            {
                execDelegate();
            }
        }

        /// <summary>
        /// ステート名を取得するメソッド
        /// </summary>
        /// <returns>string型のステート名</returns>
        public abstract string getStateName();
    }

    //↓↓↓以下状態クラス↓↓↓

    public class IsGround : PlayerState
    {
        public override string getStateName()
        {
            return "IsGround";
        }
    }
    public class IsSky : PlayerState
    {
        public override string getStateName()
        {
            return "IsSky";
        }
    }
}