﻿#pragma checksum "c:\users\nibir\documents\visual studio 2015\Projects\SplitView\SplitView\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "612567313AF2BCB84DE89A745D990446"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SplitView
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
                    this.phone = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 2:
                {
                    this.SplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 3:
                {
                    this.SplitViewPanePanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4:
                {
                    this.BackRadioButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 98 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.BackRadioButton).Click += this.BackRadioButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.HamburgerRadioButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 99 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.HamburgerRadioButton).Click += this.HamburgerRadioButton_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.HomeRadioButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 101 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.HomeRadioButton).Click += this.HomeRadioButton_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.SettingsRadioButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 102 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.SettingsRadioButton).Click += this.SettingsRadioButton_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.MyFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
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

