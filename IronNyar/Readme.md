

# TryGetMember
# TryInvoke
module.object.getter

# TrySetMember
module.object.setter = 1

# TryGetIndex
module.object[index]

# TrySetIndex
module.object[index] = 1


# TryDeleteMember

delete module.object.getter
module.object.getter = ~






extend member for module.object
extend module.object.member


create Trans extend mixin ()

向对象注入方法






## Getter

| Getter          | Remark        | Type          |
| :-------------- | :------------ | :------------ |
| `__property__`  | 一切属性      | `String[]`    |
| `__attribute__` | 特性          | `String[]`    |
| `__super__`     | 父类          |               |
| `__self__`      | 类名          |               |
| `__help__ `     | 文档          | `String`      |
| `__text__`      | REPL 中的返回 | `String`      |
| `__code__`      | 代码体        | `String`      |
| `__bytes__`     | 二进制对象    | `Byte[]`      |
| `__hash__`      | 哈希ID        | `Byte[]`      |
| `__dict__`      | 序列化        | `ArcObject[]` |
| `__getter__`    | 无状态        | `String[]`    |
| `__setter__`    | 带状态        | `String[]`    |
| `__invoke__`    | 无状态        | `String[]`    |
| `__method__`    | 带状态        | `String[]`    |
__module__	该函数所属模块的名称，没有则为 None。	可写


__global__	对存放该函数中全局变量的字典的引用 --- 函数所属模块的全局命名空间。	只读
__closure__	None 或包含该函数可用变量的绑定的单元的元组。有关 cell_contents 属性的详情见下。	只读
__annotation__	包含参数标注的字典。字典的键是参数名，如存在返回标注则为 'return'。	可写

__args__	由具有默认值的参数的默认参数值组成的元组，如无任何参数具有默认值则为 []	可写
__kws__	仅包含关键字参数默认值的字典。	`{}`



以上属性挂载在 Object 类上的, 所以是所有内置对象都有的

创建的类默认继承 Object 所以也都有

除非继承自 Ouroboros, 注意到 Object 是 Ouroboros 的实现

这样的对象没有内置的这么多特性, 但好处是很省内存

## Method


| Method           | Remark | Type |
| :--------------- | :----- | :--- |
| `__Create__`/`@` |
| `__Delete__`/`$` |






=(self)
prefix +()
suffix +()
operator +(a,b)

### Attributes

| Attribute  | Remark                       |
| :--------- | :--------------------------- |
| extendable | 无需 extend 关键词就可以扩展 |
| locked     | 无法修改 attribute           |
| protected  | 无法去掉 locked              |




