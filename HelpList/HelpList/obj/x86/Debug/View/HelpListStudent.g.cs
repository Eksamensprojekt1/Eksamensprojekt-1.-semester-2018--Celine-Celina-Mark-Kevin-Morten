﻿#pragma checksum "C:\Users\Mark\Source\Repos\Celi0888\Eksamensprojekt-1.-semester-2018--Celine-Celina-Mark-Kevin-Morten\HelpList\HelpList\View\HelpListStudent.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EC3F7D9D8E87EDAC142FD6002A6498E8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelpList.View
{
    partial class HelpListStudent : 
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
            case 1: // View\HelpListStudent.xaml line 192
                {
                    this.HelpListExtendedView = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 2: // View\HelpListStudent.xaml line 193
                {
                    this.DateBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // View\HelpListStudent.xaml line 217
                {
                    this.RemoveProblem = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 4: // View\HelpListStudent.xaml line 152
                {
                    this.HelpListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.HelpListView).SelectionChanged += this.HelpListView_OnSelectionChanged;
                }
                break;
            case 5: // View\HelpListStudent.xaml line 135
                {
                    this.AddProblem = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 6: // View\HelpListStudent.xaml line 122
                {
                    this.DescriptionTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // View\HelpListStudent.xaml line 128
                {
                    this.DescriptionTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // View\HelpListStudent.xaml line 113
                {
                    this.TopicTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // View\HelpListStudent.xaml line 115
                {
                    this.TopicTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10: // View\HelpListStudent.xaml line 104
                {
                    this.LocationTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // View\HelpListStudent.xaml line 106
                {
                    this.LocationTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 12: // View\HelpListStudent.xaml line 95
                {
                    this.NameTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // View\HelpListStudent.xaml line 97
                {
                    this.NameTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

