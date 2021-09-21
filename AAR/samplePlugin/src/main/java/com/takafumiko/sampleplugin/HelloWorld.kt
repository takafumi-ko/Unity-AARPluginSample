package com.takafumiko.sampleplugin

import android.util.Log

class HelloWorld {
    companion object{
        @JvmStatic
        fun HelloStatic(name: String){
            Log.d("plugin","Hello, Static! $name")
        }
    }

    fun Hello(name:String){
        Log.d("plugin","Hello, World! $name")
    }
}