---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by ME.
--- DateTime: 2025/1/12 21:22
---

a = 1
b = true
c = 'hello world'
table1 = { f1 = 13,f2 = 34,
           1,2,3,
           add = function(self,a,b)
               print('a + b')
               return a+b
           end
}
function fun1()
    print('this is a func')
end
function fun2(a,b)
    print('a is ', a ,'b is ',b)
    return 1,{f1 = 1024}
end
function retFunc()
    print('ret called')
    return e
end
