﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public Transform LoadingBar;

    [SerializeField]
    private float currentAmount;
    [SerializeField]
    private float speed;

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Scene on loaded is: " + StaticCode.scene_onload);

        StartCoroutine(LoadAR(StaticCode.scene_onload));
    }

    IEnumerator LoadAR(string ar)
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(ar);
        async.allowSceneActivation = false;

        while (!async.isDone)
        {
            float progress = Mathf.Clamp01(async.progress / 0.9f);
            LoadingBar.GetComponent<Image>().fillAmount = progress;

            if (async.progress >= 0.9f)
            {
                async.allowSceneActivation = true;
            }

            yield return null;
        }
    }
}