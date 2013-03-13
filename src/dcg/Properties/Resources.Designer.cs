﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cavingdeep.Dcg.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Cavingdeep.Dcg.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Bad section definition, it must be something like this:
        ///
        ///@section name(param1: int, param2: MyClass).
        /// </summary>
        internal static string BadSectionDef {
            get {
                return ResourceManager.GetString("BadSectionDef", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bad section reference, it must be something like this:
        ///
        ///@+ name(param1, param2).
        /// </summary>
        internal static string BadSectionRef {
            get {
                return ResourceManager.GetString("BadSectionRef", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find between directive match..
        /// </summary>
        internal static string BetweenDirectiveWrong {
            get {
                return ResourceManager.GetString("BetweenDirectiveWrong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find code directive match..
        /// </summary>
        internal static string CodeDirectiveWrong {
            get {
                return ResourceManager.GetString("CodeDirectiveWrong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There must be at least 1 error..
        /// </summary>
        internal static string ErrorsCount {
            get {
                return ResourceManager.GetString("ErrorsCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find global directive match..
        /// </summary>
        internal static string GlobalDirectiveWrong {
            get {
                return ResourceManager.GetString("GlobalDirectiveWrong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bad import directive. It must be something like this:
        ///
        ///@import System.Windows.Forms.
        /// </summary>
        internal static string ImportDirectiveWrong {
            get {
                return ResourceManager.GetString("ImportDirectiveWrong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No output key provided, key must not be empty..
        /// </summary>
        internal static string NoOutputKeyProvided {
            get {
                return ResourceManager.GetString("NoOutputKeyProvided", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Output directive content should be aligned with the same white spaces..
        /// </summary>
        internal static string OutputDirectiveSpaceWrong {
            get {
                return ResourceManager.GetString("OutputDirectiveSpaceWrong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find output directive match..
        /// </summary>
        internal static string OutputDirectiveWrong {
            get {
                return ResourceManager.GetString("OutputDirectiveWrong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Param directive wrong. It must be something like this:
        ///
        ///@param paramName:paramType.
        /// </summary>
        internal static string ParamDirectiveWrong {
            get {
                return ResourceManager.GetString("ParamDirectiveWrong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bad reference directive. It must be something like this:
        ///
        ///@reference assembly1.dll.
        /// </summary>
        internal static string ReferenceDirectiveWrong {
            get {
                return ResourceManager.GetString("ReferenceDirectiveWrong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find section definition directive match..
        /// </summary>
        internal static string SectionDefDirectiveWrong {
            get {
                return ResourceManager.GetString("SectionDefDirectiveWrong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Section definition should appear in top level, that is, not under any other directive..
        /// </summary>
        internal static string SectionDefNotTopLevel {
            get {
                return ResourceManager.GetString("SectionDefNotTopLevel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A section&apos;s name should be unique within template, section name &quot;{0}&quot; is not..
        /// </summary>
        internal static string SectionNameNotUnique {
            get {
                return ResourceManager.GetString("SectionNameNotUnique", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stack is empty or has insufficient elements..
        /// </summary>
        internal static string StackEmpty {
            get {
                return ResourceManager.GetString("StackEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Text directive content should be aligned with the same white spaces..
        /// </summary>
        internal static string TextDirectiveSpaceWrong {
            get {
                return ResourceManager.GetString("TextDirectiveSpaceWrong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find text directive match..
        /// </summary>
        internal static string TextDirectiveWrong {
            get {
                return ResourceManager.GetString("TextDirectiveWrong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A &apos;)&apos; is missing in evaluation directive..
        /// </summary>
        internal static string WrongEvaluationDirective {
            get {
                return ResourceManager.GetString("WrongEvaluationDirective", resourceCulture);
            }
        }
    }
}
