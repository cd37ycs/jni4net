//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Reflection {
    
    
    #region Component Designer generated code 
    public partial class ICustomAttributeProvider_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::System.Reflection.@__ICustomAttributeProvider.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.Reflection.ICustomAttributeProvider), typeof(global::System.Reflection.ICustomAttributeProvider_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Reflection.ICustomAttributeProvider), typeof(global::System.Reflection.ICustomAttributeProvider_))]
    internal sealed partial class @__ICustomAttributeProvider : global::java.lang.Object, global::System.Reflection.ICustomAttributeProvider {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_GetCustomAttributes0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_GetCustomAttributes1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_IsDefined2;
        
        private @__ICustomAttributeProvider(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.Reflection.@__ICustomAttributeProvider.staticClass = @__class;
            global::System.Reflection.@__ICustomAttributeProvider.j4n_GetCustomAttributes0 = @__env.GetMethodID(global::System.Reflection.@__ICustomAttributeProvider.staticClass, "GetCustomAttributes", "(Z)[Lsystem/Object;");
            global::System.Reflection.@__ICustomAttributeProvider.j4n_GetCustomAttributes1 = @__env.GetMethodID(global::System.Reflection.@__ICustomAttributeProvider.staticClass, "GetCustomAttributes", "(Lsystem/Type;Z)[Lsystem/Object;");
            global::System.Reflection.@__ICustomAttributeProvider.j4n_IsDefined2 = @__env.GetMethodID(global::System.Reflection.@__ICustomAttributeProvider.staticClass, "IsDefined", "(Lsystem/Type;Z)Z");
        }
        
        public object[] GetCustomAttributes(bool inherit) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<object[], object>(@__env, @__env.CallObjectMethodPtr(this, global::System.Reflection.@__ICustomAttributeProvider.j4n_GetCustomAttributes0, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(inherit)));
            }
        }
        
        public object[] GetCustomAttributes(global::System.Type attributeType, bool inherit) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<object[], object>(@__env, @__env.CallObjectMethodPtr(this, global::System.Reflection.@__ICustomAttributeProvider.j4n_GetCustomAttributes1, global::net.sf.jni4net.utils.Convertor.ParStrongC2Jp<global::System.Type>(@__env, attributeType), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(inherit)));
            }
        }
        
        public bool IsDefined(global::System.Type attributeType, bool inherit) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return ((bool)(@__env.CallBooleanMethod(this, global::System.Reflection.@__ICustomAttributeProvider.j4n_IsDefined2, global::net.sf.jni4net.utils.Convertor.ParStrongC2Jp<global::System.Type>(@__env, attributeType), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(inherit))));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__ICustomAttributeProvider);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetCustomAttributes", "GetCustomAttributes0", "(Z)[Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetCustomAttributes", "GetCustomAttributes1", "(Lsystem/Type;Z)[Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "IsDefined", "IsDefined2", "(Lsystem/Type;Z)Z"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetCustomAttributes0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, bool inherit) {
            // (Z)[Lsystem/Object;
            // (Z)[LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.ICustomAttributeProvider @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.Reflection.ICustomAttributeProvider>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.ArrayFullC2J<object[], object>(@__env, @__real.GetCustomAttributes(inherit));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetCustomAttributes1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle attributeType, bool inherit) {
            // (Lsystem/Type;Z)[Lsystem/Object;
            // (LSystem/Type;Z)[LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.ICustomAttributeProvider @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.Reflection.ICustomAttributeProvider>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.ArrayFullC2J<object[], object>(@__env, @__real.GetCustomAttributes(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, attributeType), inherit));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool IsDefined2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle attributeType, bool inherit) {
            // (Lsystem/Type;Z)Z
            // (LSystem/Type;Z)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Reflection.ICustomAttributeProvider @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.Reflection.ICustomAttributeProvider>(@__env, @__obj);
            @__return = ((bool)(@__real.IsDefined(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Type>(@__env, attributeType), inherit)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.Reflection.@__ICustomAttributeProvider(@__env);
            }
        }
    }
    #endregion
}
