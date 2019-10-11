using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class LaunchByButton : MonoBehaviour
{
    public string AppPath;
    Process proc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonPushed()
    {
        proc = new Process();
        proc.StartInfo.FileName = AppPath;
        proc.Start();
    }

    private void OnApplicationQuit()
    {
        // 別アプリ終了処理

        if (!proc.HasExited)
        {
            // 別アプリが起動中の場合のみ終了させる
            proc.CloseMainWindow();
        }

        proc.Close();
        proc = null;
    }
}
