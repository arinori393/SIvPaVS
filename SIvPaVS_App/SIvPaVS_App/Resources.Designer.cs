﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIvPaVS_App {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SIvPaVS_App.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to &lt;xs:schema xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///
        ///  &lt;xs:simpleType name=&quot;zipType&quot;&gt;
        ///    &lt;xs:restriction base=&quot;xs:string&quot;&gt;
        ///      &lt;xs:pattern value=&quot;[0-9]{5}&quot;/&gt;
        ///    &lt;/xs:restriction&gt;
        ///  &lt;/xs:simpleType&gt;
        ///
        ///  &lt;xs:complexType name=&quot;addressType&quot;&gt;
        ///    &lt;xs:sequence&gt;
        ///      &lt;xs:element type=&quot;xs:string&quot; name=&quot;street&quot;/&gt;
        ///      &lt;xs:element type=&quot;xs:string&quot; name=&quot;city&quot;/&gt;
        ///      &lt;xs:element type=&quot;zipType&quot; name=&quot;zip&quot;/&gt;
        ///      &lt;xs:element type=&quot;xs:string&quot; name=&quot;country&quot;/&gt;
        ///    &lt;/xs:sequence&gt;  
        ///  &lt;/xs:complexT [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string receipts {
            get {
                return ResourceManager.GetString("receipts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///
        ///&lt;xsl:stylesheet version=&quot;1.0&quot; xmlns:ex=&quot;http://exslt.org/common&quot; xmlns:xsl=&quot;http://www.w3.org/1999/XSL/Transform&quot;&gt;
        ///  &lt;xsl:output method=&quot;text&quot;/&gt;
        ///
        ///  &lt;xsl:template match=&quot;text()&quot; /&gt;
        ///
        ///  &lt;xsl:template match=&quot;receipt&quot;&gt;
        ///    &lt;xsl:text&gt;&amp;#09;&amp;#09;Pokladničný blok&amp;#xd;&amp;#xd;&lt;/xsl:text&gt;
        ///
        ///    &lt;xsl:apply-templates select=&quot;provider&quot;/&gt;
        ///
        ///    &lt;xsl:text&gt;&amp;#xd;Čas:&amp;#09;&amp;#09;&amp;#09;&lt;/xsl:text&gt;
        ///    &lt;xsl:value-of select=&quot;issued-at&quot;/&gt;
        ///    &lt;xsl:text&gt;&amp;#xd;&lt;/xsl:text&gt;
        ///    &lt;xsl:text&gt; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string XML_to_TXT_XSLT {
            get {
                return ResourceManager.GetString("XML_to_TXT_XSLT", resourceCulture);
            }
        }
    }
}
