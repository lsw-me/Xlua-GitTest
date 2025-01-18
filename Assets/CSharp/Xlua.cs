using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XLua;
namespace CSharp
{
    public class Xlua : MonoBehaviour
    {
        LuaEnv luaEnv = new LuaEnv();
        private string path = "Assets/Lua/Main.lua";
        
        private void Start()
        {
            luaEnv.DoString(File.ReadAllText(path));
            
        }
    }
}

