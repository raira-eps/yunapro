using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable, CreateAssetMenu(fileName = "AudioList", menuName = "AudioList/Create")]

public class BGMList : ScriptableObject
{
    public List<BGMContent> BGMContents = new List<BGMContent>();
    Dictionary<BGMTag, AudioClip> BGMDics = new Dictionary<BGMTag, AudioClip>();

    public Dictionary<BGMTag, AudioClip> BgmDics
    {
        get
        {
            if (BGMDics == null || BGMDics.Count == 0)
            {
                foreach (var item in BGMContents)
                {
                    BGMDics.Add(item.BGMName, item.BGMClip);
                }
            }
            return BGMDics;
        }

    }
}
[System.Serializable]
public class BGMContent
{
    public BGMTag BGMName;
    public AudioClip BGMClip;
}

public enum BGMTag
{
    /*
    //any tag
    /// <summary>選択音</summary>
    Select,
    /// <summary>敵の発砲音</summary>
    Shoot,
    /// <summary>リザルト画面で鳴る音</summary>
    Result
    */
};
