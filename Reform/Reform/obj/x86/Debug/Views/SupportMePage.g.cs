﻿#pragma checksum "D:\Repositories\DeveloperWOW64\reform\Reform\Reform\Views\SupportMePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CF3590D4D6DEBAC31EB804E3597195F6945D10D482CA04C231FAA8CB6189E37D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Reform.Views
{
    partial class SupportMePage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_WebView_Source(global::Windows.UI.Xaml.Controls.WebView obj, global::System.Uri value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Uri) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Uri), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Control_IsEnabled(global::Windows.UI.Xaml.Controls.Control obj, global::System.Boolean value)
            {
                obj.IsEnabled = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ProgressRing_IsActive(global::Windows.UI.Xaml.Controls.ProgressRing obj, global::System.Boolean value)
            {
                obj.IsActive = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class SupportMePage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISupportMePage_Bindings
        {
            private global::Reform.Views.SupportMePage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.WebView obj10;
            private global::Windows.UI.Xaml.Controls.StackPanel obj11;
            private global::Windows.UI.Xaml.Controls.StackPanel obj12;
            private global::Windows.UI.Xaml.Controls.Button obj15;
            private global::Windows.UI.Xaml.Controls.Button obj16;
            private global::Windows.UI.Xaml.Controls.ProgressRing obj18;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj10SourceDisabled = false;
            private static bool isobj11VisibilityDisabled = false;
            private static bool isobj12VisibilityDisabled = false;
            private static bool isobj15IsEnabledDisabled = false;
            private static bool isobj16IsEnabledDisabled = false;
            private static bool isobj18IsActiveDisabled = false;

            private SupportMePage_obj1_BindingsTracking bindingsTracking;

            public SupportMePage_obj1_Bindings()
            {
                this.bindingsTracking = new SupportMePage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 83 && columnNumber == 35)
                {
                    isobj10SourceDisabled = true;
                }
                else if (lineNumber == 87 && columnNumber == 21)
                {
                    isobj11VisibilityDisabled = true;
                }
                else if (lineNumber == 93 && columnNumber == 21)
                {
                    isobj12VisibilityDisabled = true;
                }
                else if (lineNumber == 102 && columnNumber == 25)
                {
                    isobj15IsEnabledDisabled = true;
                }
                else if (lineNumber == 105 && columnNumber == 25)
                {
                    isobj16IsEnabledDisabled = true;
                }
                else if (lineNumber == 90 && columnNumber == 27)
                {
                    isobj18IsActiveDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 10: // Views\SupportMePage.xaml line 83
                        this.obj10 = (global::Windows.UI.Xaml.Controls.WebView)target;
                        break;
                    case 11: // Views\SupportMePage.xaml line 87
                        this.obj11 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                        break;
                    case 12: // Views\SupportMePage.xaml line 93
                        this.obj12 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                        break;
                    case 15: // Views\SupportMePage.xaml line 102
                        this.obj15 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 16: // Views\SupportMePage.xaml line 105
                        this.obj16 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 18: // Views\SupportMePage.xaml line 90
                        this.obj18 = (global::Windows.UI.Xaml.Controls.ProgressRing)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // ISupportMePage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Reform.Views.SupportMePage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Reform.Views.SupportMePage obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Source(obj.Source, phase);
                        this.Update_IsLoadingVisibility(obj.IsLoadingVisibility, phase);
                        this.Update_FailedMesageVisibility(obj.FailedMesageVisibility, phase);
                        this.Update_IsBackEnabled(obj.IsBackEnabled, phase);
                        this.Update_IsForwardEnabled(obj.IsForwardEnabled, phase);
                        this.Update_IsLoading(obj.IsLoading, phase);
                    }
                }
            }
            private void Update_Source(global::System.Uri obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\SupportMePage.xaml line 83
                    if (!isobj10SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_WebView_Source(this.obj10, obj, null);
                    }
                }
            }
            private void Update_IsLoadingVisibility(global::Windows.UI.Xaml.Visibility obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\SupportMePage.xaml line 87
                    if (!isobj11VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj11, obj);
                    }
                }
            }
            private void Update_FailedMesageVisibility(global::Windows.UI.Xaml.Visibility obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\SupportMePage.xaml line 93
                    if (!isobj12VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj12, obj);
                    }
                }
            }
            private void Update_IsBackEnabled(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\SupportMePage.xaml line 102
                    if (!isobj15IsEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj15, obj);
                    }
                }
            }
            private void Update_IsForwardEnabled(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\SupportMePage.xaml line 105
                    if (!isobj16IsEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj16, obj);
                    }
                }
            }
            private void Update_IsLoading(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\SupportMePage.xaml line 90
                    if (!isobj18IsActiveDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ProgressRing_IsActive(this.obj18, obj);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class SupportMePage_obj1_BindingsTracking
            {
                private global::System.WeakReference<SupportMePage_obj1_Bindings> weakRefToBindingObj; 

                public SupportMePage_obj1_BindingsTracking(SupportMePage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<SupportMePage_obj1_Bindings>(obj);
                }

                public SupportMePage_obj1_Bindings TryGetBindingObject()
                {
                    SupportMePage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    SupportMePage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Reform.Views.SupportMePage obj = sender as global::Reform.Views.SupportMePage;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_Source(obj.Source, DATA_CHANGED);
                                bindings.Update_IsLoadingVisibility(obj.IsLoadingVisibility, DATA_CHANGED);
                                bindings.Update_FailedMesageVisibility(obj.FailedMesageVisibility, DATA_CHANGED);
                                bindings.Update_IsBackEnabled(obj.IsBackEnabled, DATA_CHANGED);
                                bindings.Update_IsForwardEnabled(obj.IsForwardEnabled, DATA_CHANGED);
                                bindings.Update_IsLoading(obj.IsLoading, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Source":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Source(obj.Source, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsLoadingVisibility":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_IsLoadingVisibility(obj.IsLoadingVisibility, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "FailedMesageVisibility":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FailedMesageVisibility(obj.FailedMesageVisibility, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsBackEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_IsBackEnabled(obj.IsBackEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsForwardEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_IsForwardEnabled(obj.IsForwardEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsLoading":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_IsLoading(obj.IsLoading, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::Reform.Views.SupportMePage obj)
                {
                    SupportMePage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 10: // Views\SupportMePage.xaml line 83
                {
                    this.webView = (global::Windows.UI.Xaml.Controls.WebView)(target);
                    ((global::Windows.UI.Xaml.Controls.WebView)this.webView).NavigationCompleted += this.OnNavigationCompleted;
                    ((global::Windows.UI.Xaml.Controls.WebView)this.webView).NavigationFailed += this.OnNavigationFailed;
                }
                break;
            case 13: // Views\SupportMePage.xaml line 110
                {
                    global::Windows.UI.Xaml.Controls.Button element13 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element13).Click += this.OnRefresh;
                }
                break;
            case 14: // Views\SupportMePage.xaml line 113
                {
                    global::Windows.UI.Xaml.Controls.Button element14 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element14).Click += this.OnOpenInBrowser;
                }
                break;
            case 15: // Views\SupportMePage.xaml line 102
                {
                    global::Windows.UI.Xaml.Controls.Button element15 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element15).Click += this.OnGoBack;
                }
                break;
            case 16: // Views\SupportMePage.xaml line 105
                {
                    global::Windows.UI.Xaml.Controls.Button element16 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element16).Click += this.OnGoForward;
                }
                break;
            case 17: // Views\SupportMePage.xaml line 97
                {
                    global::Windows.UI.Xaml.Controls.HyperlinkButton element17 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)element17).Click += this.OnRetry;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\SupportMePage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    SupportMePage_obj1_Bindings bindings = new SupportMePage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

