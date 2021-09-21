using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidPlugin : MonoBehaviour
{
    public void Start()
    {
        CallHello();
        CallHelloStatic();
    }

    public static void CallHello()
    {
        using (AndroidJavaObject plugin = new AndroidJavaObject("com.takafumiko.sampleplugin.HelloWorld"))
        {
            plugin.Call("Hello","takafumi-ko");
        }
    }

    public static void CallHelloStatic()
    {
        using (AndroidJavaClass clazz = new AndroidJavaClass("com.takafumiko.sampleplugin.HelloWorld"))
        {
            clazz.CallStatic("HelloStatic","takafumi-ko");
        }
        
    }
}
