//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace net.sf.jni4net.tested {
    
    
    #region Component Designer generated code 
    public partial class CWithJavaInterface_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::net.sf.jni4net.tested.@__CWithJavaInterface.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::net.sf.jni4net.tested.CWithJavaInterface), typeof(global::net.sf.jni4net.tested.CWithJavaInterface_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::net.sf.jni4net.tested.CWithJavaInterface), typeof(global::net.sf.jni4net.tested.CWithJavaInterface_))]
    internal sealed partial class @__CWithJavaInterface : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        private @__CWithJavaInterface(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::net.sf.jni4net.tested.@__CWithJavaInterface.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__CWithJavaInterface);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "compareTo", "compareTo0", "(Ljava/lang/Object;)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "run", "run1", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getValue", "Value2", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setValue", "Value3", "(I)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorCWithJavaInterface0", "__ctorCWithJavaInterface0", "(Lnet/sf/jni4net/inj/IClrProxy;I)V"));
            return methods;
        }
        
        private static int compareTo0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/Object;)I
            // (Ljava/lang/Object;)I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::net.sf.jni4net.tested.CWithJavaInterface @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.tested.CWithJavaInterface>(@__env, @__obj);
            @__return = ((int)(((global::java.lang.Comparable)(@__real)).compareTo(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, par0))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void run1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.tested.CWithJavaInterface @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.tested.CWithJavaInterface>(@__env, @__obj);
            ((global::java.lang.Runnable)(@__real)).run();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static int Value2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::net.sf.jni4net.tested.CWithJavaInterface @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.tested.CWithJavaInterface>(@__env, @__obj);
            @__return = ((int)(@__real.Value));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void Value3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, int value) {
            // (I)V
            // (I)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.tested.CWithJavaInterface @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.tested.CWithJavaInterface>(@__env, @__obj);
            @__real.Value = value;
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorCWithJavaInterface0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, int value) {
            // (I)V
            // (I)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.tested.CWithJavaInterface @__real = new global::net.sf.jni4net.tested.CWithJavaInterface(value);
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::net.sf.jni4net.tested.@__CWithJavaInterface(@__env);
            }
        }
    }
    #endregion
}
