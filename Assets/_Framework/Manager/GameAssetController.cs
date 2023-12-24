using System.Collections.Generic;
using UnityEngine;

public class GameAssetController : AssetController
{
    [SerializeField] List<AssetGetter> assetGetterList;
    public override void UpdateAssetList(List<AssetGetter> getterList)
    {
        getterList.Clear();
        getterList.AddRange(assetGetterList);
    }
}
