print('这个是 main.lua')


-- obj
local obj = CS.UnityEngine.GameObject()
obj.name = 'LuaCreat'

local rb = obj:AddComponent(typeof(CS.UnityEngine.Rigidbody))
rb.mass = 5
rb.useGravity = false


-- new  test类
local testClass = CS.CSharp.Test()

-- event
local function lua_event1()
    print('lua 中定义的call back 1 函数 执行一些逻辑')
end

local function lua_event2()
    print('lua 中call back 2')
end

testClass:TestEvent('+',lua_event1)
testClass:TestEvent('+',lua_event2)

testClass:CallEvent()

testClass:TestEvent('-',lua_event1)
print('已经执行过事件移除操作，现在事件中只有回调函数2')
testClass:CallEvent()
testClass:TestEvent('-',lua_event2)
print('------------------remove all event --------------------')
testClass:CallEvent()


