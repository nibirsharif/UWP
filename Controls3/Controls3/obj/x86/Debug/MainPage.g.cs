﻿#pragma checksum "C:\Users\Nibir\documents\visual studio 2015\Projects\Controls3\Controls3\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "65D90366D895D4CFCB8B4052C7C97C6E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Controls3
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.Image1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 2:
                {
                    this.NoneButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 25 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.NoneButton).Checked += this.StretchModeButton_Checked;
                    #line default
                }
                break;
            case 3:
                {
                    this.FillButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 31 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.FillButton).Checked += this.StretchModeButton_Checked;
                    #line default
                }
                break;
            case 4:
                {
                    this.UniformButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 36 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.UniformButton).Checked += this.StretchModeButton_Checked;
                    #line default
                }
                break;
            case 5:
                {
                    this.UniformToFillButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 42 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.UniformToFillButton).Checked += this.StretchModeButton_Checked;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

