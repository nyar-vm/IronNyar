using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Expressions;


namespace IronNyar.Object
{

    public abstract class Self : Ouroboros.Self
    {
        #region Getter
        /// <summary>
        /// @return String: Markdown 注释文档
        /// </summary>
        public virtual string __help__
        {
            get
            {
                return "";
            }
        }
        /// <summary>
        /// @return String: 简单格式化的源代码
        /// </summary>
        public virtual string __code__
        {
            get
            {
                Console.WriteLine("RuntimeError: Build in object - {0}", this.__self__);
                return null;
            }
        }
        /// <summary>
        /// @return String: REPL 中输出的内容
        /// </summary>
        public virtual string __text__
        {
            get
            {
                return "";
            }
        }

        /// <summary>
        /// @return ArcObject: 序列化的字典形式
        /// </summary>
        public virtual string __dict__
        {
            get
            {
                return "";
            }
        }

        /// <summary>
        /// @return Byte[]: 二进制对象
        /// </summary>
        public virtual byte[] __byte__
        {
            get
            {
                return new byte[] { 0x00 };
            }
        }

        /// <summary>
        /// @return Byte[]: ID
        /// </summary>
        public virtual byte[] __hash__
        {
            get
            {
                var hash = this.GetHashCode();
                return BitConverter.GetBytes(hash);
            }
        }
        /// <summary>
        /// @return Type: 此类
        /// </summary>
        public virtual Type __type__
        {
            get
            {
                return this.GetType();
            }
        }

        /// <summary>
        /// @return Type: 此类
        /// </summary>
        override public object __self__
        {
            get
            {
                return this;
            }
        }
        /// <summary>
        /// @return Type: 父类
        /// </summary>
        override  public object __super__
        {
            get
            {
                return this.GetType().BaseType;
            }
        }
        #endregion
        #region Expando Override
        public override IEnumerable<string> GetDynamicMemberNames()
        {
            return base.GetDynamicMemberNames();
        }
        public override DynamicMetaObject GetMetaObject(Expression parameter)
        {
            return base.GetMetaObject(parameter);
        }
        public override bool TryBinaryOperation(BinaryOperationBinder binder, object arg, out object result)
        {
            return base.TryBinaryOperation(binder, arg, out result);
        }

        public override bool TryConvert(ConvertBinder binder, out object result)
        {
            return base.TryConvert(binder, out result);
        }

        public override bool TryCreateInstance(CreateInstanceBinder binder, object[] args, out object result)
        {
            return base.TryCreateInstance(binder, args, out result);
        }

        public override bool TryDeleteIndex(DeleteIndexBinder binder, object[] indexes)
        {
            return base.TryDeleteIndex(binder, indexes);
        }

        public override bool TryDeleteMember(DeleteMemberBinder binder)
        {
            return base.TryDeleteMember(binder);
        }

        public override bool TryGetIndex(GetIndexBinder binder, object[] indexes, out object result)
        {
            return base.TryGetIndex(binder, indexes, out result);
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            return base.TryGetMember(binder, out result);
        }

        public override bool TryInvoke(InvokeBinder binder, object[] args, out object result)
        {
            return base.TryInvoke(binder, args, out result);
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            return base.TryInvokeMember(binder, args, out result);
        }

        public override bool TrySetIndex(SetIndexBinder binder, object[] indexes, object value)
        {
            return base.TrySetIndex(binder, indexes, value);
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            return base.TrySetMember(binder, value);
        }

        public override bool TryUnaryOperation(UnaryOperationBinder binder, out object result)
        {
            return base.TryUnaryOperation(binder, out result);
        }
        #endregion
    }
}
