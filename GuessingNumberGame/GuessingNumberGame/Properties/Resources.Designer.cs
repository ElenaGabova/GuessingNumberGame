﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GuessingNumberGame.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
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
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GuessingNumberGame.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Добро пожаловать в игру &apos;Угадай число&apos;.
        /// </summary>
        internal static string HelloMessage {
            get {
                return ResourceManager.GetString("HelloMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Некорректное имя. Имя не может быть пустым, имя не может содержать числа..
        /// </summary>
        internal static string NameIsNotCorrectMessage {
            get {
                return ResourceManager.GetString("NameIsNotCorrectMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Как вас зовут?.
        /// </summary>
        internal static string NameQuestionMessage {
            get {
                return ResourceManager.GetString("NameQuestionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Вы ввели {0}. Нужно ввести число от {1} до {2}.
        /// </summary>
        internal static string NumberNotCorrectMessage {
            get {
                return ResourceManager.GetString("NumberNotCorrectMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0},введи число от  {1} до  {2} ({3} попытка).
        /// </summary>
        internal static string NumberQuestionMessage {
            get {
                return ResourceManager.GetString("NumberQuestionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ваше число ({0}) меньше, чем загаданное.
        /// </summary>
        internal static string YourNumberLessThanSecretMessage {
            get {
                return ResourceManager.GetString("YourNumberLessThanSecretMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ваше число ({0}) больше, чем загаданное.
        /// </summary>
        internal static string YourNumberMoreThanSecretMessage {
            get {
                return ResourceManager.GetString("YourNumberMoreThanSecretMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Вы победили!.
        /// </summary>
        internal static string YourWinMessage {
            get {
                return ResourceManager.GetString("YourWinMessage", resourceCulture);
            }
        }
    }
}
