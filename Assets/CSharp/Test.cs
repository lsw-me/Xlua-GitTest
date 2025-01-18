using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using XLua;

namespace CSharp
{
    [LuaCallCSharp]
    public class Test
    {
        public event Action TestEvent;

        public void CallEvent()
        {
            TestEvent?.Invoke();
        }

        public void Start()
        {

        }
    }
    
}
