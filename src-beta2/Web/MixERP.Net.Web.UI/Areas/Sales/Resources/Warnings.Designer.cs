﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MixERP.Net.Web.UI.Sales.Resources {
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
    internal class Warnings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Warnings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MixERP.Net.Web.UI.Sales.Resources.Warnings", typeof(Warnings).Assembly);
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
        ///   Looks up a localized string similar to Access is denied..
        /// </summary>
        internal static string AccessIsDenied {
            get {
                return ResourceManager.GetString("AccessIsDenied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A cash transaction cannot contain bank transaction details..
        /// </summary>
        internal static string CashTransactionCannotContainBankInfo {
            get {
                return ResourceManager.GetString("CashTransactionCannotContainBankInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The amount to should be greater than the amount from..
        /// </summary>
        internal static string CompareAmountErrorMessage {
            get {
                return ResourceManager.GetString("CompareAmountErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Selected date is invalid. .
        /// </summary>
        internal static string DateErrorMessage {
            get {
                return ResourceManager.GetString("DateErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Due days should be 0 if due frequency id is selected..
        /// </summary>
        internal static string DueFrequencyErrorMessage {
            get {
                return ResourceManager.GetString("DueFrequencyErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only {0} {1} of {2} left in stock..
        /// </summary>
        internal static string InsufficientStockWarning {
            get {
                return ResourceManager.GetString("InsufficientStockWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid party. This party is not associated with this transaction..
        /// </summary>
        internal static string InvalidParty {
            get {
                return ResourceManager.GetString("InvalidParty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid receipt mode..
        /// </summary>
        internal static string InvalidReceiptMode {
            get {
                return ResourceManager.GetString("InvalidReceiptMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid stock transaction Id..
        /// </summary>
        internal static string InvalidStockTransaction {
            get {
                return ResourceManager.GetString("InvalidStockTransaction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have to select either item id or  compound id..
        /// </summary>
        internal static string ItemErrorMessage {
            get {
                return ResourceManager.GetString("ItemErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Late fee id and late fee posting frequency id both should be either selected or not..
        /// </summary>
        internal static string LateFeeErrorMessage {
            get {
                return ResourceManager.GetString("LateFeeErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Recurring amount should not be less than or equal to 0.
        /// </summary>
        internal static string RecurringAmountErrorMessage {
            get {
                return ResourceManager.GetString("RecurringAmountErrorMessage", resourceCulture);
            }
        }
    }
}
