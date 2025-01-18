using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using System.IO;
using XLua;
using File = System.IO.File;

namespace CSharp
{

    //对应lua  映射到一个类
    public class TableClass
    {
        public int f1;
        public int f2;
    }
    
    
    public class CallLua :MonoBehaviour
    {
        private LuaEnv _luaEnv = null;
        private string scriptPath = "Assets/Lua/callLua.lua";

        private void Start()
        {
            _luaEnv = new LuaEnv();
            _luaEnv.DoString(File.ReadAllText(scriptPath));
            Demo();
        }


        private void Demo()
        {
            // c# 获取lua全局类型
            Debug.Log(_luaEnv.Global.Get<int>("a"));
            Debug.Log(_luaEnv.Global.Get<bool>("b"));
            Debug.Log(_luaEnv.Global.Get<string>("c"));
            // c# 将lua中的table 映射为class
            TableClass tc = _luaEnv.Global.Get<TableClass>("table1");
            //直接输出对应  映射到有对应字段的class，by value
            Debug.Log(tc.f1+ " <-f1输出 ：f2 输出 ->"+tc.f2);
            //映射字典
            Dictionary<string,double> tc1 = _luaEnv.Global.Get<Dictionary<string,double>>("table1");
            Debug.Log("_G.d = {f1=" + tc1["f1"] + ", f2=" + tc1["f2"] + "}");
            
            

        }
        
        
        
    }
}