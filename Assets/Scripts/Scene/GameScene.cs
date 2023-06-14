using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : BaseScene
{
    public GameObject playerPrefab;
    public Transform playerPosition;

    protected override IEnumerator LoadingRoutine()
    {
        progress = 0f;
        Debug.Log("·£´ý ¸Ê »ý¼º");
        yield return new WaitForSecondsRealtime(1f);
        progress = 0.2f;
        Debug.Log("·£´ý ¸Ê »ý¼º");
        yield return new WaitForSecondsRealtime(1f);
        progress = 0.4f;
        Debug.Log("ÇÃ·¹ÀÌ¾î ¹èÄ¡");
        GameObject player = Instantiate(playerPrefab, playerPosition.position, playerPosition.rotation);
        yield return new WaitForSecondsRealtime(1f);
        progress = 0.7f;
        Debug.Log("·£´ý ¸Ê »ý¼º");

        yield return new WaitForSecondsRealtime(1f);
        progress = 1f;
    }
}
