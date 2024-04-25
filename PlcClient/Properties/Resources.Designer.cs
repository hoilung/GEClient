﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlcClient.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PlcClient.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似于 (图标) 的 System.Drawing.Icon 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Icon ab {
            get {
                object obj = ResourceManager.GetObject("ab", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 说明：
        ///当前协议：CIP
        ///1、批量读取，一行一个地址
        ///2、必须指定标签对应的PLC地址类型
        ///3、地址和PLC类型用tab键盘隔开
        ///4、数组型标签用中括号加下标取第几个
        ///5、BOOL数组类型不支持单个下标读取
        ///
        ///参考标签/PLC类型示例如下：
        ///
        ///B	Bool
        ///C	Int
        ///D	DInt
        ///F	Real
        ///C1[1]	Int
        ///F1[1]	Real 的本地化字符串。
        /// </summary>
        internal static string ab_tip {
            get {
                return ResourceManager.GetString("ab_tip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似于 (图标) 的 System.Drawing.Icon 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Icon ge {
            get {
                object obj = ResourceManager.GetObject("ge", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 说明：
        ///当前协议：SRTP
        ///默认以设定的最大字节，批量分组查询
        ///如果设置最大字节=0，则自动分组查询
        ///若默认添加数据类型不匹配请手动修改
        ///
        ///AI/AQ/R区地址单位是word不支持byte/bool
        ///SA/SB/SC区为系统区，只读
        ///
        ///批量读取，一行一个地址
        ///参考地址示例如下：
        ///
        ///I101
        ///Q201
        ///M301
        ///R401
        ///AI501
        ///AQ601 的本地化字符串。
        /// </summary>
        internal static string ge_tip {
            get {
                return ResourceManager.GetString("ge_tip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;&lt;Probe&gt;&lt;Uuid&gt;4EF73BF6-9C2A-43FA-8CD7-67659A4156FE&lt;/Uuid&gt;&lt;Types&gt;inquiry&lt;/Types&gt;&lt;/Probe&gt; 的本地化字符串。
        /// </summary>
        internal static string hikvision {
            get {
                return ResourceManager.GetString("hikvision", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Internet {
            get {
                object obj = ResourceManager.GetObject("Internet", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似于 (图标) 的 System.Drawing.Icon 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Icon opc {
            get {
                object obj = ResourceManager.GetObject("opc", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 说明：
        ///当前协议：S7
        ///批量读取，一行一个地址
        ///默认自动识别数据类型
        ///若需要指定PLC类型用tab键隔开
        ///
        ///参考地址/PLC类型示例如下：
        ///
        ///DB1.DBX1.0	Bool
        ///DB1.DBX1.2	Bool
        ///DB2.DBW100	Word
        ///DB2.DBW200	Int
        ///DB3.DBD300	Real
        ///DB3.DBD400	DWord 的本地化字符串。
        /// </summary>
        internal static string pl_siemens {
            get {
                return ResourceManager.GetString("pl_siemens", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Play {
            get {
                object obj = ResourceManager.GetObject("Play", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Root_Server {
            get {
                object obj = ResourceManager.GetObject("Root_Server", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Search_in_List {
            get {
                object obj = ResourceManager.GetObject("Search_in_List", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似于 (图标) 的 System.Drawing.Icon 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Icon siemens {
            get {
                object obj = ResourceManager.GetObject("siemens", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 说明：
        /// 1、关于PLC地址：DB1.DBX2.1、DB2.DBB4、DB3.DBW6、DB4.DBD8中的X、B、W、D分别表示Bit、Byte、Word、DWord数据类型
        /// 2、关于PLC地址：VB100、VW200、VD300中的 V区 相当于DB1区
        ///
        ///  PLC 与 C# 数据类型 参考关系如下： 
        /// |------------------------------|
        /// | Bool		| Boolean(Bool)	|
        /// |------------------------------|
        /// | Byte		| Byte		|
        /// |------------------------------|
        /// | Int		| Int16(Short)	|
        /// |------------------------------|
        /// | DInt		| Int32(Int)	|
        /// |------------------------------|
        /// | Real		| Single(Float)	|
        /// |------------------------------|
        /// | LReal	| Do [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string smz_tip {
            get {
                return ResourceManager.GetString("smz_tip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Stop {
            get {
                object obj = ResourceManager.GetObject("Stop", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Thin_Client {
            get {
                object obj = ResourceManager.GetObject("Thin_Client", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似于 (图标) 的 System.Drawing.Icon 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Icon tv_array {
            get {
                object obj = ResourceManager.GetObject("tv_array", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似于 (图标) 的 System.Drawing.Icon 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Icon tv_struct {
            get {
                object obj = ResourceManager.GetObject("tv_struct", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似于 (图标) 的 System.Drawing.Icon 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Icon tv_tag {
            get {
                object obj = ResourceManager.GetObject("tv_tag", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///&lt;SOAP-ENV:Envelope xmlns:SOAP-ENV=&quot;http://www.w3.org/2003/05/soap-envelope&quot; xmlns:SOAP-ENC=&quot;http://www.w3.org/2003/05/soap-encoding&quot; xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot; xmlns:xop=&quot;http://www.w3.org/2004/08/xop/include&quot; xmlns:wsa=&quot;http://schemas.xmlsoap.org/ws/2004/08/addressing&quot; xmlns:tns=&quot;http://schemas.xmlsoap.org/ws/2005/04/discovery&quot; xmlns:dn=&quot;http://www.onvif.org/ver10/network/wsdl&quot; xmlns:wsa5=&quot;http:/ [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string uniview {
            get {
                return ResourceManager.GetString("uniview", resourceCulture);
            }
        }
    }
}
