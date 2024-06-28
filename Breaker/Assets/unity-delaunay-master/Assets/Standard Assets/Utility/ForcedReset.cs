using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof (Texture))]
public class ForcedReset : MonoBehaviour
{
    private void Update()
    {
        // if we have forced a reset ...
#pragma warning disable CS0436 // 型がインポートされた型と競合しています
        if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
#pragma warning restore CS0436 // 型がインポートされた型と競合しています
        {
            //... reload the scene
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
    }
}
