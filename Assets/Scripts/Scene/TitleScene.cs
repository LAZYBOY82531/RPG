using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScene : BaseScene
{
    public void OnStartButton()
    {
        GameManager.Scene.LoadScene("GameScene");
    }

    protected override IEnumerator LoadingRoutine()
    {
        throw new System.NotImplementedException();
    }
}
