﻿#pragma checksum "C:\Users\Niks\Desktop\projects\UWP\GamesDB\GamesDB\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7ADA7F9EBDABA766DE2B7C787200FF93"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GamesDB
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(global::Windows.UI.Xaml.Controls.Primitives.Selector obj, global::System.Int32 value)
            {
                obj.SelectedIndex = value;
            }
        };

        private class MainPage_obj8_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::GamesDB.ViewModel.GameVM dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj8;

            private MainPage_obj8_BindingsTracking bindingsTracking;

            public MainPage_obj8_Bindings()
            {
                this.bindingsTracking = new MainPage_obj8_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 8:
                        this.obj8 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.TextBlock)target);
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::GamesDB.ViewModel.GameVM data = args.NewValue as global::GamesDB.ViewModel.GameVM;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::GamesDB.ViewModel.GameVM was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item as global::GamesDB.ViewModel.GameVM);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.TextBlock)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::GamesDB.ViewModel.GameVM) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                this.bindingsTracking.ReleaseAllListeners();
            }

            // IMainPage_Bindings

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

            // MainPage_obj8_Bindings

            public void SetDataRoot(global::GamesDB.ViewModel.GameVM newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::GamesDB.ViewModel.GameVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_name(obj.name, phase);
                    }
                }
            }
            private void Update_name(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj8.Target as global::Windows.UI.Xaml.Controls.TextBlock, obj, null);
                }
            }

            private class MainPage_obj8_BindingsTracking
            {
                global::System.WeakReference<MainPage_obj8_Bindings> WeakRefToBindingObj; 

                public MainPage_obj8_BindingsTracking(MainPage_obj8_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<MainPage_obj8_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj8_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::GamesDB.ViewModel.GameVM obj = sender as global::GamesDB.ViewModel.GameVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_name(obj.name, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "name":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_name(obj.name, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::GamesDB.ViewModel.GameVM obj)
                {
                    MainPage_obj8_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
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

        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::GamesDB.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.StackPanel obj3;
            private global::Windows.UI.Xaml.Controls.TextBlock obj4;
            private global::Windows.UI.Xaml.Controls.TextBlock obj5;
            private global::Windows.UI.Xaml.Controls.TextBlock obj6;
            private global::Windows.UI.Xaml.Controls.ListView obj7;

            private MainPage_obj1_BindingsTracking bindingsTracking;

            public MainPage_obj1_Bindings()
            {
                this.bindingsTracking = new MainPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                        break;
                    case 4:
                        this.obj4 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 5:
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 7:
                        this.obj7 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        (this.obj7).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.Selector.SelectedIndexProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.Titles.SelectedIndex = (this.obj7).SelectedIndex;
                                }
                            });
                        break;
                    default:
                        break;
                }
            }

            // IMainPage_Bindings

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

            // MainPage_obj1_Bindings

            public void SetDataRoot(global::GamesDB.MainPage newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }
            public void SetConverterLookupRoot(global::Windows.UI.Xaml.FrameworkElement rootElement)
            {
                this.converterLookupRoot = new global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement>(rootElement);
            }

            public global::Windows.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                if (this.localResources == null)
                {
                    global::Windows.UI.Xaml.FrameworkElement rootElement;
                    this.converterLookupRoot.TryGetTarget(out rootElement);
                    this.localResources = rootElement.Resources;
                    this.converterLookupRoot = null;
                }
                return (global::Windows.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Windows.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::GamesDB.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Titles(obj.Titles, phase);
                    }
                }
                else
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_Titles(phase);
                    }
                }
            }
            private void Update_Titles(global::GamesDB.ViewModel.TitleVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_Titles(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Titles_SelectedGame(obj.SelectedGame, phase);
                        this.Update_Titles_Games(obj.Games, phase);
                        this.Update_Titles_SelectedIndex(obj.SelectedIndex, phase);
                    }
                }
                else
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_Titles_SelectedGame(phase);
                    }
                }
            }
            private void Update_Titles_SelectedGame(global::GamesDB.ViewModel.GameVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_Titles_SelectedGame(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Titles_SelectedGame_name(obj.name, phase);
                        this.Update_Titles_SelectedGame_summary(obj.summary, phase);
                        this.Update_Titles_SelectedGame_id(obj.id, phase);
                    }
                }
                else
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_Titles_SelectedGame_name(phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_Titles_SelectedGame_summary(phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_Titles_SelectedGame_id(phase);
                    }
                }
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj3, (global::Windows.UI.Xaml.Visibility)this.LookupConverter("ObjectExistsToVisible").Convert(obj, typeof(global::Windows.UI.Xaml.Visibility), null, null));
                }
            }
            private void Update_Titles_SelectedGame_name(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj4, obj, null);
                }
            }
            private void Update_Titles_SelectedGame_summary(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj5, obj, null);
                }
            }
            private void Update_Titles_SelectedGame_id(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj6, obj, null);
                }
            }
            private void Update_Titles_Games(global::System.Collections.ObjectModel.ObservableCollection<global::GamesDB.ViewModel.GameVM> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj7, obj, null);
                }
            }
            private void Update_Titles_SelectedIndex(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(this.obj7, obj);
                }
            }

            private void UpdateFallback_Titles(int phase)
            {
                this.UpdateFallback_Titles_SelectedGame(phase);
            }

            private void UpdateFallback_Titles_SelectedGame(int phase)
            {
                this.UpdateFallback_Titles_SelectedGame_name(phase);
                this.UpdateFallback_Titles_SelectedGame_summary(phase);
                this.UpdateFallback_Titles_SelectedGame_id(phase);
            }

            private void UpdateFallback_Titles_SelectedGame_name(int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj4, "", null);
                }
            }

            private void UpdateFallback_Titles_SelectedGame_summary(int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj5, "", null);
                }
            }

            private void UpdateFallback_Titles_SelectedGame_id(int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj6, "", null);
                }
            }

            private class MainPage_obj1_BindingsTracking
            {
                global::System.WeakReference<MainPage_obj1_Bindings> WeakRefToBindingObj; 

                public MainPage_obj1_BindingsTracking(MainPage_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<MainPage_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_Titles(null);
                    UpdateChildListeners_Titles_SelectedGame(null);
                }

                public void PropertyChanged_Titles(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::GamesDB.ViewModel.TitleVM obj = sender as global::GamesDB.ViewModel.TitleVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_Titles_SelectedGame(obj.SelectedGame, DATA_CHANGED);
                                    bindings.Update_Titles_Games(obj.Games, DATA_CHANGED);
                                    bindings.Update_Titles_SelectedIndex(obj.SelectedIndex, DATA_CHANGED);
                            }
                            else
                            {
                                bindings.UpdateFallback_Titles_SelectedGame(DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "SelectedGame":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Titles_SelectedGame(obj.SelectedGame, DATA_CHANGED);
                                    }
                                    else
                                    {
                                    bindings.UpdateFallback_Titles_SelectedGame(DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Games":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Titles_Games(obj.Games, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectedIndex":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Titles_SelectedIndex(obj.SelectedIndex, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::GamesDB.ViewModel.TitleVM cache_Titles = null;
                public void UpdateChildListeners_Titles(global::GamesDB.ViewModel.TitleVM obj)
                {
                    if (obj != cache_Titles)
                    {
                        if (cache_Titles != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_Titles).PropertyChanged -= PropertyChanged_Titles;
                            cache_Titles = null;
                        }
                        if (obj != null)
                        {
                            cache_Titles = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_Titles;
                        }
                    }
                }
                public void PropertyChanged_Titles_SelectedGame(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::GamesDB.ViewModel.GameVM obj = sender as global::GamesDB.ViewModel.GameVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_Titles_SelectedGame_name(obj.name, DATA_CHANGED);
                                    bindings.Update_Titles_SelectedGame_summary(obj.summary, DATA_CHANGED);
                                    bindings.Update_Titles_SelectedGame_id(obj.id, DATA_CHANGED);
                            }
                            else
                            {
                                bindings.UpdateFallback_Titles_SelectedGame_name(DATA_CHANGED);
                                bindings.UpdateFallback_Titles_SelectedGame_summary(DATA_CHANGED);
                                bindings.UpdateFallback_Titles_SelectedGame_id(DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "name":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Titles_SelectedGame_name(obj.name, DATA_CHANGED);
                                    }
                                    else
                                    {
                                    bindings.UpdateFallback_Titles_SelectedGame_name(DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "summary":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Titles_SelectedGame_summary(obj.summary, DATA_CHANGED);
                                    }
                                    else
                                    {
                                    bindings.UpdateFallback_Titles_SelectedGame_summary(DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "id":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Titles_SelectedGame_id(obj.id, DATA_CHANGED);
                                    }
                                    else
                                    {
                                    bindings.UpdateFallback_Titles_SelectedGame_id(DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::GamesDB.ViewModel.GameVM cache_Titles_SelectedGame = null;
                public void UpdateChildListeners_Titles_SelectedGame(global::GamesDB.ViewModel.GameVM obj)
                {
                    if (obj != cache_Titles_SelectedGame)
                    {
                        if (cache_Titles_SelectedGame != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_Titles_SelectedGame).PropertyChanged -= PropertyChanged_Titles_SelectedGame;
                            cache_Titles_SelectedGame = null;
                        }
                        if (obj != null)
                        {
                            cache_Titles_SelectedGame = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_Titles_SelectedGame;
                        }
                    }
                }
                public void PropertyChanged_Titles_Games(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::GamesDB.ViewModel.GameVM> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::GamesDB.ViewModel.GameVM>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_Titles_Games(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::GamesDB.ViewModel.GameVM> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::GamesDB.ViewModel.GameVM>;
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.spNames = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3:
                {
                    this.InfoPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 7:
                {
                    this.MainList = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 9:
                {
                    this.queryText = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10:
                {
                    this.btnSearch = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 28 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSearch).Click += this.btnSearch_Click;
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
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    bindings.SetConverterLookupRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 8:
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element8 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                    MainPage_obj8_Bindings bindings = new MainPage_obj8_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::GamesDB.ViewModel.GameVM) element8.DataContext);
                    element8.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element8, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

