#if DELIGHT_MODULE_TEXTMESHPRO

// Internal view logic generated from "DelightDesigner.xml"
#region Using Statements
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace Delight
{
    public partial class DelightDesigner : LayoutRoot
    {
        #region Constructors

        public DelightDesigner(View parent, View layoutParent = null, string id = null, Template template = null, bool deferInitialization = false) :
            base(parent, layoutParent, id, template ?? DelightDesignerTemplates.Default, deferInitialization)
        {
            if (deferInitialization)
                return;

            // constructing Region (ViewsDesigner)
            ViewsDesigner = new Region(this, this, "ViewsDesigner", ViewsDesignerTemplate);
            Grid1 = new LayoutGrid(this, ViewsDesigner.Content, "Grid1", Grid1Template);
            Region1 = new Region(this, Grid1.Content, "Region1", Region1Template);
            Grid1.Cell.SetValue(Region1, new CellIndex(0, 0));
            Grid1.CellSpan.SetValue(Region1, new CellIndex(2, 1));
            Image1 = new Image(this, Region1.Content, "Image1", Image1Template);
            ScrollableContentRegion = new ScrollableRegion(this, Grid1.Content, "ScrollableContentRegion", ScrollableContentRegionTemplate);
            ScrollableContentRegion.Scroll.RegisterHandler(this, "OnScroll");
            Grid1.Cell.SetValue(ScrollableContentRegion, new CellIndex(0, 2));
            ContentRegionCanvas = new UICanvas(this, ScrollableContentRegion.Content, "ContentRegionCanvas", ContentRegionCanvasTemplate);
            ViewContentRegion = new Region(this, ContentRegionCanvas.Content, "ViewContentRegion", ViewContentRegionTemplate);
            ContentExplorer = new Region(this, Grid1.Content, "ContentExplorer", ContentExplorerTemplate);
            Grid1.Cell.SetValue(ContentExplorer, new CellIndex(0, 1));
            Grid1.CellSpan.SetValue(ContentExplorer, new CellIndex(2, 1));
            Region2 = new Region(this, ContentExplorer.Content, "Region2", Region2Template);
            ScrollableRegion1 = new ScrollableRegion(this, Region2.Content, "ScrollableRegion1", ScrollableRegion1Template);
            Expander1 = new Expander(this, ScrollableRegion1.Content, "Expander1", Expander1Template);

            // templates for Expander1
            Expander1.ContentTemplates.Add(new ContentTemplate(x0 => 
            {
                var expander1Content = new ExpanderContent(this, Expander1.Content, "Expander1Content", Expander1ContentTemplate);
                var list1 = new List(this, expander1Content.Content, "List1", List1Template);
                list1.ItemSelected.RegisterHandler(this, "ViewSelected");

                // binding <List Items="{view in EditableDesignerViews}">
                expander1Content.Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "EditableDesignerViews" }, new List<Func<BindableObject>> { () => this }) }, new BindingPath(new List<string> { "Items" }, new List<Func<BindableObject>> { () => list1 }), () => list1.Items = EditableDesignerViews, () => { }, false));

                // templates for list1
                list1.ContentTemplates.Add(new ContentTemplate(tiView => 
                {
                    var listItem1 = new ListItem(this, list1.Content, "ListItem1", ListItem1Template);
                    var label1 = new Label(this, listItem1.Content, "Label1", Label1Template);
                    listItem1.SetListItemState.SetValue(label1, true);

                    // binding <Label Text="{view.DisplayName}">
                    listItem1.Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "Item", "DisplayName" }, new List<Func<BindableObject>> { () => tiView, () => (tiView.Item as Delight.Editor.Parser.DesignerView) }) }, new BindingPath(new List<string> { "Text" }, new List<Func<BindableObject>> { () => label1 }), () => label1.Text = (tiView.Item as Delight.Editor.Parser.DesignerView).DisplayName, () => { }, false));
                    listItem1.IsDynamic = true;
                    listItem1.SetContentTemplateData(tiView);
                    return listItem1;
                }, typeof(ListItem), "ListItem1"));
                expander1Content.IsDynamic = true;
                expander1Content.SetContentTemplateData(x0);
                return expander1Content;
            }, typeof(ExpanderContent), "Expander1Content"));
            XmlEditorRegion = new Region(this, Grid1.Content, "XmlEditorRegion", XmlEditorRegionTemplate);
            Grid1.Cell.SetValue(XmlEditorRegion, new CellIndex(1, 2));
            XmlEditor = new XmlEditor(this, XmlEditorRegion.Content, "XmlEditor", XmlEditorTemplate);
            XmlEditor.Edit.RegisterHandler(this, "OnEdit");

            // binding <XmlEditor DesignerViews="{DesignerViews}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "DesignerViews" }, new List<Func<BindableObject>> { () => this }) }, new BindingPath(new List<string> { "XmlEditor", "DesignerViews" }, new List<Func<BindableObject>> { () => this, () => XmlEditor }), () => XmlEditor.DesignerViews = DesignerViews, () => { }, false));
            XmlEditorStatusBar = new Region(this, XmlEditorRegion.Content, "XmlEditorStatusBar", XmlEditorStatusBarTemplate);
            Group1 = new Group(this, XmlEditorStatusBar.Content, "Group1", Group1Template);
            AutoParseCheckBox = new CheckBox(this, Group1.Content, "AutoParseCheckBox", AutoParseCheckBoxTemplate);

            // binding <CheckBox IsChecked="{AutoParse}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "AutoParse" }, new List<Func<BindableObject>> { () => this }) }, new BindingPath(new List<string> { "AutoParseCheckBox", "IsChecked" }, new List<Func<BindableObject>> { () => this, () => AutoParseCheckBox }), () => AutoParseCheckBox.IsChecked = AutoParse, () => AutoParse = AutoParseCheckBox.IsChecked, true));
            Button1 = new Button(this, Group1.Content, "Button1", Button1Template);
            Button1.Click.RegisterHandler(this, "ParseView");

            // binding <Button IsDisabled="{AutoParse}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "AutoParse" }, new List<Func<BindableObject>> { () => this }) }, new BindingPath(new List<string> { "Button1", "IsDisabled" }, new List<Func<BindableObject>> { () => this, () => Button1 }), () => Button1.IsDisabled = AutoParse, () => { }, false));
            GridSplitter1 = new GridSplitter(this, Grid1.Content, "GridSplitter1", GridSplitter1Template);
            Grid1.Cell.SetValue(GridSplitter1, new CellIndex(0, 2));
            GridSplitter2 = new GridSplitter(this, Grid1.Content, "GridSplitter2", GridSplitter2Template);
            SaveChangesPopup = new Region(this, ViewsDesigner.Content, "SaveChangesPopup", SaveChangesPopupTemplate);
            Label2 = new Label(this, SaveChangesPopup.Content, "Label2", Label2Template);
            List2 = new List(this, SaveChangesPopup.Content, "List2", List2Template);

            // binding <List Items="{view in ChangedDesignerViews}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "ChangedDesignerViews" }, new List<Func<BindableObject>> { () => this }) }, new BindingPath(new List<string> { "List2", "Items" }, new List<Func<BindableObject>> { () => this, () => List2 }), () => List2.Items = ChangedDesignerViews, () => { }, false));

            // templates for List2
            List2.ContentTemplates.Add(new ContentTemplate(tiView => 
            {
                var listItem2 = new ListItem(this, List2.Content, "ListItem2", ListItem2Template);
                var label3 = new Label(this, listItem2.Content, "Label3", Label3Template);

                // binding <Label Text="{view.Name}">
                listItem2.Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "Item", "Name" }, new List<Func<BindableObject>> { () => tiView, () => (tiView.Item as Delight.Editor.Parser.DesignerView) }) }, new BindingPath(new List<string> { "Text" }, new List<Func<BindableObject>> { () => label3 }), () => label3.Text = (tiView.Item as Delight.Editor.Parser.DesignerView).Name, () => { }, false));
                listItem2.IsDynamic = true;
                listItem2.SetContentTemplateData(tiView);
                return listItem2;
            }, typeof(ListItem), "ListItem2"));
            Group2 = new Group(this, SaveChangesPopup.Content, "Group2", Group2Template);
            Button2 = new Button(this, Group2.Content, "Button2", Button2Template);
            Button2.Click.RegisterHandler(this, "SaveChangesAndQuit");
            Button3 = new Button(this, Group2.Content, "Button3", Button3Template);
            Button3.Click.RegisterHandler(this, "DiscardChangesAndQuit");
            Button4 = new Button(this, Group2.Content, "Button4", Button4Template);
            Button4.Click.RegisterHandler(this, "CancelQuit");
            this.AfterInitializeInternal();
        }

        public DelightDesigner() : this(null)
        {
        }

        static DelightDesigner()
        {
            var dependencyProperties = new List<DependencyProperty>();
            DependencyProperties.Add(DelightDesignerTemplates.Default, dependencyProperties);

            dependencyProperties.Add(DesignerViewsProperty);
            dependencyProperties.Add(ChangedDesignerViewsProperty);
            dependencyProperties.Add(EditableDesignerViewsProperty);
            dependencyProperties.Add(AutoParseProperty);
            dependencyProperties.Add(ViewsDesignerProperty);
            dependencyProperties.Add(ViewsDesignerTemplateProperty);
            dependencyProperties.Add(Grid1Property);
            dependencyProperties.Add(Grid1TemplateProperty);
            dependencyProperties.Add(Region1Property);
            dependencyProperties.Add(Region1TemplateProperty);
            dependencyProperties.Add(Image1Property);
            dependencyProperties.Add(Image1TemplateProperty);
            dependencyProperties.Add(ScrollableContentRegionProperty);
            dependencyProperties.Add(ScrollableContentRegionTemplateProperty);
            dependencyProperties.Add(ContentRegionCanvasProperty);
            dependencyProperties.Add(ContentRegionCanvasTemplateProperty);
            dependencyProperties.Add(ViewContentRegionProperty);
            dependencyProperties.Add(ViewContentRegionTemplateProperty);
            dependencyProperties.Add(ContentExplorerProperty);
            dependencyProperties.Add(ContentExplorerTemplateProperty);
            dependencyProperties.Add(Region2Property);
            dependencyProperties.Add(Region2TemplateProperty);
            dependencyProperties.Add(ScrollableRegion1Property);
            dependencyProperties.Add(ScrollableRegion1TemplateProperty);
            dependencyProperties.Add(Expander1Property);
            dependencyProperties.Add(Expander1TemplateProperty);
            dependencyProperties.Add(List1Property);
            dependencyProperties.Add(List1TemplateProperty);
            dependencyProperties.Add(ListItem1Property);
            dependencyProperties.Add(ListItem1TemplateProperty);
            dependencyProperties.Add(Label1Property);
            dependencyProperties.Add(Label1TemplateProperty);
            dependencyProperties.Add(XmlEditorRegionProperty);
            dependencyProperties.Add(XmlEditorRegionTemplateProperty);
            dependencyProperties.Add(XmlEditorProperty);
            dependencyProperties.Add(XmlEditorTemplateProperty);
            dependencyProperties.Add(XmlEditorStatusBarProperty);
            dependencyProperties.Add(XmlEditorStatusBarTemplateProperty);
            dependencyProperties.Add(Group1Property);
            dependencyProperties.Add(Group1TemplateProperty);
            dependencyProperties.Add(AutoParseCheckBoxProperty);
            dependencyProperties.Add(AutoParseCheckBoxTemplateProperty);
            dependencyProperties.Add(Button1Property);
            dependencyProperties.Add(Button1TemplateProperty);
            dependencyProperties.Add(GridSplitter1Property);
            dependencyProperties.Add(GridSplitter1TemplateProperty);
            dependencyProperties.Add(GridSplitter2Property);
            dependencyProperties.Add(GridSplitter2TemplateProperty);
            dependencyProperties.Add(SaveChangesPopupProperty);
            dependencyProperties.Add(SaveChangesPopupTemplateProperty);
            dependencyProperties.Add(Label2Property);
            dependencyProperties.Add(Label2TemplateProperty);
            dependencyProperties.Add(List2Property);
            dependencyProperties.Add(List2TemplateProperty);
            dependencyProperties.Add(ListItem2Property);
            dependencyProperties.Add(ListItem2TemplateProperty);
            dependencyProperties.Add(Label3Property);
            dependencyProperties.Add(Label3TemplateProperty);
            dependencyProperties.Add(Group2Property);
            dependencyProperties.Add(Group2TemplateProperty);
            dependencyProperties.Add(Button2Property);
            dependencyProperties.Add(Button2TemplateProperty);
            dependencyProperties.Add(Button3Property);
            dependencyProperties.Add(Button3TemplateProperty);
            dependencyProperties.Add(Button4Property);
            dependencyProperties.Add(Button4TemplateProperty);
            dependencyProperties.Add(Expander1ContentProperty);
            dependencyProperties.Add(Expander1ContentTemplateProperty);
        }

        #endregion

        #region Properties

        public readonly static DependencyProperty<Delight.Editor.Parser.DesignerViewData> DesignerViewsProperty = new DependencyProperty<Delight.Editor.Parser.DesignerViewData>("DesignerViews");
        /// <summary>List of views that can be edited by the designer.</summary>
        public Delight.Editor.Parser.DesignerViewData DesignerViews
        {
            get { return DesignerViewsProperty.GetValue(this); }
            set { DesignerViewsProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Delight.Editor.Parser.DesignerViewData> ChangedDesignerViewsProperty = new DependencyProperty<Delight.Editor.Parser.DesignerViewData>("ChangedDesignerViews");
        /// <summary>List of views that has been changed by the designer.</summary>
        public Delight.Editor.Parser.DesignerViewData ChangedDesignerViews
        {
            get { return ChangedDesignerViewsProperty.GetValue(this); }
            set { ChangedDesignerViewsProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Delight.Editor.Parser.DesignerViewData> EditableDesignerViewsProperty = new DependencyProperty<Delight.Editor.Parser.DesignerViewData>("EditableDesignerViews");
        public Delight.Editor.Parser.DesignerViewData EditableDesignerViews
        {
            get { return EditableDesignerViewsProperty.GetValue(this); }
            set { EditableDesignerViewsProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<System.Boolean> AutoParseProperty = new DependencyProperty<System.Boolean>("AutoParse");
        /// <summary>Boolean indicating if the designer should automatically parse XML of views as they changes.</summary>
        public System.Boolean AutoParse
        {
            get { return AutoParseProperty.GetValue(this); }
            set { AutoParseProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> ViewsDesignerProperty = new DependencyProperty<Region>("ViewsDesigner");
        public Region ViewsDesigner
        {
            get { return ViewsDesignerProperty.GetValue(this); }
            set { ViewsDesignerProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ViewsDesignerTemplateProperty = new DependencyProperty<Template>("ViewsDesignerTemplate");
        public Template ViewsDesignerTemplate
        {
            get { return ViewsDesignerTemplateProperty.GetValue(this); }
            set { ViewsDesignerTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<LayoutGrid> Grid1Property = new DependencyProperty<LayoutGrid>("Grid1");
        public LayoutGrid Grid1
        {
            get { return Grid1Property.GetValue(this); }
            set { Grid1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Grid1TemplateProperty = new DependencyProperty<Template>("Grid1Template");
        public Template Grid1Template
        {
            get { return Grid1TemplateProperty.GetValue(this); }
            set { Grid1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region1Property = new DependencyProperty<Region>("Region1");
        public Region Region1
        {
            get { return Region1Property.GetValue(this); }
            set { Region1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region1TemplateProperty = new DependencyProperty<Template>("Region1Template");
        public Template Region1Template
        {
            get { return Region1TemplateProperty.GetValue(this); }
            set { Region1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> Image1Property = new DependencyProperty<Image>("Image1");
        public Image Image1
        {
            get { return Image1Property.GetValue(this); }
            set { Image1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Image1TemplateProperty = new DependencyProperty<Template>("Image1Template");
        public Template Image1Template
        {
            get { return Image1TemplateProperty.GetValue(this); }
            set { Image1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ScrollableRegion> ScrollableContentRegionProperty = new DependencyProperty<ScrollableRegion>("ScrollableContentRegion");
        public ScrollableRegion ScrollableContentRegion
        {
            get { return ScrollableContentRegionProperty.GetValue(this); }
            set { ScrollableContentRegionProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ScrollableContentRegionTemplateProperty = new DependencyProperty<Template>("ScrollableContentRegionTemplate");
        public Template ScrollableContentRegionTemplate
        {
            get { return ScrollableContentRegionTemplateProperty.GetValue(this); }
            set { ScrollableContentRegionTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<UICanvas> ContentRegionCanvasProperty = new DependencyProperty<UICanvas>("ContentRegionCanvas");
        public UICanvas ContentRegionCanvas
        {
            get { return ContentRegionCanvasProperty.GetValue(this); }
            set { ContentRegionCanvasProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ContentRegionCanvasTemplateProperty = new DependencyProperty<Template>("ContentRegionCanvasTemplate");
        public Template ContentRegionCanvasTemplate
        {
            get { return ContentRegionCanvasTemplateProperty.GetValue(this); }
            set { ContentRegionCanvasTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> ViewContentRegionProperty = new DependencyProperty<Region>("ViewContentRegion");
        public Region ViewContentRegion
        {
            get { return ViewContentRegionProperty.GetValue(this); }
            set { ViewContentRegionProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ViewContentRegionTemplateProperty = new DependencyProperty<Template>("ViewContentRegionTemplate");
        public Template ViewContentRegionTemplate
        {
            get { return ViewContentRegionTemplateProperty.GetValue(this); }
            set { ViewContentRegionTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> ContentExplorerProperty = new DependencyProperty<Region>("ContentExplorer");
        public Region ContentExplorer
        {
            get { return ContentExplorerProperty.GetValue(this); }
            set { ContentExplorerProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ContentExplorerTemplateProperty = new DependencyProperty<Template>("ContentExplorerTemplate");
        public Template ContentExplorerTemplate
        {
            get { return ContentExplorerTemplateProperty.GetValue(this); }
            set { ContentExplorerTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region2Property = new DependencyProperty<Region>("Region2");
        public Region Region2
        {
            get { return Region2Property.GetValue(this); }
            set { Region2Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region2TemplateProperty = new DependencyProperty<Template>("Region2Template");
        public Template Region2Template
        {
            get { return Region2TemplateProperty.GetValue(this); }
            set { Region2TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ScrollableRegion> ScrollableRegion1Property = new DependencyProperty<ScrollableRegion>("ScrollableRegion1");
        public ScrollableRegion ScrollableRegion1
        {
            get { return ScrollableRegion1Property.GetValue(this); }
            set { ScrollableRegion1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ScrollableRegion1TemplateProperty = new DependencyProperty<Template>("ScrollableRegion1Template");
        public Template ScrollableRegion1Template
        {
            get { return ScrollableRegion1TemplateProperty.GetValue(this); }
            set { ScrollableRegion1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Expander> Expander1Property = new DependencyProperty<Expander>("Expander1");
        public Expander Expander1
        {
            get { return Expander1Property.GetValue(this); }
            set { Expander1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Expander1TemplateProperty = new DependencyProperty<Template>("Expander1Template");
        public Template Expander1Template
        {
            get { return Expander1TemplateProperty.GetValue(this); }
            set { Expander1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<List> List1Property = new DependencyProperty<List>("List1");
        public List List1
        {
            get { return List1Property.GetValue(this); }
            set { List1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> List1TemplateProperty = new DependencyProperty<Template>("List1Template");
        public Template List1Template
        {
            get { return List1TemplateProperty.GetValue(this); }
            set { List1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ListItem> ListItem1Property = new DependencyProperty<ListItem>("ListItem1");
        public ListItem ListItem1
        {
            get { return ListItem1Property.GetValue(this); }
            set { ListItem1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ListItem1TemplateProperty = new DependencyProperty<Template>("ListItem1Template");
        public Template ListItem1Template
        {
            get { return ListItem1TemplateProperty.GetValue(this); }
            set { ListItem1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> Label1Property = new DependencyProperty<Label>("Label1");
        public Label Label1
        {
            get { return Label1Property.GetValue(this); }
            set { Label1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Label1TemplateProperty = new DependencyProperty<Template>("Label1Template");
        public Template Label1Template
        {
            get { return Label1TemplateProperty.GetValue(this); }
            set { Label1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> XmlEditorRegionProperty = new DependencyProperty<Region>("XmlEditorRegion");
        public Region XmlEditorRegion
        {
            get { return XmlEditorRegionProperty.GetValue(this); }
            set { XmlEditorRegionProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> XmlEditorRegionTemplateProperty = new DependencyProperty<Template>("XmlEditorRegionTemplate");
        public Template XmlEditorRegionTemplate
        {
            get { return XmlEditorRegionTemplateProperty.GetValue(this); }
            set { XmlEditorRegionTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<XmlEditor> XmlEditorProperty = new DependencyProperty<XmlEditor>("XmlEditor");
        public XmlEditor XmlEditor
        {
            get { return XmlEditorProperty.GetValue(this); }
            set { XmlEditorProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> XmlEditorTemplateProperty = new DependencyProperty<Template>("XmlEditorTemplate");
        public Template XmlEditorTemplate
        {
            get { return XmlEditorTemplateProperty.GetValue(this); }
            set { XmlEditorTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> XmlEditorStatusBarProperty = new DependencyProperty<Region>("XmlEditorStatusBar");
        public Region XmlEditorStatusBar
        {
            get { return XmlEditorStatusBarProperty.GetValue(this); }
            set { XmlEditorStatusBarProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> XmlEditorStatusBarTemplateProperty = new DependencyProperty<Template>("XmlEditorStatusBarTemplate");
        public Template XmlEditorStatusBarTemplate
        {
            get { return XmlEditorStatusBarTemplateProperty.GetValue(this); }
            set { XmlEditorStatusBarTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Group> Group1Property = new DependencyProperty<Group>("Group1");
        public Group Group1
        {
            get { return Group1Property.GetValue(this); }
            set { Group1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Group1TemplateProperty = new DependencyProperty<Template>("Group1Template");
        public Template Group1Template
        {
            get { return Group1TemplateProperty.GetValue(this); }
            set { Group1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<CheckBox> AutoParseCheckBoxProperty = new DependencyProperty<CheckBox>("AutoParseCheckBox");
        public CheckBox AutoParseCheckBox
        {
            get { return AutoParseCheckBoxProperty.GetValue(this); }
            set { AutoParseCheckBoxProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> AutoParseCheckBoxTemplateProperty = new DependencyProperty<Template>("AutoParseCheckBoxTemplate");
        public Template AutoParseCheckBoxTemplate
        {
            get { return AutoParseCheckBoxTemplateProperty.GetValue(this); }
            set { AutoParseCheckBoxTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Button> Button1Property = new DependencyProperty<Button>("Button1");
        public Button Button1
        {
            get { return Button1Property.GetValue(this); }
            set { Button1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Button1TemplateProperty = new DependencyProperty<Template>("Button1Template");
        public Template Button1Template
        {
            get { return Button1TemplateProperty.GetValue(this); }
            set { Button1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<GridSplitter> GridSplitter1Property = new DependencyProperty<GridSplitter>("GridSplitter1");
        public GridSplitter GridSplitter1
        {
            get { return GridSplitter1Property.GetValue(this); }
            set { GridSplitter1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> GridSplitter1TemplateProperty = new DependencyProperty<Template>("GridSplitter1Template");
        public Template GridSplitter1Template
        {
            get { return GridSplitter1TemplateProperty.GetValue(this); }
            set { GridSplitter1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<GridSplitter> GridSplitter2Property = new DependencyProperty<GridSplitter>("GridSplitter2");
        public GridSplitter GridSplitter2
        {
            get { return GridSplitter2Property.GetValue(this); }
            set { GridSplitter2Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> GridSplitter2TemplateProperty = new DependencyProperty<Template>("GridSplitter2Template");
        public Template GridSplitter2Template
        {
            get { return GridSplitter2TemplateProperty.GetValue(this); }
            set { GridSplitter2TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> SaveChangesPopupProperty = new DependencyProperty<Region>("SaveChangesPopup");
        public Region SaveChangesPopup
        {
            get { return SaveChangesPopupProperty.GetValue(this); }
            set { SaveChangesPopupProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> SaveChangesPopupTemplateProperty = new DependencyProperty<Template>("SaveChangesPopupTemplate");
        public Template SaveChangesPopupTemplate
        {
            get { return SaveChangesPopupTemplateProperty.GetValue(this); }
            set { SaveChangesPopupTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> Label2Property = new DependencyProperty<Label>("Label2");
        public Label Label2
        {
            get { return Label2Property.GetValue(this); }
            set { Label2Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Label2TemplateProperty = new DependencyProperty<Template>("Label2Template");
        public Template Label2Template
        {
            get { return Label2TemplateProperty.GetValue(this); }
            set { Label2TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<List> List2Property = new DependencyProperty<List>("List2");
        public List List2
        {
            get { return List2Property.GetValue(this); }
            set { List2Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> List2TemplateProperty = new DependencyProperty<Template>("List2Template");
        public Template List2Template
        {
            get { return List2TemplateProperty.GetValue(this); }
            set { List2TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ListItem> ListItem2Property = new DependencyProperty<ListItem>("ListItem2");
        public ListItem ListItem2
        {
            get { return ListItem2Property.GetValue(this); }
            set { ListItem2Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ListItem2TemplateProperty = new DependencyProperty<Template>("ListItem2Template");
        public Template ListItem2Template
        {
            get { return ListItem2TemplateProperty.GetValue(this); }
            set { ListItem2TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> Label3Property = new DependencyProperty<Label>("Label3");
        public Label Label3
        {
            get { return Label3Property.GetValue(this); }
            set { Label3Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Label3TemplateProperty = new DependencyProperty<Template>("Label3Template");
        public Template Label3Template
        {
            get { return Label3TemplateProperty.GetValue(this); }
            set { Label3TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Group> Group2Property = new DependencyProperty<Group>("Group2");
        public Group Group2
        {
            get { return Group2Property.GetValue(this); }
            set { Group2Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Group2TemplateProperty = new DependencyProperty<Template>("Group2Template");
        public Template Group2Template
        {
            get { return Group2TemplateProperty.GetValue(this); }
            set { Group2TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Button> Button2Property = new DependencyProperty<Button>("Button2");
        public Button Button2
        {
            get { return Button2Property.GetValue(this); }
            set { Button2Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Button2TemplateProperty = new DependencyProperty<Template>("Button2Template");
        public Template Button2Template
        {
            get { return Button2TemplateProperty.GetValue(this); }
            set { Button2TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Button> Button3Property = new DependencyProperty<Button>("Button3");
        public Button Button3
        {
            get { return Button3Property.GetValue(this); }
            set { Button3Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Button3TemplateProperty = new DependencyProperty<Template>("Button3Template");
        public Template Button3Template
        {
            get { return Button3TemplateProperty.GetValue(this); }
            set { Button3TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Button> Button4Property = new DependencyProperty<Button>("Button4");
        public Button Button4
        {
            get { return Button4Property.GetValue(this); }
            set { Button4Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Button4TemplateProperty = new DependencyProperty<Template>("Button4Template");
        public Template Button4Template
        {
            get { return Button4TemplateProperty.GetValue(this); }
            set { Button4TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<ExpanderContent> Expander1ContentProperty = new DependencyProperty<ExpanderContent>("Expander1Content");
        public ExpanderContent Expander1Content
        {
            get { return Expander1ContentProperty.GetValue(this); }
            set { Expander1ContentProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Expander1ContentTemplateProperty = new DependencyProperty<Template>("Expander1ContentTemplate");
        public Template Expander1ContentTemplate
        {
            get { return Expander1ContentTemplateProperty.GetValue(this); }
            set { Expander1ContentTemplateProperty.SetValue(this, value); }
        }

        #endregion
    }

    #region Data Templates

    public static class DelightDesignerTemplates
    {
        #region Properties

        public static Template Default
        {
            get
            {
                return DelightDesigner;
            }
        }

        private static Template _delightDesigner;
        public static Template DelightDesigner
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesigner == null || _delightDesigner.CurrentVersion != Template.Version)
#else
                if (_delightDesigner == null)
#endif
                {
                    _delightDesigner = new Template(LayoutRootTemplates.LayoutRoot);
#if UNITY_EDITOR
                    _delightDesigner.Name = "DelightDesigner";
#endif
                    Delight.DelightDesigner.EnableScriptEventsProperty.SetDefault(_delightDesigner, true);
                    Delight.DelightDesigner.AutoParseProperty.SetDefault(_delightDesigner, true);
                    Delight.DelightDesigner.ViewsDesignerTemplateProperty.SetDefault(_delightDesigner, DelightDesignerViewsDesigner);
                    Delight.DelightDesigner.Grid1TemplateProperty.SetDefault(_delightDesigner, DelightDesignerGrid1);
                    Delight.DelightDesigner.Region1TemplateProperty.SetDefault(_delightDesigner, DelightDesignerRegion1);
                    Delight.DelightDesigner.Image1TemplateProperty.SetDefault(_delightDesigner, DelightDesignerImage1);
                    Delight.DelightDesigner.ScrollableContentRegionTemplateProperty.SetDefault(_delightDesigner, DelightDesignerScrollableContentRegion);
                    Delight.DelightDesigner.ContentRegionCanvasTemplateProperty.SetDefault(_delightDesigner, DelightDesignerContentRegionCanvas);
                    Delight.DelightDesigner.ViewContentRegionTemplateProperty.SetDefault(_delightDesigner, DelightDesignerViewContentRegion);
                    Delight.DelightDesigner.ContentExplorerTemplateProperty.SetDefault(_delightDesigner, DelightDesignerContentExplorer);
                    Delight.DelightDesigner.Region2TemplateProperty.SetDefault(_delightDesigner, DelightDesignerRegion2);
                    Delight.DelightDesigner.ScrollableRegion1TemplateProperty.SetDefault(_delightDesigner, DelightDesignerScrollableRegion1);
                    Delight.DelightDesigner.Expander1TemplateProperty.SetDefault(_delightDesigner, DelightDesignerExpander1);
                    Delight.DelightDesigner.Expander1ContentTemplateProperty.SetDefault(_delightDesigner, DelightDesignerExpander1Content);
                    Delight.DelightDesigner.List1TemplateProperty.SetDefault(_delightDesigner, DelightDesignerList1);
                    Delight.DelightDesigner.ListItem1TemplateProperty.SetDefault(_delightDesigner, DelightDesignerListItem1);
                    Delight.DelightDesigner.Label1TemplateProperty.SetDefault(_delightDesigner, DelightDesignerLabel1);
                    Delight.DelightDesigner.XmlEditorRegionTemplateProperty.SetDefault(_delightDesigner, DelightDesignerXmlEditorRegion);
                    Delight.DelightDesigner.XmlEditorTemplateProperty.SetDefault(_delightDesigner, DelightDesignerXmlEditor);
                    Delight.DelightDesigner.XmlEditorStatusBarTemplateProperty.SetDefault(_delightDesigner, DelightDesignerXmlEditorStatusBar);
                    Delight.DelightDesigner.Group1TemplateProperty.SetDefault(_delightDesigner, DelightDesignerGroup1);
                    Delight.DelightDesigner.AutoParseCheckBoxTemplateProperty.SetDefault(_delightDesigner, DelightDesignerAutoParseCheckBox);
                    Delight.DelightDesigner.Button1TemplateProperty.SetDefault(_delightDesigner, DelightDesignerButton1);
                    Delight.DelightDesigner.GridSplitter1TemplateProperty.SetDefault(_delightDesigner, DelightDesignerGridSplitter1);
                    Delight.DelightDesigner.GridSplitter2TemplateProperty.SetDefault(_delightDesigner, DelightDesignerGridSplitter2);
                    Delight.DelightDesigner.SaveChangesPopupTemplateProperty.SetDefault(_delightDesigner, DelightDesignerSaveChangesPopup);
                    Delight.DelightDesigner.Label2TemplateProperty.SetDefault(_delightDesigner, DelightDesignerLabel2);
                    Delight.DelightDesigner.List2TemplateProperty.SetDefault(_delightDesigner, DelightDesignerList2);
                    Delight.DelightDesigner.ListItem2TemplateProperty.SetDefault(_delightDesigner, DelightDesignerListItem2);
                    Delight.DelightDesigner.Label3TemplateProperty.SetDefault(_delightDesigner, DelightDesignerLabel3);
                    Delight.DelightDesigner.Group2TemplateProperty.SetDefault(_delightDesigner, DelightDesignerGroup2);
                    Delight.DelightDesigner.Button2TemplateProperty.SetDefault(_delightDesigner, DelightDesignerButton2);
                    Delight.DelightDesigner.Button3TemplateProperty.SetDefault(_delightDesigner, DelightDesignerButton3);
                    Delight.DelightDesigner.Button4TemplateProperty.SetDefault(_delightDesigner, DelightDesignerButton4);
                }
                return _delightDesigner;
            }
        }

        private static Template _delightDesignerViewsDesigner;
        public static Template DelightDesignerViewsDesigner
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerViewsDesigner == null || _delightDesignerViewsDesigner.CurrentVersion != Template.Version)
#else
                if (_delightDesignerViewsDesigner == null)
#endif
                {
                    _delightDesignerViewsDesigner = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _delightDesignerViewsDesigner.Name = "DelightDesignerViewsDesigner";
#endif
                }
                return _delightDesignerViewsDesigner;
            }
        }

        private static Template _delightDesignerGrid1;
        public static Template DelightDesignerGrid1
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerGrid1 == null || _delightDesignerGrid1.CurrentVersion != Template.Version)
#else
                if (_delightDesignerGrid1 == null)
#endif
                {
                    _delightDesignerGrid1 = new Template(LayoutGridTemplates.LayoutGrid);
#if UNITY_EDITOR
                    _delightDesignerGrid1.Name = "DelightDesignerGrid1";
#endif
                    Delight.LayoutGrid.ColumnsProperty.SetDefault(_delightDesignerGrid1, new ColumnDefinitions { new ColumnDefinition(new ElementSize(50f, ElementSizeUnit.Pixels), 50f, 50f), new ColumnDefinition(new ElementSize(200f, ElementSizeUnit.Pixels)), new ColumnDefinition(new ElementSize(1f, ElementSizeUnit.Proportional))});
                    Delight.LayoutGrid.RowsProperty.SetDefault(_delightDesignerGrid1, new RowDefinitions { new RowDefinition(new ElementSize(1f, ElementSizeUnit.Proportional)), new RowDefinition(new ElementSize(240f, ElementSizeUnit.Pixels), 20f)});
                    Delight.LayoutGrid.BackgroundColorProperty.SetDefault(_delightDesignerGrid1, new UnityEngine.Color(0.2235294f, 0.2705882f, 0.3215686f, 1f));
                }
                return _delightDesignerGrid1;
            }
        }

        private static Template _delightDesignerRegion1;
        public static Template DelightDesignerRegion1
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerRegion1 == null || _delightDesignerRegion1.CurrentVersion != Template.Version)
#else
                if (_delightDesignerRegion1 == null)
#endif
                {
                    _delightDesignerRegion1 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _delightDesignerRegion1.Name = "DelightDesignerRegion1";
#endif
                    Delight.Region.BackgroundColorProperty.SetDefault(_delightDesignerRegion1, new UnityEngine.Color(0.2352941f, 0.254902f, 0.3960784f, 1f));
                }
                return _delightDesignerRegion1;
            }
        }

        private static Template _delightDesignerImage1;
        public static Template DelightDesignerImage1
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerImage1 == null || _delightDesignerImage1.CurrentVersion != Template.Version)
#else
                if (_delightDesignerImage1 == null)
#endif
                {
                    _delightDesignerImage1 = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _delightDesignerImage1.Name = "DelightDesignerImage1";
#endif
                    Delight.Image.SpriteProperty.SetDefault(_delightDesignerImage1, Assets.Sprites["delight-icon"]);
                    Delight.Image.AlignmentProperty.SetDefault(_delightDesignerImage1, Delight.ElementAlignment.Top);
                    Delight.Image.OffsetProperty.SetDefault(_delightDesignerImage1, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(5f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                }
                return _delightDesignerImage1;
            }
        }

        private static Template _delightDesignerScrollableContentRegion;
        public static Template DelightDesignerScrollableContentRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerScrollableContentRegion == null || _delightDesignerScrollableContentRegion.CurrentVersion != Template.Version)
#else
                if (_delightDesignerScrollableContentRegion == null)
#endif
                {
                    _delightDesignerScrollableContentRegion = new Template(ScrollableRegionTemplates.ScrollableRegion);
#if UNITY_EDITOR
                    _delightDesignerScrollableContentRegion.Name = "DelightDesignerScrollableContentRegion";
#endif
                    Delight.ScrollableRegion.HasInertiaProperty.SetDefault(_delightDesignerScrollableContentRegion, false);
                    Delight.ScrollableRegion.DisableMouseWheelProperty.SetDefault(_delightDesignerScrollableContentRegion, true);
                    Delight.ScrollableRegion.UnblockDragEventsInChildrenProperty.SetDefault(_delightDesignerScrollableContentRegion, false);
                    Delight.ScrollableRegion.HorizontalScrollbarVisibilityProperty.SetDefault(_delightDesignerScrollableContentRegion, Delight.ScrollbarVisibilityMode.Never);
                    Delight.ScrollableRegion.VerticalScrollbarVisibilityProperty.SetDefault(_delightDesignerScrollableContentRegion, Delight.ScrollbarVisibilityMode.Never);
                    Delight.ScrollableRegion.ContentRegionTemplateProperty.SetDefault(_delightDesignerScrollableContentRegion, DelightDesignerScrollableContentRegionContentRegion);
                    Delight.ScrollableRegion.HorizontalScrollbarTemplateProperty.SetDefault(_delightDesignerScrollableContentRegion, DelightDesignerScrollableContentRegionHorizontalScrollbar);
                    Delight.ScrollableRegion.VerticalScrollbarTemplateProperty.SetDefault(_delightDesignerScrollableContentRegion, DelightDesignerScrollableContentRegionVerticalScrollbar);
                }
                return _delightDesignerScrollableContentRegion;
            }
        }

        private static Template _delightDesignerScrollableContentRegionContentRegion;
        public static Template DelightDesignerScrollableContentRegionContentRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerScrollableContentRegionContentRegion == null || _delightDesignerScrollableContentRegionContentRegion.CurrentVersion != Template.Version)
#else
                if (_delightDesignerScrollableContentRegionContentRegion == null)
#endif
                {
                    _delightDesignerScrollableContentRegionContentRegion = new Template(ScrollableRegionTemplates.ScrollableRegionContentRegion);
#if UNITY_EDITOR
                    _delightDesignerScrollableContentRegionContentRegion.Name = "DelightDesignerScrollableContentRegionContentRegion";
#endif
                }
                return _delightDesignerScrollableContentRegionContentRegion;
            }
        }

        private static Template _delightDesignerScrollableContentRegionHorizontalScrollbar;
        public static Template DelightDesignerScrollableContentRegionHorizontalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerScrollableContentRegionHorizontalScrollbar == null || _delightDesignerScrollableContentRegionHorizontalScrollbar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerScrollableContentRegionHorizontalScrollbar == null)
#endif
                {
                    _delightDesignerScrollableContentRegionHorizontalScrollbar = new Template(ScrollableRegionTemplates.ScrollableRegionHorizontalScrollbar);
#if UNITY_EDITOR
                    _delightDesignerScrollableContentRegionHorizontalScrollbar.Name = "DelightDesignerScrollableContentRegionHorizontalScrollbar";
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_delightDesignerScrollableContentRegionHorizontalScrollbar, DelightDesignerScrollableContentRegionHorizontalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_delightDesignerScrollableContentRegionHorizontalScrollbar, DelightDesignerScrollableContentRegionHorizontalScrollbarHandle);
                }
                return _delightDesignerScrollableContentRegionHorizontalScrollbar;
            }
        }

        private static Template _delightDesignerScrollableContentRegionHorizontalScrollbarBar;
        public static Template DelightDesignerScrollableContentRegionHorizontalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerScrollableContentRegionHorizontalScrollbarBar == null || _delightDesignerScrollableContentRegionHorizontalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerScrollableContentRegionHorizontalScrollbarBar == null)
#endif
                {
                    _delightDesignerScrollableContentRegionHorizontalScrollbarBar = new Template(ScrollableRegionTemplates.ScrollableRegionHorizontalScrollbarBar);
#if UNITY_EDITOR
                    _delightDesignerScrollableContentRegionHorizontalScrollbarBar.Name = "DelightDesignerScrollableContentRegionHorizontalScrollbarBar";
#endif
                }
                return _delightDesignerScrollableContentRegionHorizontalScrollbarBar;
            }
        }

        private static Template _delightDesignerScrollableContentRegionHorizontalScrollbarHandle;
        public static Template DelightDesignerScrollableContentRegionHorizontalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerScrollableContentRegionHorizontalScrollbarHandle == null || _delightDesignerScrollableContentRegionHorizontalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_delightDesignerScrollableContentRegionHorizontalScrollbarHandle == null)
#endif
                {
                    _delightDesignerScrollableContentRegionHorizontalScrollbarHandle = new Template(ScrollableRegionTemplates.ScrollableRegionHorizontalScrollbarHandle);
#if UNITY_EDITOR
                    _delightDesignerScrollableContentRegionHorizontalScrollbarHandle.Name = "DelightDesignerScrollableContentRegionHorizontalScrollbarHandle";
#endif
                }
                return _delightDesignerScrollableContentRegionHorizontalScrollbarHandle;
            }
        }

        private static Template _delightDesignerScrollableContentRegionVerticalScrollbar;
        public static Template DelightDesignerScrollableContentRegionVerticalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerScrollableContentRegionVerticalScrollbar == null || _delightDesignerScrollableContentRegionVerticalScrollbar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerScrollableContentRegionVerticalScrollbar == null)
#endif
                {
                    _delightDesignerScrollableContentRegionVerticalScrollbar = new Template(ScrollableRegionTemplates.ScrollableRegionVerticalScrollbar);
#if UNITY_EDITOR
                    _delightDesignerScrollableContentRegionVerticalScrollbar.Name = "DelightDesignerScrollableContentRegionVerticalScrollbar";
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_delightDesignerScrollableContentRegionVerticalScrollbar, DelightDesignerScrollableContentRegionVerticalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_delightDesignerScrollableContentRegionVerticalScrollbar, DelightDesignerScrollableContentRegionVerticalScrollbarHandle);
                }
                return _delightDesignerScrollableContentRegionVerticalScrollbar;
            }
        }

        private static Template _delightDesignerScrollableContentRegionVerticalScrollbarBar;
        public static Template DelightDesignerScrollableContentRegionVerticalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerScrollableContentRegionVerticalScrollbarBar == null || _delightDesignerScrollableContentRegionVerticalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerScrollableContentRegionVerticalScrollbarBar == null)
#endif
                {
                    _delightDesignerScrollableContentRegionVerticalScrollbarBar = new Template(ScrollableRegionTemplates.ScrollableRegionVerticalScrollbarBar);
#if UNITY_EDITOR
                    _delightDesignerScrollableContentRegionVerticalScrollbarBar.Name = "DelightDesignerScrollableContentRegionVerticalScrollbarBar";
#endif
                }
                return _delightDesignerScrollableContentRegionVerticalScrollbarBar;
            }
        }

        private static Template _delightDesignerScrollableContentRegionVerticalScrollbarHandle;
        public static Template DelightDesignerScrollableContentRegionVerticalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerScrollableContentRegionVerticalScrollbarHandle == null || _delightDesignerScrollableContentRegionVerticalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_delightDesignerScrollableContentRegionVerticalScrollbarHandle == null)
#endif
                {
                    _delightDesignerScrollableContentRegionVerticalScrollbarHandle = new Template(ScrollableRegionTemplates.ScrollableRegionVerticalScrollbarHandle);
#if UNITY_EDITOR
                    _delightDesignerScrollableContentRegionVerticalScrollbarHandle.Name = "DelightDesignerScrollableContentRegionVerticalScrollbarHandle";
#endif
                }
                return _delightDesignerScrollableContentRegionVerticalScrollbarHandle;
            }
        }

        private static Template _delightDesignerContentRegionCanvas;
        public static Template DelightDesignerContentRegionCanvas
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerContentRegionCanvas == null || _delightDesignerContentRegionCanvas.CurrentVersion != Template.Version)
#else
                if (_delightDesignerContentRegionCanvas == null)
#endif
                {
                    _delightDesignerContentRegionCanvas = new Template(UICanvasTemplates.UICanvas);
#if UNITY_EDITOR
                    _delightDesignerContentRegionCanvas.Name = "DelightDesignerContentRegionCanvas";
#endif
                    Delight.UICanvas.ScaleProperty.SetDefault(_delightDesignerContentRegionCanvas, new Vector3(1f, 1f, 1f));
                }
                return _delightDesignerContentRegionCanvas;
            }
        }

        private static Template _delightDesignerViewContentRegion;
        public static Template DelightDesignerViewContentRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerViewContentRegion == null || _delightDesignerViewContentRegion.CurrentVersion != Template.Version)
#else
                if (_delightDesignerViewContentRegion == null)
#endif
                {
                    _delightDesignerViewContentRegion = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _delightDesignerViewContentRegion.Name = "DelightDesignerViewContentRegion";
#endif
                }
                return _delightDesignerViewContentRegion;
            }
        }

        private static Template _delightDesignerContentExplorer;
        public static Template DelightDesignerContentExplorer
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerContentExplorer == null || _delightDesignerContentExplorer.CurrentVersion != Template.Version)
#else
                if (_delightDesignerContentExplorer == null)
#endif
                {
                    _delightDesignerContentExplorer = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _delightDesignerContentExplorer.Name = "DelightDesignerContentExplorer";
#endif
                    Delight.Region.BackgroundColorProperty.SetDefault(_delightDesignerContentExplorer, new UnityEngine.Color(0.8156863f, 0.8156863f, 0.827451f, 1f));
                }
                return _delightDesignerContentExplorer;
            }
        }

        private static Template _delightDesignerRegion2;
        public static Template DelightDesignerRegion2
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerRegion2 == null || _delightDesignerRegion2.CurrentVersion != Template.Version)
#else
                if (_delightDesignerRegion2 == null)
#endif
                {
                    _delightDesignerRegion2 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _delightDesignerRegion2.Name = "DelightDesignerRegion2";
#endif
                    Delight.Region.MarginProperty.SetDefault(_delightDesignerRegion2, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(8f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                }
                return _delightDesignerRegion2;
            }
        }

        private static Template _delightDesignerScrollableRegion1;
        public static Template DelightDesignerScrollableRegion1
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerScrollableRegion1 == null || _delightDesignerScrollableRegion1.CurrentVersion != Template.Version)
#else
                if (_delightDesignerScrollableRegion1 == null)
#endif
                {
                    _delightDesignerScrollableRegion1 = new Template(ScrollableRegionTemplates.ScrollableRegion);
#if UNITY_EDITOR
                    _delightDesignerScrollableRegion1.Name = "DelightDesignerScrollableRegion1";
#endif
                    Delight.ScrollableRegion.WidthProperty.SetDefault(_delightDesignerScrollableRegion1, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ScrollableRegion.HeightProperty.SetDefault(_delightDesignerScrollableRegion1, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.ScrollableRegion.ContentAlignmentProperty.SetDefault(_delightDesignerScrollableRegion1, Delight.ElementAlignment.Top);
                    Delight.ScrollableRegion.DisableInteractionScrollDeltaProperty.SetDefault(_delightDesignerScrollableRegion1, 1f);
                    Delight.ScrollableRegion.HasInertiaProperty.SetDefault(_delightDesignerScrollableRegion1, false);
                    Delight.ScrollableRegion.VerticalScrollbarVisibilityProperty.SetDefault(_delightDesignerScrollableRegion1, Delight.ScrollbarVisibilityMode.MouseOver);
                    Delight.ScrollableRegion.ContentRegionTemplateProperty.SetDefault(_delightDesignerScrollableRegion1, DelightDesignerScrollableRegion1ContentRegion);
                    Delight.ScrollableRegion.HorizontalScrollbarTemplateProperty.SetDefault(_delightDesignerScrollableRegion1, DelightDesignerScrollableRegion1HorizontalScrollbar);
                    Delight.ScrollableRegion.VerticalScrollbarTemplateProperty.SetDefault(_delightDesignerScrollableRegion1, DelightDesignerScrollableRegion1VerticalScrollbar);
                }
                return _delightDesignerScrollableRegion1;
            }
        }

        private static Template _delightDesignerScrollableRegion1ContentRegion;
        public static Template DelightDesignerScrollableRegion1ContentRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerScrollableRegion1ContentRegion == null || _delightDesignerScrollableRegion1ContentRegion.CurrentVersion != Template.Version)
#else
                if (_delightDesignerScrollableRegion1ContentRegion == null)
#endif
                {
                    _delightDesignerScrollableRegion1ContentRegion = new Template(ScrollableRegionTemplates.ScrollableRegionContentRegion);
#if UNITY_EDITOR
                    _delightDesignerScrollableRegion1ContentRegion.Name = "DelightDesignerScrollableRegion1ContentRegion";
#endif
                }
                return _delightDesignerScrollableRegion1ContentRegion;
            }
        }

        private static Template _delightDesignerScrollableRegion1HorizontalScrollbar;
        public static Template DelightDesignerScrollableRegion1HorizontalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerScrollableRegion1HorizontalScrollbar == null || _delightDesignerScrollableRegion1HorizontalScrollbar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerScrollableRegion1HorizontalScrollbar == null)
#endif
                {
                    _delightDesignerScrollableRegion1HorizontalScrollbar = new Template(ScrollableRegionTemplates.ScrollableRegionHorizontalScrollbar);
#if UNITY_EDITOR
                    _delightDesignerScrollableRegion1HorizontalScrollbar.Name = "DelightDesignerScrollableRegion1HorizontalScrollbar";
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_delightDesignerScrollableRegion1HorizontalScrollbar, DelightDesignerScrollableRegion1HorizontalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_delightDesignerScrollableRegion1HorizontalScrollbar, DelightDesignerScrollableRegion1HorizontalScrollbarHandle);
                }
                return _delightDesignerScrollableRegion1HorizontalScrollbar;
            }
        }

        private static Template _delightDesignerScrollableRegion1HorizontalScrollbarBar;
        public static Template DelightDesignerScrollableRegion1HorizontalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerScrollableRegion1HorizontalScrollbarBar == null || _delightDesignerScrollableRegion1HorizontalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerScrollableRegion1HorizontalScrollbarBar == null)
#endif
                {
                    _delightDesignerScrollableRegion1HorizontalScrollbarBar = new Template(ScrollableRegionTemplates.ScrollableRegionHorizontalScrollbarBar);
#if UNITY_EDITOR
                    _delightDesignerScrollableRegion1HorizontalScrollbarBar.Name = "DelightDesignerScrollableRegion1HorizontalScrollbarBar";
#endif
                }
                return _delightDesignerScrollableRegion1HorizontalScrollbarBar;
            }
        }

        private static Template _delightDesignerScrollableRegion1HorizontalScrollbarHandle;
        public static Template DelightDesignerScrollableRegion1HorizontalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerScrollableRegion1HorizontalScrollbarHandle == null || _delightDesignerScrollableRegion1HorizontalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_delightDesignerScrollableRegion1HorizontalScrollbarHandle == null)
#endif
                {
                    _delightDesignerScrollableRegion1HorizontalScrollbarHandle = new Template(ScrollableRegionTemplates.ScrollableRegionHorizontalScrollbarHandle);
#if UNITY_EDITOR
                    _delightDesignerScrollableRegion1HorizontalScrollbarHandle.Name = "DelightDesignerScrollableRegion1HorizontalScrollbarHandle";
#endif
                }
                return _delightDesignerScrollableRegion1HorizontalScrollbarHandle;
            }
        }

        private static Template _delightDesignerScrollableRegion1VerticalScrollbar;
        public static Template DelightDesignerScrollableRegion1VerticalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerScrollableRegion1VerticalScrollbar == null || _delightDesignerScrollableRegion1VerticalScrollbar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerScrollableRegion1VerticalScrollbar == null)
#endif
                {
                    _delightDesignerScrollableRegion1VerticalScrollbar = new Template(ScrollableRegionTemplates.ScrollableRegionVerticalScrollbar);
#if UNITY_EDITOR
                    _delightDesignerScrollableRegion1VerticalScrollbar.Name = "DelightDesignerScrollableRegion1VerticalScrollbar";
#endif
                    Delight.Scrollbar.BackgroundColorProperty.SetDefault(_delightDesignerScrollableRegion1VerticalScrollbar, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Scrollbar.WidthProperty.SetDefault(_delightDesignerScrollableRegion1VerticalScrollbar, new ElementSize(6f, ElementSizeUnit.Pixels));
                    Delight.Scrollbar.OffsetProperty.SetDefault(_delightDesignerScrollableRegion1VerticalScrollbar, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_delightDesignerScrollableRegion1VerticalScrollbar, DelightDesignerScrollableRegion1VerticalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_delightDesignerScrollableRegion1VerticalScrollbar, DelightDesignerScrollableRegion1VerticalScrollbarHandle);
                }
                return _delightDesignerScrollableRegion1VerticalScrollbar;
            }
        }

        private static Template _delightDesignerScrollableRegion1VerticalScrollbarBar;
        public static Template DelightDesignerScrollableRegion1VerticalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerScrollableRegion1VerticalScrollbarBar == null || _delightDesignerScrollableRegion1VerticalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerScrollableRegion1VerticalScrollbarBar == null)
#endif
                {
                    _delightDesignerScrollableRegion1VerticalScrollbarBar = new Template(ScrollableRegionTemplates.ScrollableRegionVerticalScrollbarBar);
#if UNITY_EDITOR
                    _delightDesignerScrollableRegion1VerticalScrollbarBar.Name = "DelightDesignerScrollableRegion1VerticalScrollbarBar";
#endif
                    Delight.Image.ColorProperty.SetDefault(_delightDesignerScrollableRegion1VerticalScrollbarBar, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.Image.MarginProperty.SetDefault(_delightDesignerScrollableRegion1VerticalScrollbarBar, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(2f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                }
                return _delightDesignerScrollableRegion1VerticalScrollbarBar;
            }
        }

        private static Template _delightDesignerScrollableRegion1VerticalScrollbarHandle;
        public static Template DelightDesignerScrollableRegion1VerticalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerScrollableRegion1VerticalScrollbarHandle == null || _delightDesignerScrollableRegion1VerticalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_delightDesignerScrollableRegion1VerticalScrollbarHandle == null)
#endif
                {
                    _delightDesignerScrollableRegion1VerticalScrollbarHandle = new Template(ScrollableRegionTemplates.ScrollableRegionVerticalScrollbarHandle);
#if UNITY_EDITOR
                    _delightDesignerScrollableRegion1VerticalScrollbarHandle.Name = "DelightDesignerScrollableRegion1VerticalScrollbarHandle";
#endif
                    Delight.Image.ColorProperty.SetDefault(_delightDesignerScrollableRegion1VerticalScrollbarHandle, new UnityEngine.Color(0.6235294f, 0.6235294f, 0.6235294f, 1f));
                }
                return _delightDesignerScrollableRegion1VerticalScrollbarHandle;
            }
        }

        private static Template _delightDesignerExpander1;
        public static Template DelightDesignerExpander1
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerExpander1 == null || _delightDesignerExpander1.CurrentVersion != Template.Version)
#else
                if (_delightDesignerExpander1 == null)
#endif
                {
                    _delightDesignerExpander1 = new Template(ExpanderTemplates.Expander);
#if UNITY_EDITOR
                    _delightDesignerExpander1.Name = "DelightDesignerExpander1";
#endif
                    Delight.Expander.TextProperty.SetDefault(_delightDesignerExpander1, "Views");
                    Delight.Expander.WidthProperty.SetDefault(_delightDesignerExpander1, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Expander.MarginProperty.SetDefault(_delightDesignerExpander1, new ElementMargin(new ElementSize(4f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                }
                return _delightDesignerExpander1;
            }
        }

        private static Template _delightDesignerExpander1Content;
        public static Template DelightDesignerExpander1Content
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerExpander1Content == null || _delightDesignerExpander1Content.CurrentVersion != Template.Version)
#else
                if (_delightDesignerExpander1Content == null)
#endif
                {
                    _delightDesignerExpander1Content = new Template(ExpanderContentTemplates.ExpanderContent);
#if UNITY_EDITOR
                    _delightDesignerExpander1Content.Name = "DelightDesignerExpander1Content";
#endif
                }
                return _delightDesignerExpander1Content;
            }
        }

        private static Template _delightDesignerList1;
        public static Template DelightDesignerList1
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerList1 == null || _delightDesignerList1.CurrentVersion != Template.Version)
#else
                if (_delightDesignerList1 == null)
#endif
                {
                    _delightDesignerList1 = new Template(ListTemplates.List);
#if UNITY_EDITOR
                    _delightDesignerList1.Name = "DelightDesignerList1";
#endif
                    Delight.List.AlignmentProperty.SetDefault(_delightDesignerList1, Delight.ElementAlignment.TopLeft);
                    Delight.List.MarginProperty.SetDefault(_delightDesignerList1, new ElementMargin(new ElementSize(4f, ElementSizeUnit.Pixels), new ElementSize(2f, ElementSizeUnit.Pixels), new ElementSize(2f, ElementSizeUnit.Pixels), new ElementSize(2f, ElementSizeUnit.Pixels)));
                    Delight.List.BackgroundColorProperty.SetDefault(_delightDesignerList1, new UnityEngine.Color(0f, 0f, 0f, 0f));
                    Delight.List.WidthProperty.SetDefault(_delightDesignerList1, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.List.CanReselectProperty.SetDefault(_delightDesignerList1, true);
                    Delight.List.ItemsProperty.SetHasBinding(_delightDesignerList1);
                    Delight.List.ScrollableRegionTemplateProperty.SetDefault(_delightDesignerList1, DelightDesignerList1ScrollableRegion);
                }
                return _delightDesignerList1;
            }
        }

        private static Template _delightDesignerList1ScrollableRegion;
        public static Template DelightDesignerList1ScrollableRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerList1ScrollableRegion == null || _delightDesignerList1ScrollableRegion.CurrentVersion != Template.Version)
#else
                if (_delightDesignerList1ScrollableRegion == null)
#endif
                {
                    _delightDesignerList1ScrollableRegion = new Template(ListTemplates.ListScrollableRegion);
#if UNITY_EDITOR
                    _delightDesignerList1ScrollableRegion.Name = "DelightDesignerList1ScrollableRegion";
#endif
                    Delight.ScrollableRegion.ContentRegionTemplateProperty.SetDefault(_delightDesignerList1ScrollableRegion, DelightDesignerList1ScrollableRegionContentRegion);
                    Delight.ScrollableRegion.HorizontalScrollbarTemplateProperty.SetDefault(_delightDesignerList1ScrollableRegion, DelightDesignerList1ScrollableRegionHorizontalScrollbar);
                    Delight.ScrollableRegion.VerticalScrollbarTemplateProperty.SetDefault(_delightDesignerList1ScrollableRegion, DelightDesignerList1ScrollableRegionVerticalScrollbar);
                }
                return _delightDesignerList1ScrollableRegion;
            }
        }

        private static Template _delightDesignerList1ScrollableRegionContentRegion;
        public static Template DelightDesignerList1ScrollableRegionContentRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerList1ScrollableRegionContentRegion == null || _delightDesignerList1ScrollableRegionContentRegion.CurrentVersion != Template.Version)
#else
                if (_delightDesignerList1ScrollableRegionContentRegion == null)
#endif
                {
                    _delightDesignerList1ScrollableRegionContentRegion = new Template(ListTemplates.ListScrollableRegionContentRegion);
#if UNITY_EDITOR
                    _delightDesignerList1ScrollableRegionContentRegion.Name = "DelightDesignerList1ScrollableRegionContentRegion";
#endif
                }
                return _delightDesignerList1ScrollableRegionContentRegion;
            }
        }

        private static Template _delightDesignerList1ScrollableRegionHorizontalScrollbar;
        public static Template DelightDesignerList1ScrollableRegionHorizontalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerList1ScrollableRegionHorizontalScrollbar == null || _delightDesignerList1ScrollableRegionHorizontalScrollbar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerList1ScrollableRegionHorizontalScrollbar == null)
#endif
                {
                    _delightDesignerList1ScrollableRegionHorizontalScrollbar = new Template(ListTemplates.ListScrollableRegionHorizontalScrollbar);
#if UNITY_EDITOR
                    _delightDesignerList1ScrollableRegionHorizontalScrollbar.Name = "DelightDesignerList1ScrollableRegionHorizontalScrollbar";
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_delightDesignerList1ScrollableRegionHorizontalScrollbar, DelightDesignerList1ScrollableRegionHorizontalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_delightDesignerList1ScrollableRegionHorizontalScrollbar, DelightDesignerList1ScrollableRegionHorizontalScrollbarHandle);
                }
                return _delightDesignerList1ScrollableRegionHorizontalScrollbar;
            }
        }

        private static Template _delightDesignerList1ScrollableRegionHorizontalScrollbarBar;
        public static Template DelightDesignerList1ScrollableRegionHorizontalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerList1ScrollableRegionHorizontalScrollbarBar == null || _delightDesignerList1ScrollableRegionHorizontalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerList1ScrollableRegionHorizontalScrollbarBar == null)
#endif
                {
                    _delightDesignerList1ScrollableRegionHorizontalScrollbarBar = new Template(ListTemplates.ListScrollableRegionHorizontalScrollbarBar);
#if UNITY_EDITOR
                    _delightDesignerList1ScrollableRegionHorizontalScrollbarBar.Name = "DelightDesignerList1ScrollableRegionHorizontalScrollbarBar";
#endif
                }
                return _delightDesignerList1ScrollableRegionHorizontalScrollbarBar;
            }
        }

        private static Template _delightDesignerList1ScrollableRegionHorizontalScrollbarHandle;
        public static Template DelightDesignerList1ScrollableRegionHorizontalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerList1ScrollableRegionHorizontalScrollbarHandle == null || _delightDesignerList1ScrollableRegionHorizontalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_delightDesignerList1ScrollableRegionHorizontalScrollbarHandle == null)
#endif
                {
                    _delightDesignerList1ScrollableRegionHorizontalScrollbarHandle = new Template(ListTemplates.ListScrollableRegionHorizontalScrollbarHandle);
#if UNITY_EDITOR
                    _delightDesignerList1ScrollableRegionHorizontalScrollbarHandle.Name = "DelightDesignerList1ScrollableRegionHorizontalScrollbarHandle";
#endif
                }
                return _delightDesignerList1ScrollableRegionHorizontalScrollbarHandle;
            }
        }

        private static Template _delightDesignerList1ScrollableRegionVerticalScrollbar;
        public static Template DelightDesignerList1ScrollableRegionVerticalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerList1ScrollableRegionVerticalScrollbar == null || _delightDesignerList1ScrollableRegionVerticalScrollbar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerList1ScrollableRegionVerticalScrollbar == null)
#endif
                {
                    _delightDesignerList1ScrollableRegionVerticalScrollbar = new Template(ListTemplates.ListScrollableRegionVerticalScrollbar);
#if UNITY_EDITOR
                    _delightDesignerList1ScrollableRegionVerticalScrollbar.Name = "DelightDesignerList1ScrollableRegionVerticalScrollbar";
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_delightDesignerList1ScrollableRegionVerticalScrollbar, DelightDesignerList1ScrollableRegionVerticalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_delightDesignerList1ScrollableRegionVerticalScrollbar, DelightDesignerList1ScrollableRegionVerticalScrollbarHandle);
                }
                return _delightDesignerList1ScrollableRegionVerticalScrollbar;
            }
        }

        private static Template _delightDesignerList1ScrollableRegionVerticalScrollbarBar;
        public static Template DelightDesignerList1ScrollableRegionVerticalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerList1ScrollableRegionVerticalScrollbarBar == null || _delightDesignerList1ScrollableRegionVerticalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerList1ScrollableRegionVerticalScrollbarBar == null)
#endif
                {
                    _delightDesignerList1ScrollableRegionVerticalScrollbarBar = new Template(ListTemplates.ListScrollableRegionVerticalScrollbarBar);
#if UNITY_EDITOR
                    _delightDesignerList1ScrollableRegionVerticalScrollbarBar.Name = "DelightDesignerList1ScrollableRegionVerticalScrollbarBar";
#endif
                }
                return _delightDesignerList1ScrollableRegionVerticalScrollbarBar;
            }
        }

        private static Template _delightDesignerList1ScrollableRegionVerticalScrollbarHandle;
        public static Template DelightDesignerList1ScrollableRegionVerticalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerList1ScrollableRegionVerticalScrollbarHandle == null || _delightDesignerList1ScrollableRegionVerticalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_delightDesignerList1ScrollableRegionVerticalScrollbarHandle == null)
#endif
                {
                    _delightDesignerList1ScrollableRegionVerticalScrollbarHandle = new Template(ListTemplates.ListScrollableRegionVerticalScrollbarHandle);
#if UNITY_EDITOR
                    _delightDesignerList1ScrollableRegionVerticalScrollbarHandle.Name = "DelightDesignerList1ScrollableRegionVerticalScrollbarHandle";
#endif
                }
                return _delightDesignerList1ScrollableRegionVerticalScrollbarHandle;
            }
        }

        private static Template _delightDesignerListItem1;
        public static Template DelightDesignerListItem1
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerListItem1 == null || _delightDesignerListItem1.CurrentVersion != Template.Version)
#else
                if (_delightDesignerListItem1 == null)
#endif
                {
                    _delightDesignerListItem1 = new Template(ListItemTemplates.ListItem);
#if UNITY_EDITOR
                    _delightDesignerListItem1.Name = "DelightDesignerListItem1";
#endif
                    Delight.ListItem.MarginProperty.SetDefault(_delightDesignerListItem1, new ElementMargin(new ElementSize(4f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(8f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.ListItem.BackgroundSpriteProperty.SetStateDefault("Pressed", _delightDesignerListItem1, Assets.Sprites["ListSelection"]);
                    Delight.ListItem.BackgroundSpriteProperty.SetStateDefault("Highlighted", _delightDesignerListItem1, Assets.Sprites["ListSelection"]);
                    Delight.ListItem.BackgroundColorProperty.SetStateDefault("Highlighted", _delightDesignerListItem1, new UnityEngine.Color(0.9764706f, 0.9764706f, 0.9764706f, 1f));
                    Delight.ListItem.BackgroundColorProperty.SetStateDefault("Selected", _delightDesignerListItem1, new UnityEngine.Color(0.9568627f, 0.9568627f, 0.9568627f, 1f));
                    Delight.ListItem.BackgroundColorProperty.SetStateDefault("Pressed", _delightDesignerListItem1, new UnityEngine.Color(0.9568627f, 0.9568627f, 0.9568627f, 1f));
                }
                return _delightDesignerListItem1;
            }
        }

        private static Template _delightDesignerLabel1;
        public static Template DelightDesignerLabel1
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerLabel1 == null || _delightDesignerLabel1.CurrentVersion != Template.Version)
#else
                if (_delightDesignerLabel1 == null)
#endif
                {
                    _delightDesignerLabel1 = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _delightDesignerLabel1.Name = "DelightDesignerLabel1";
#endif
                    Delight.Label.FontSizeProperty.SetDefault(_delightDesignerLabel1, 16f);
                    Delight.Label.FontProperty.SetDefault(_delightDesignerLabel1, Assets.TMP_FontAssets["Segoe UI SDF"]);
                    Delight.Label.HeightProperty.SetDefault(_delightDesignerLabel1, new ElementSize(24f, ElementSizeUnit.Pixels));
                    Delight.Label.FontColorProperty.SetDefault(_delightDesignerLabel1, new UnityEngine.Color(0.2235294f, 0.2666667f, 0.3490196f, 1f));
                    Delight.Label.WidthProperty.SetDefault(_delightDesignerLabel1, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.MarginProperty.SetDefault(_delightDesignerLabel1, new ElementMargin(new ElementSize(12f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_delightDesignerLabel1, false);
                    Delight.Label.OverflowModeProperty.SetDefault(_delightDesignerLabel1, TMPro.TextOverflowModes.Truncate);
                    Delight.Label.ExtraPaddingProperty.SetDefault(_delightDesignerLabel1, true);
                    Delight.Label.FontColorProperty.SetStateDefault("Highlighted", _delightDesignerLabel1, new UnityEngine.Color(0.2f, 0.2f, 0.2f, 1f));
                    Delight.Label.FontColorProperty.SetStateDefault("Selected", _delightDesignerLabel1, new UnityEngine.Color(0.2f, 0.2f, 0.2f, 1f));
                    Delight.Label.TextProperty.SetHasBinding(_delightDesignerLabel1);
                }
                return _delightDesignerLabel1;
            }
        }

        private static Template _delightDesignerXmlEditorRegion;
        public static Template DelightDesignerXmlEditorRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorRegion == null || _delightDesignerXmlEditorRegion.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorRegion == null)
#endif
                {
                    _delightDesignerXmlEditorRegion = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorRegion.Name = "DelightDesignerXmlEditorRegion";
#endif
                    Delight.Region.BackgroundColorProperty.SetDefault(_delightDesignerXmlEditorRegion, new UnityEngine.Color(0.9843137f, 0.9843137f, 0.9843137f, 1f));
                    Delight.Region.IsVisibleProperty.SetDefault(_delightDesignerXmlEditorRegion, false);
                }
                return _delightDesignerXmlEditorRegion;
            }
        }

        private static Template _delightDesignerXmlEditor;
        public static Template DelightDesignerXmlEditor
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditor == null || _delightDesignerXmlEditor.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditor == null)
#endif
                {
                    _delightDesignerXmlEditor = new Template(XmlEditorTemplates.XmlEditor);
#if UNITY_EDITOR
                    _delightDesignerXmlEditor.Name = "DelightDesignerXmlEditor";
#endif
                    Delight.XmlEditor.MarginProperty.SetDefault(_delightDesignerXmlEditor, new ElementMargin(new ElementSize(10f, ElementSizeUnit.Pixels), new ElementSize(21f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(20f, ElementSizeUnit.Pixels)));
                    Delight.XmlEditor.DesignerViewsProperty.SetHasBinding(_delightDesignerXmlEditor);
                    Delight.XmlEditor.ScrollableRegionTemplateProperty.SetDefault(_delightDesignerXmlEditor, DelightDesignerXmlEditorScrollableRegion);
                    Delight.XmlEditor.XmlEditRegionTemplateProperty.SetDefault(_delightDesignerXmlEditor, DelightDesignerXmlEditorXmlEditRegion);
                    Delight.XmlEditor.XmlTextRegionTemplateProperty.SetDefault(_delightDesignerXmlEditor, DelightDesignerXmlEditorXmlTextRegion);
                    Delight.XmlEditor.TextSelectionTemplateProperty.SetDefault(_delightDesignerXmlEditor, DelightDesignerXmlEditorTextSelection);
                    Delight.XmlEditor.XmlTextLabelTemplateProperty.SetDefault(_delightDesignerXmlEditor, DelightDesignerXmlEditorXmlTextLabel);
                    Delight.XmlEditor.CaretTemplateProperty.SetDefault(_delightDesignerXmlEditor, DelightDesignerXmlEditorCaret);
                    Delight.XmlEditor.UICanvas1TemplateProperty.SetDefault(_delightDesignerXmlEditor, DelightDesignerXmlEditorUICanvas1);
                    Delight.XmlEditor.AutoCompleteBoxTemplateProperty.SetDefault(_delightDesignerXmlEditor, DelightDesignerXmlEditorAutoCompleteBox);
                    Delight.XmlEditor.AutoCompleteOptionsListTemplateProperty.SetDefault(_delightDesignerXmlEditor, DelightDesignerXmlEditorAutoCompleteOptionsList);
                    Delight.XmlEditor.DefaultOptionItemTemplateProperty.SetDefault(_delightDesignerXmlEditor, DelightDesignerXmlEditorDefaultOptionItem);
                    Delight.XmlEditor.Label1TemplateProperty.SetDefault(_delightDesignerXmlEditor, DelightDesignerXmlEditorLabel1);
                    Delight.XmlEditor.AssetOptionItemTemplateProperty.SetDefault(_delightDesignerXmlEditor, DelightDesignerXmlEditorAssetOptionItem);
                    Delight.XmlEditor.RawImage1TemplateProperty.SetDefault(_delightDesignerXmlEditor, DelightDesignerXmlEditorRawImage1);
                    Delight.XmlEditor.Label2TemplateProperty.SetDefault(_delightDesignerXmlEditor, DelightDesignerXmlEditorLabel2);
                    Delight.XmlEditor.DebugTextLabelTemplateProperty.SetDefault(_delightDesignerXmlEditor, DelightDesignerXmlEditorDebugTextLabel);
                    Delight.XmlEditor.TooltipBoxTemplateProperty.SetDefault(_delightDesignerXmlEditor, DelightDesignerXmlEditorTooltipBox);
                    Delight.XmlEditor.TooltipLabelTemplateProperty.SetDefault(_delightDesignerXmlEditor, DelightDesignerXmlEditorTooltipLabel);
                    Delight.XmlEditor.Image1TemplateProperty.SetDefault(_delightDesignerXmlEditor, DelightDesignerXmlEditorImage1);
                    Delight.XmlEditor.XmlEditLeftMarginTemplateProperty.SetDefault(_delightDesignerXmlEditor, DelightDesignerXmlEditorXmlEditLeftMargin);
                    Delight.XmlEditor.LineNumbersLabelTemplateProperty.SetDefault(_delightDesignerXmlEditor, DelightDesignerXmlEditorLineNumbersLabel);
                    Delight.XmlEditor.LineNumbersRightBorderTemplateProperty.SetDefault(_delightDesignerXmlEditor, DelightDesignerXmlEditorLineNumbersRightBorder);
                }
                return _delightDesignerXmlEditor;
            }
        }

        private static Template _delightDesignerXmlEditorScrollableRegion;
        public static Template DelightDesignerXmlEditorScrollableRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorScrollableRegion == null || _delightDesignerXmlEditorScrollableRegion.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorScrollableRegion == null)
#endif
                {
                    _delightDesignerXmlEditorScrollableRegion = new Template(XmlEditorTemplates.XmlEditorScrollableRegion);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorScrollableRegion.Name = "DelightDesignerXmlEditorScrollableRegion";
#endif
                    Delight.ScrollableRegion.ContentRegionTemplateProperty.SetDefault(_delightDesignerXmlEditorScrollableRegion, DelightDesignerXmlEditorScrollableRegionContentRegion);
                    Delight.ScrollableRegion.HorizontalScrollbarTemplateProperty.SetDefault(_delightDesignerXmlEditorScrollableRegion, DelightDesignerXmlEditorScrollableRegionHorizontalScrollbar);
                    Delight.ScrollableRegion.VerticalScrollbarTemplateProperty.SetDefault(_delightDesignerXmlEditorScrollableRegion, DelightDesignerXmlEditorScrollableRegionVerticalScrollbar);
                }
                return _delightDesignerXmlEditorScrollableRegion;
            }
        }

        private static Template _delightDesignerXmlEditorScrollableRegionContentRegion;
        public static Template DelightDesignerXmlEditorScrollableRegionContentRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorScrollableRegionContentRegion == null || _delightDesignerXmlEditorScrollableRegionContentRegion.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorScrollableRegionContentRegion == null)
#endif
                {
                    _delightDesignerXmlEditorScrollableRegionContentRegion = new Template(XmlEditorTemplates.XmlEditorScrollableRegionContentRegion);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorScrollableRegionContentRegion.Name = "DelightDesignerXmlEditorScrollableRegionContentRegion";
#endif
                }
                return _delightDesignerXmlEditorScrollableRegionContentRegion;
            }
        }

        private static Template _delightDesignerXmlEditorScrollableRegionHorizontalScrollbar;
        public static Template DelightDesignerXmlEditorScrollableRegionHorizontalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorScrollableRegionHorizontalScrollbar == null || _delightDesignerXmlEditorScrollableRegionHorizontalScrollbar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorScrollableRegionHorizontalScrollbar == null)
#endif
                {
                    _delightDesignerXmlEditorScrollableRegionHorizontalScrollbar = new Template(XmlEditorTemplates.XmlEditorScrollableRegionHorizontalScrollbar);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorScrollableRegionHorizontalScrollbar.Name = "DelightDesignerXmlEditorScrollableRegionHorizontalScrollbar";
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_delightDesignerXmlEditorScrollableRegionHorizontalScrollbar, DelightDesignerXmlEditorScrollableRegionHorizontalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_delightDesignerXmlEditorScrollableRegionHorizontalScrollbar, DelightDesignerXmlEditorScrollableRegionHorizontalScrollbarHandle);
                }
                return _delightDesignerXmlEditorScrollableRegionHorizontalScrollbar;
            }
        }

        private static Template _delightDesignerXmlEditorScrollableRegionHorizontalScrollbarBar;
        public static Template DelightDesignerXmlEditorScrollableRegionHorizontalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorScrollableRegionHorizontalScrollbarBar == null || _delightDesignerXmlEditorScrollableRegionHorizontalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorScrollableRegionHorizontalScrollbarBar == null)
#endif
                {
                    _delightDesignerXmlEditorScrollableRegionHorizontalScrollbarBar = new Template(XmlEditorTemplates.XmlEditorScrollableRegionHorizontalScrollbarBar);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorScrollableRegionHorizontalScrollbarBar.Name = "DelightDesignerXmlEditorScrollableRegionHorizontalScrollbarBar";
#endif
                }
                return _delightDesignerXmlEditorScrollableRegionHorizontalScrollbarBar;
            }
        }

        private static Template _delightDesignerXmlEditorScrollableRegionHorizontalScrollbarHandle;
        public static Template DelightDesignerXmlEditorScrollableRegionHorizontalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorScrollableRegionHorizontalScrollbarHandle == null || _delightDesignerXmlEditorScrollableRegionHorizontalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorScrollableRegionHorizontalScrollbarHandle == null)
#endif
                {
                    _delightDesignerXmlEditorScrollableRegionHorizontalScrollbarHandle = new Template(XmlEditorTemplates.XmlEditorScrollableRegionHorizontalScrollbarHandle);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorScrollableRegionHorizontalScrollbarHandle.Name = "DelightDesignerXmlEditorScrollableRegionHorizontalScrollbarHandle";
#endif
                }
                return _delightDesignerXmlEditorScrollableRegionHorizontalScrollbarHandle;
            }
        }

        private static Template _delightDesignerXmlEditorScrollableRegionVerticalScrollbar;
        public static Template DelightDesignerXmlEditorScrollableRegionVerticalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorScrollableRegionVerticalScrollbar == null || _delightDesignerXmlEditorScrollableRegionVerticalScrollbar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorScrollableRegionVerticalScrollbar == null)
#endif
                {
                    _delightDesignerXmlEditorScrollableRegionVerticalScrollbar = new Template(XmlEditorTemplates.XmlEditorScrollableRegionVerticalScrollbar);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorScrollableRegionVerticalScrollbar.Name = "DelightDesignerXmlEditorScrollableRegionVerticalScrollbar";
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_delightDesignerXmlEditorScrollableRegionVerticalScrollbar, DelightDesignerXmlEditorScrollableRegionVerticalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_delightDesignerXmlEditorScrollableRegionVerticalScrollbar, DelightDesignerXmlEditorScrollableRegionVerticalScrollbarHandle);
                }
                return _delightDesignerXmlEditorScrollableRegionVerticalScrollbar;
            }
        }

        private static Template _delightDesignerXmlEditorScrollableRegionVerticalScrollbarBar;
        public static Template DelightDesignerXmlEditorScrollableRegionVerticalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorScrollableRegionVerticalScrollbarBar == null || _delightDesignerXmlEditorScrollableRegionVerticalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorScrollableRegionVerticalScrollbarBar == null)
#endif
                {
                    _delightDesignerXmlEditorScrollableRegionVerticalScrollbarBar = new Template(XmlEditorTemplates.XmlEditorScrollableRegionVerticalScrollbarBar);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorScrollableRegionVerticalScrollbarBar.Name = "DelightDesignerXmlEditorScrollableRegionVerticalScrollbarBar";
#endif
                }
                return _delightDesignerXmlEditorScrollableRegionVerticalScrollbarBar;
            }
        }

        private static Template _delightDesignerXmlEditorScrollableRegionVerticalScrollbarHandle;
        public static Template DelightDesignerXmlEditorScrollableRegionVerticalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorScrollableRegionVerticalScrollbarHandle == null || _delightDesignerXmlEditorScrollableRegionVerticalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorScrollableRegionVerticalScrollbarHandle == null)
#endif
                {
                    _delightDesignerXmlEditorScrollableRegionVerticalScrollbarHandle = new Template(XmlEditorTemplates.XmlEditorScrollableRegionVerticalScrollbarHandle);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorScrollableRegionVerticalScrollbarHandle.Name = "DelightDesignerXmlEditorScrollableRegionVerticalScrollbarHandle";
#endif
                }
                return _delightDesignerXmlEditorScrollableRegionVerticalScrollbarHandle;
            }
        }

        private static Template _delightDesignerXmlEditorXmlEditRegion;
        public static Template DelightDesignerXmlEditorXmlEditRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorXmlEditRegion == null || _delightDesignerXmlEditorXmlEditRegion.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorXmlEditRegion == null)
#endif
                {
                    _delightDesignerXmlEditorXmlEditRegion = new Template(XmlEditorTemplates.XmlEditorXmlEditRegion);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorXmlEditRegion.Name = "DelightDesignerXmlEditorXmlEditRegion";
#endif
                }
                return _delightDesignerXmlEditorXmlEditRegion;
            }
        }

        private static Template _delightDesignerXmlEditorXmlTextRegion;
        public static Template DelightDesignerXmlEditorXmlTextRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorXmlTextRegion == null || _delightDesignerXmlEditorXmlTextRegion.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorXmlTextRegion == null)
#endif
                {
                    _delightDesignerXmlEditorXmlTextRegion = new Template(XmlEditorTemplates.XmlEditorXmlTextRegion);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorXmlTextRegion.Name = "DelightDesignerXmlEditorXmlTextRegion";
#endif
                }
                return _delightDesignerXmlEditorXmlTextRegion;
            }
        }

        private static Template _delightDesignerXmlEditorTextSelection;
        public static Template DelightDesignerXmlEditorTextSelection
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorTextSelection == null || _delightDesignerXmlEditorTextSelection.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorTextSelection == null)
#endif
                {
                    _delightDesignerXmlEditorTextSelection = new Template(XmlEditorTemplates.XmlEditorTextSelection);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorTextSelection.Name = "DelightDesignerXmlEditorTextSelection";
#endif
                }
                return _delightDesignerXmlEditorTextSelection;
            }
        }

        private static Template _delightDesignerXmlEditorXmlTextLabel;
        public static Template DelightDesignerXmlEditorXmlTextLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorXmlTextLabel == null || _delightDesignerXmlEditorXmlTextLabel.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorXmlTextLabel == null)
#endif
                {
                    _delightDesignerXmlEditorXmlTextLabel = new Template(XmlEditorTemplates.XmlEditorXmlTextLabel);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorXmlTextLabel.Name = "DelightDesignerXmlEditorXmlTextLabel";
#endif
                }
                return _delightDesignerXmlEditorXmlTextLabel;
            }
        }

        private static Template _delightDesignerXmlEditorCaret;
        public static Template DelightDesignerXmlEditorCaret
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorCaret == null || _delightDesignerXmlEditorCaret.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorCaret == null)
#endif
                {
                    _delightDesignerXmlEditorCaret = new Template(XmlEditorTemplates.XmlEditorCaret);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorCaret.Name = "DelightDesignerXmlEditorCaret";
#endif
                }
                return _delightDesignerXmlEditorCaret;
            }
        }

        private static Template _delightDesignerXmlEditorUICanvas1;
        public static Template DelightDesignerXmlEditorUICanvas1
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorUICanvas1 == null || _delightDesignerXmlEditorUICanvas1.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorUICanvas1 == null)
#endif
                {
                    _delightDesignerXmlEditorUICanvas1 = new Template(XmlEditorTemplates.XmlEditorUICanvas1);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorUICanvas1.Name = "DelightDesignerXmlEditorUICanvas1";
#endif
                }
                return _delightDesignerXmlEditorUICanvas1;
            }
        }

        private static Template _delightDesignerXmlEditorAutoCompleteBox;
        public static Template DelightDesignerXmlEditorAutoCompleteBox
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorAutoCompleteBox == null || _delightDesignerXmlEditorAutoCompleteBox.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorAutoCompleteBox == null)
#endif
                {
                    _delightDesignerXmlEditorAutoCompleteBox = new Template(XmlEditorTemplates.XmlEditorAutoCompleteBox);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorAutoCompleteBox.Name = "DelightDesignerXmlEditorAutoCompleteBox";
#endif
                }
                return _delightDesignerXmlEditorAutoCompleteBox;
            }
        }

        private static Template _delightDesignerXmlEditorAutoCompleteOptionsList;
        public static Template DelightDesignerXmlEditorAutoCompleteOptionsList
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorAutoCompleteOptionsList == null || _delightDesignerXmlEditorAutoCompleteOptionsList.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorAutoCompleteOptionsList == null)
#endif
                {
                    _delightDesignerXmlEditorAutoCompleteOptionsList = new Template(XmlEditorTemplates.XmlEditorAutoCompleteOptionsList);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorAutoCompleteOptionsList.Name = "DelightDesignerXmlEditorAutoCompleteOptionsList";
#endif
                    Delight.List.ScrollableRegionTemplateProperty.SetDefault(_delightDesignerXmlEditorAutoCompleteOptionsList, DelightDesignerXmlEditorAutoCompleteOptionsListScrollableRegion);
                }
                return _delightDesignerXmlEditorAutoCompleteOptionsList;
            }
        }

        private static Template _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegion;
        public static Template DelightDesignerXmlEditorAutoCompleteOptionsListScrollableRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegion == null || _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegion.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegion == null)
#endif
                {
                    _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegion = new Template(XmlEditorTemplates.XmlEditorAutoCompleteOptionsListScrollableRegion);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegion.Name = "DelightDesignerXmlEditorAutoCompleteOptionsListScrollableRegion";
#endif
                    Delight.ScrollableRegion.ContentRegionTemplateProperty.SetDefault(_delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegion, DelightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionContentRegion);
                    Delight.ScrollableRegion.HorizontalScrollbarTemplateProperty.SetDefault(_delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegion, DelightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbar);
                    Delight.ScrollableRegion.VerticalScrollbarTemplateProperty.SetDefault(_delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegion, DelightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbar);
                }
                return _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegion;
            }
        }

        private static Template _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionContentRegion;
        public static Template DelightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionContentRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionContentRegion == null || _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionContentRegion.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionContentRegion == null)
#endif
                {
                    _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionContentRegion = new Template(XmlEditorTemplates.XmlEditorAutoCompleteOptionsListScrollableRegionContentRegion);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionContentRegion.Name = "DelightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionContentRegion";
#endif
                }
                return _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionContentRegion;
            }
        }

        private static Template _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbar;
        public static Template DelightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbar == null || _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbar == null)
#endif
                {
                    _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbar = new Template(XmlEditorTemplates.XmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbar);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbar.Name = "DelightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbar";
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbar, DelightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbar, DelightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbarHandle);
                }
                return _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbar;
            }
        }

        private static Template _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbarBar;
        public static Template DelightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbarBar == null || _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbarBar == null)
#endif
                {
                    _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbarBar = new Template(XmlEditorTemplates.XmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbarBar);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbarBar.Name = "DelightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbarBar";
#endif
                }
                return _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbarBar;
            }
        }

        private static Template _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbarHandle;
        public static Template DelightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbarHandle == null || _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbarHandle == null)
#endif
                {
                    _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbarHandle = new Template(XmlEditorTemplates.XmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbarHandle);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbarHandle.Name = "DelightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbarHandle";
#endif
                }
                return _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionHorizontalScrollbarHandle;
            }
        }

        private static Template _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbar;
        public static Template DelightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbar == null || _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbar == null)
#endif
                {
                    _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbar = new Template(XmlEditorTemplates.XmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbar);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbar.Name = "DelightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbar";
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbar, DelightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbar, DelightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbarHandle);
                }
                return _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbar;
            }
        }

        private static Template _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbarBar;
        public static Template DelightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbarBar == null || _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbarBar == null)
#endif
                {
                    _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbarBar = new Template(XmlEditorTemplates.XmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbarBar);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbarBar.Name = "DelightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbarBar";
#endif
                }
                return _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbarBar;
            }
        }

        private static Template _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbarHandle;
        public static Template DelightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbarHandle == null || _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbarHandle == null)
#endif
                {
                    _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbarHandle = new Template(XmlEditorTemplates.XmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbarHandle);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbarHandle.Name = "DelightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbarHandle";
#endif
                }
                return _delightDesignerXmlEditorAutoCompleteOptionsListScrollableRegionVerticalScrollbarHandle;
            }
        }

        private static Template _delightDesignerXmlEditorDefaultOptionItem;
        public static Template DelightDesignerXmlEditorDefaultOptionItem
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorDefaultOptionItem == null || _delightDesignerXmlEditorDefaultOptionItem.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorDefaultOptionItem == null)
#endif
                {
                    _delightDesignerXmlEditorDefaultOptionItem = new Template(XmlEditorTemplates.XmlEditorDefaultOptionItem);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorDefaultOptionItem.Name = "DelightDesignerXmlEditorDefaultOptionItem";
#endif
                }
                return _delightDesignerXmlEditorDefaultOptionItem;
            }
        }

        private static Template _delightDesignerXmlEditorLabel1;
        public static Template DelightDesignerXmlEditorLabel1
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorLabel1 == null || _delightDesignerXmlEditorLabel1.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorLabel1 == null)
#endif
                {
                    _delightDesignerXmlEditorLabel1 = new Template(XmlEditorTemplates.XmlEditorLabel1);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorLabel1.Name = "DelightDesignerXmlEditorLabel1";
#endif
                }
                return _delightDesignerXmlEditorLabel1;
            }
        }

        private static Template _delightDesignerXmlEditorAssetOptionItem;
        public static Template DelightDesignerXmlEditorAssetOptionItem
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorAssetOptionItem == null || _delightDesignerXmlEditorAssetOptionItem.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorAssetOptionItem == null)
#endif
                {
                    _delightDesignerXmlEditorAssetOptionItem = new Template(XmlEditorTemplates.XmlEditorAssetOptionItem);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorAssetOptionItem.Name = "DelightDesignerXmlEditorAssetOptionItem";
#endif
                }
                return _delightDesignerXmlEditorAssetOptionItem;
            }
        }

        private static Template _delightDesignerXmlEditorRawImage1;
        public static Template DelightDesignerXmlEditorRawImage1
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorRawImage1 == null || _delightDesignerXmlEditorRawImage1.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorRawImage1 == null)
#endif
                {
                    _delightDesignerXmlEditorRawImage1 = new Template(XmlEditorTemplates.XmlEditorRawImage1);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorRawImage1.Name = "DelightDesignerXmlEditorRawImage1";
#endif
                }
                return _delightDesignerXmlEditorRawImage1;
            }
        }

        private static Template _delightDesignerXmlEditorLabel2;
        public static Template DelightDesignerXmlEditorLabel2
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorLabel2 == null || _delightDesignerXmlEditorLabel2.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorLabel2 == null)
#endif
                {
                    _delightDesignerXmlEditorLabel2 = new Template(XmlEditorTemplates.XmlEditorLabel2);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorLabel2.Name = "DelightDesignerXmlEditorLabel2";
#endif
                }
                return _delightDesignerXmlEditorLabel2;
            }
        }

        private static Template _delightDesignerXmlEditorDebugTextLabel;
        public static Template DelightDesignerXmlEditorDebugTextLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorDebugTextLabel == null || _delightDesignerXmlEditorDebugTextLabel.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorDebugTextLabel == null)
#endif
                {
                    _delightDesignerXmlEditorDebugTextLabel = new Template(XmlEditorTemplates.XmlEditorDebugTextLabel);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorDebugTextLabel.Name = "DelightDesignerXmlEditorDebugTextLabel";
#endif
                }
                return _delightDesignerXmlEditorDebugTextLabel;
            }
        }

        private static Template _delightDesignerXmlEditorTooltipBox;
        public static Template DelightDesignerXmlEditorTooltipBox
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorTooltipBox == null || _delightDesignerXmlEditorTooltipBox.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorTooltipBox == null)
#endif
                {
                    _delightDesignerXmlEditorTooltipBox = new Template(XmlEditorTemplates.XmlEditorTooltipBox);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorTooltipBox.Name = "DelightDesignerXmlEditorTooltipBox";
#endif
                }
                return _delightDesignerXmlEditorTooltipBox;
            }
        }

        private static Template _delightDesignerXmlEditorTooltipLabel;
        public static Template DelightDesignerXmlEditorTooltipLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorTooltipLabel == null || _delightDesignerXmlEditorTooltipLabel.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorTooltipLabel == null)
#endif
                {
                    _delightDesignerXmlEditorTooltipLabel = new Template(XmlEditorTemplates.XmlEditorTooltipLabel);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorTooltipLabel.Name = "DelightDesignerXmlEditorTooltipLabel";
#endif
                }
                return _delightDesignerXmlEditorTooltipLabel;
            }
        }

        private static Template _delightDesignerXmlEditorImage1;
        public static Template DelightDesignerXmlEditorImage1
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorImage1 == null || _delightDesignerXmlEditorImage1.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorImage1 == null)
#endif
                {
                    _delightDesignerXmlEditorImage1 = new Template(XmlEditorTemplates.XmlEditorImage1);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorImage1.Name = "DelightDesignerXmlEditorImage1";
#endif
                }
                return _delightDesignerXmlEditorImage1;
            }
        }

        private static Template _delightDesignerXmlEditorXmlEditLeftMargin;
        public static Template DelightDesignerXmlEditorXmlEditLeftMargin
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorXmlEditLeftMargin == null || _delightDesignerXmlEditorXmlEditLeftMargin.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorXmlEditLeftMargin == null)
#endif
                {
                    _delightDesignerXmlEditorXmlEditLeftMargin = new Template(XmlEditorTemplates.XmlEditorXmlEditLeftMargin);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorXmlEditLeftMargin.Name = "DelightDesignerXmlEditorXmlEditLeftMargin";
#endif
                }
                return _delightDesignerXmlEditorXmlEditLeftMargin;
            }
        }

        private static Template _delightDesignerXmlEditorLineNumbersLabel;
        public static Template DelightDesignerXmlEditorLineNumbersLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorLineNumbersLabel == null || _delightDesignerXmlEditorLineNumbersLabel.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorLineNumbersLabel == null)
#endif
                {
                    _delightDesignerXmlEditorLineNumbersLabel = new Template(XmlEditorTemplates.XmlEditorLineNumbersLabel);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorLineNumbersLabel.Name = "DelightDesignerXmlEditorLineNumbersLabel";
#endif
                }
                return _delightDesignerXmlEditorLineNumbersLabel;
            }
        }

        private static Template _delightDesignerXmlEditorLineNumbersRightBorder;
        public static Template DelightDesignerXmlEditorLineNumbersRightBorder
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorLineNumbersRightBorder == null || _delightDesignerXmlEditorLineNumbersRightBorder.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorLineNumbersRightBorder == null)
#endif
                {
                    _delightDesignerXmlEditorLineNumbersRightBorder = new Template(XmlEditorTemplates.XmlEditorLineNumbersRightBorder);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorLineNumbersRightBorder.Name = "DelightDesignerXmlEditorLineNumbersRightBorder";
#endif
                }
                return _delightDesignerXmlEditorLineNumbersRightBorder;
            }
        }

        private static Template _delightDesignerXmlEditorStatusBar;
        public static Template DelightDesignerXmlEditorStatusBar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerXmlEditorStatusBar == null || _delightDesignerXmlEditorStatusBar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerXmlEditorStatusBar == null)
#endif
                {
                    _delightDesignerXmlEditorStatusBar = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _delightDesignerXmlEditorStatusBar.Name = "DelightDesignerXmlEditorStatusBar";
#endif
                    Delight.Region.BackgroundColorProperty.SetDefault(_delightDesignerXmlEditorStatusBar, new UnityEngine.Color(0.8862745f, 0.8862745f, 0.8862745f, 1f));
                    Delight.Region.HeightProperty.SetDefault(_delightDesignerXmlEditorStatusBar, new ElementSize(20f, ElementSizeUnit.Pixels));
                    Delight.Region.AlignmentProperty.SetDefault(_delightDesignerXmlEditorStatusBar, Delight.ElementAlignment.Bottom);
                }
                return _delightDesignerXmlEditorStatusBar;
            }
        }

        private static Template _delightDesignerGroup1;
        public static Template DelightDesignerGroup1
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerGroup1 == null || _delightDesignerGroup1.CurrentVersion != Template.Version)
#else
                if (_delightDesignerGroup1 == null)
#endif
                {
                    _delightDesignerGroup1 = new Template(GroupTemplates.Group);
#if UNITY_EDITOR
                    _delightDesignerGroup1.Name = "DelightDesignerGroup1";
#endif
                    Delight.Group.OrientationProperty.SetDefault(_delightDesignerGroup1, Delight.ElementOrientation.Horizontal);
                    Delight.Group.SpacingProperty.SetDefault(_delightDesignerGroup1, new ElementSize(10f, ElementSizeUnit.Pixels));
                    Delight.Group.AlignmentProperty.SetDefault(_delightDesignerGroup1, Delight.ElementAlignment.Right);
                    Delight.Group.MarginProperty.SetDefault(_delightDesignerGroup1, new ElementMargin(new ElementSize(5f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(5f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                }
                return _delightDesignerGroup1;
            }
        }

        private static Template _delightDesignerAutoParseCheckBox;
        public static Template DelightDesignerAutoParseCheckBox
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerAutoParseCheckBox == null || _delightDesignerAutoParseCheckBox.CurrentVersion != Template.Version)
#else
                if (_delightDesignerAutoParseCheckBox == null)
#endif
                {
                    _delightDesignerAutoParseCheckBox = new Template(CheckBoxTemplates.CheckBox);
#if UNITY_EDITOR
                    _delightDesignerAutoParseCheckBox.Name = "DelightDesignerAutoParseCheckBox";
#endif
                    Delight.CheckBox.IsCheckedProperty.SetHasBinding(_delightDesignerAutoParseCheckBox);
                    Delight.CheckBox.CheckBoxGroupTemplateProperty.SetDefault(_delightDesignerAutoParseCheckBox, DelightDesignerAutoParseCheckBoxCheckBoxGroup);
                    Delight.CheckBox.CheckBoxImageViewTemplateProperty.SetDefault(_delightDesignerAutoParseCheckBox, DelightDesignerAutoParseCheckBoxCheckBoxImageView);
                    Delight.CheckBox.CheckBoxLabelTemplateProperty.SetDefault(_delightDesignerAutoParseCheckBox, DelightDesignerAutoParseCheckBoxCheckBoxLabel);
                }
                return _delightDesignerAutoParseCheckBox;
            }
        }

        private static Template _delightDesignerAutoParseCheckBoxCheckBoxGroup;
        public static Template DelightDesignerAutoParseCheckBoxCheckBoxGroup
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerAutoParseCheckBoxCheckBoxGroup == null || _delightDesignerAutoParseCheckBoxCheckBoxGroup.CurrentVersion != Template.Version)
#else
                if (_delightDesignerAutoParseCheckBoxCheckBoxGroup == null)
#endif
                {
                    _delightDesignerAutoParseCheckBoxCheckBoxGroup = new Template(CheckBoxTemplates.CheckBoxCheckBoxGroup);
#if UNITY_EDITOR
                    _delightDesignerAutoParseCheckBoxCheckBoxGroup.Name = "DelightDesignerAutoParseCheckBoxCheckBoxGroup";
#endif
                }
                return _delightDesignerAutoParseCheckBoxCheckBoxGroup;
            }
        }

        private static Template _delightDesignerAutoParseCheckBoxCheckBoxImageView;
        public static Template DelightDesignerAutoParseCheckBoxCheckBoxImageView
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerAutoParseCheckBoxCheckBoxImageView == null || _delightDesignerAutoParseCheckBoxCheckBoxImageView.CurrentVersion != Template.Version)
#else
                if (_delightDesignerAutoParseCheckBoxCheckBoxImageView == null)
#endif
                {
                    _delightDesignerAutoParseCheckBoxCheckBoxImageView = new Template(CheckBoxTemplates.CheckBoxCheckBoxImageView);
#if UNITY_EDITOR
                    _delightDesignerAutoParseCheckBoxCheckBoxImageView.Name = "DelightDesignerAutoParseCheckBoxCheckBoxImageView";
#endif
                    Delight.Image.WidthProperty.SetDefault(_delightDesignerAutoParseCheckBoxCheckBoxImageView, new ElementSize(15f, ElementSizeUnit.Pixels));
                    Delight.Image.HeightProperty.SetDefault(_delightDesignerAutoParseCheckBoxCheckBoxImageView, new ElementSize(15f, ElementSizeUnit.Pixels));
                }
                return _delightDesignerAutoParseCheckBoxCheckBoxImageView;
            }
        }

        private static Template _delightDesignerAutoParseCheckBoxCheckBoxLabel;
        public static Template DelightDesignerAutoParseCheckBoxCheckBoxLabel
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerAutoParseCheckBoxCheckBoxLabel == null || _delightDesignerAutoParseCheckBoxCheckBoxLabel.CurrentVersion != Template.Version)
#else
                if (_delightDesignerAutoParseCheckBoxCheckBoxLabel == null)
#endif
                {
                    _delightDesignerAutoParseCheckBoxCheckBoxLabel = new Template(CheckBoxTemplates.CheckBoxCheckBoxLabel);
#if UNITY_EDITOR
                    _delightDesignerAutoParseCheckBoxCheckBoxLabel.Name = "DelightDesignerAutoParseCheckBoxCheckBoxLabel";
#endif
                    Delight.Label.TextProperty.SetDefault(_delightDesignerAutoParseCheckBoxCheckBoxLabel, "Auto parse");
                    Delight.Label.FontSizeProperty.SetDefault(_delightDesignerAutoParseCheckBoxCheckBoxLabel, 12f);
                    Delight.Label.FontColorProperty.SetDefault(_delightDesignerAutoParseCheckBoxCheckBoxLabel, new UnityEngine.Color(0.2f, 0.2f, 0.2f, 1f));
                }
                return _delightDesignerAutoParseCheckBoxCheckBoxLabel;
            }
        }

        private static Template _delightDesignerButton1;
        public static Template DelightDesignerButton1
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerButton1 == null || _delightDesignerButton1.CurrentVersion != Template.Version)
#else
                if (_delightDesignerButton1 == null)
#endif
                {
                    _delightDesignerButton1 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _delightDesignerButton1.Name = "DelightDesignerButton1";
#endif
                    Delight.Button.HeightProperty.SetDefault(_delightDesignerButton1, new ElementSize(14f, ElementSizeUnit.Pixels));
                    Delight.Button.IsDisabledProperty.SetHasBinding(_delightDesignerButton1);
                    Delight.Button.LabelTemplateProperty.SetDefault(_delightDesignerButton1, DelightDesignerButton1Label);
                }
                return _delightDesignerButton1;
            }
        }

        private static Template _delightDesignerButton1Label;
        public static Template DelightDesignerButton1Label
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerButton1Label == null || _delightDesignerButton1Label.CurrentVersion != Template.Version)
#else
                if (_delightDesignerButton1Label == null)
#endif
                {
                    _delightDesignerButton1Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _delightDesignerButton1Label.Name = "DelightDesignerButton1Label";
#endif
                    Delight.Label.TextProperty.SetDefault(_delightDesignerButton1Label, "Parse");
                    Delight.Label.FontSizeProperty.SetDefault(_delightDesignerButton1Label, 12f);
                }
                return _delightDesignerButton1Label;
            }
        }

        private static Template _delightDesignerGridSplitter1;
        public static Template DelightDesignerGridSplitter1
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerGridSplitter1 == null || _delightDesignerGridSplitter1.CurrentVersion != Template.Version)
#else
                if (_delightDesignerGridSplitter1 == null)
#endif
                {
                    _delightDesignerGridSplitter1 = new Template(GridSplitterTemplates.GridSplitter);
#if UNITY_EDITOR
                    _delightDesignerGridSplitter1.Name = "DelightDesignerGridSplitter1";
#endif
                    Delight.GridSplitter.ThicknessProperty.SetDefault(_delightDesignerGridSplitter1, new ElementSize(20f, ElementSizeUnit.Pixels));
                    Delight.GridSplitter.OverrideProportionalSizeProperty.SetDefault(_delightDesignerGridSplitter1, false);
                    Delight.GridSplitter.SplitModeProperty.SetDefault(_delightDesignerGridSplitter1, Delight.SplitMode.Rows);
                }
                return _delightDesignerGridSplitter1;
            }
        }

        private static Template _delightDesignerGridSplitter2;
        public static Template DelightDesignerGridSplitter2
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerGridSplitter2 == null || _delightDesignerGridSplitter2.CurrentVersion != Template.Version)
#else
                if (_delightDesignerGridSplitter2 == null)
#endif
                {
                    _delightDesignerGridSplitter2 = new Template(GridSplitterTemplates.GridSplitter);
#if UNITY_EDITOR
                    _delightDesignerGridSplitter2.Name = "DelightDesignerGridSplitter2";
#endif
                    Delight.GridSplitter.ThicknessProperty.SetDefault(_delightDesignerGridSplitter2, new ElementSize(20f, ElementSizeUnit.Pixels));
                    Delight.GridSplitter.OverrideProportionalSizeProperty.SetDefault(_delightDesignerGridSplitter2, false);
                    Delight.GridSplitter.SplitModeProperty.SetDefault(_delightDesignerGridSplitter2, Delight.SplitMode.Columns);
                }
                return _delightDesignerGridSplitter2;
            }
        }

        private static Template _delightDesignerSaveChangesPopup;
        public static Template DelightDesignerSaveChangesPopup
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerSaveChangesPopup == null || _delightDesignerSaveChangesPopup.CurrentVersion != Template.Version)
#else
                if (_delightDesignerSaveChangesPopup == null)
#endif
                {
                    _delightDesignerSaveChangesPopup = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _delightDesignerSaveChangesPopup.Name = "DelightDesignerSaveChangesPopup";
#endif
                    Delight.Region.IsActiveProperty.SetDefault(_delightDesignerSaveChangesPopup, false);
                    Delight.Region.WidthProperty.SetDefault(_delightDesignerSaveChangesPopup, new ElementSize(450f, ElementSizeUnit.Pixels));
                    Delight.Region.HeightProperty.SetDefault(_delightDesignerSaveChangesPopup, new ElementSize(300f, ElementSizeUnit.Pixels));
                    Delight.Region.BackgroundColorProperty.SetDefault(_delightDesignerSaveChangesPopup, new UnityEngine.Color(0.8588235f, 0.8588235f, 0.8588235f, 1f));
                }
                return _delightDesignerSaveChangesPopup;
            }
        }

        private static Template _delightDesignerLabel2;
        public static Template DelightDesignerLabel2
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerLabel2 == null || _delightDesignerLabel2.CurrentVersion != Template.Version)
#else
                if (_delightDesignerLabel2 == null)
#endif
                {
                    _delightDesignerLabel2 = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _delightDesignerLabel2.Name = "DelightDesignerLabel2";
#endif
                    Delight.Label.TextProperty.SetDefault(_delightDesignerLabel2, "Do you want to save changes to the following items?");
                    Delight.Label.FontSizeProperty.SetDefault(_delightDesignerLabel2, 16f);
                    Delight.Label.FontProperty.SetDefault(_delightDesignerLabel2, Assets.TMP_FontAssets["Segoe UI SDF"]);
                    Delight.Label.WidthProperty.SetDefault(_delightDesignerLabel2, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.AlignmentProperty.SetDefault(_delightDesignerLabel2, Delight.ElementAlignment.TopLeft);
                    Delight.Label.MarginProperty.SetDefault(_delightDesignerLabel2, new ElementMargin(new ElementSize(10f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                }
                return _delightDesignerLabel2;
            }
        }

        private static Template _delightDesignerList2;
        public static Template DelightDesignerList2
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerList2 == null || _delightDesignerList2.CurrentVersion != Template.Version)
#else
                if (_delightDesignerList2 == null)
#endif
                {
                    _delightDesignerList2 = new Template(ListTemplates.List);
#if UNITY_EDITOR
                    _delightDesignerList2.Name = "DelightDesignerList2";
#endif
                    Delight.List.IsScrollableProperty.SetDefault(_delightDesignerList2, true);
                    Delight.List.AlignmentProperty.SetDefault(_delightDesignerList2, Delight.ElementAlignment.Top);
                    Delight.List.MarginProperty.SetDefault(_delightDesignerList2, new ElementMargin(new ElementSize(10f, ElementSizeUnit.Pixels), new ElementSize(40f, ElementSizeUnit.Pixels), new ElementSize(10f, ElementSizeUnit.Pixels), new ElementSize(55f, ElementSizeUnit.Pixels)));
                    Delight.List.BackgroundColorProperty.SetDefault(_delightDesignerList2, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.List.WidthProperty.SetDefault(_delightDesignerList2, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.List.HeightProperty.SetDefault(_delightDesignerList2, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.List.CanSelectProperty.SetDefault(_delightDesignerList2, false);
                    Delight.List.ItemsProperty.SetHasBinding(_delightDesignerList2);
                    Delight.List.ScrollableRegionTemplateProperty.SetDefault(_delightDesignerList2, DelightDesignerList2ScrollableRegion);
                }
                return _delightDesignerList2;
            }
        }

        private static Template _delightDesignerList2ScrollableRegion;
        public static Template DelightDesignerList2ScrollableRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerList2ScrollableRegion == null || _delightDesignerList2ScrollableRegion.CurrentVersion != Template.Version)
#else
                if (_delightDesignerList2ScrollableRegion == null)
#endif
                {
                    _delightDesignerList2ScrollableRegion = new Template(ListTemplates.ListScrollableRegion);
#if UNITY_EDITOR
                    _delightDesignerList2ScrollableRegion.Name = "DelightDesignerList2ScrollableRegion";
#endif
                    Delight.ScrollableRegion.HasInertiaProperty.SetDefault(_delightDesignerList2ScrollableRegion, false);
                    Delight.ScrollableRegion.ContentRegionTemplateProperty.SetDefault(_delightDesignerList2ScrollableRegion, DelightDesignerList2ScrollableRegionContentRegion);
                    Delight.ScrollableRegion.HorizontalScrollbarTemplateProperty.SetDefault(_delightDesignerList2ScrollableRegion, DelightDesignerList2ScrollableRegionHorizontalScrollbar);
                    Delight.ScrollableRegion.VerticalScrollbarTemplateProperty.SetDefault(_delightDesignerList2ScrollableRegion, DelightDesignerList2ScrollableRegionVerticalScrollbar);
                }
                return _delightDesignerList2ScrollableRegion;
            }
        }

        private static Template _delightDesignerList2ScrollableRegionContentRegion;
        public static Template DelightDesignerList2ScrollableRegionContentRegion
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerList2ScrollableRegionContentRegion == null || _delightDesignerList2ScrollableRegionContentRegion.CurrentVersion != Template.Version)
#else
                if (_delightDesignerList2ScrollableRegionContentRegion == null)
#endif
                {
                    _delightDesignerList2ScrollableRegionContentRegion = new Template(ListTemplates.ListScrollableRegionContentRegion);
#if UNITY_EDITOR
                    _delightDesignerList2ScrollableRegionContentRegion.Name = "DelightDesignerList2ScrollableRegionContentRegion";
#endif
                }
                return _delightDesignerList2ScrollableRegionContentRegion;
            }
        }

        private static Template _delightDesignerList2ScrollableRegionHorizontalScrollbar;
        public static Template DelightDesignerList2ScrollableRegionHorizontalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerList2ScrollableRegionHorizontalScrollbar == null || _delightDesignerList2ScrollableRegionHorizontalScrollbar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerList2ScrollableRegionHorizontalScrollbar == null)
#endif
                {
                    _delightDesignerList2ScrollableRegionHorizontalScrollbar = new Template(ListTemplates.ListScrollableRegionHorizontalScrollbar);
#if UNITY_EDITOR
                    _delightDesignerList2ScrollableRegionHorizontalScrollbar.Name = "DelightDesignerList2ScrollableRegionHorizontalScrollbar";
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_delightDesignerList2ScrollableRegionHorizontalScrollbar, DelightDesignerList2ScrollableRegionHorizontalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_delightDesignerList2ScrollableRegionHorizontalScrollbar, DelightDesignerList2ScrollableRegionHorizontalScrollbarHandle);
                }
                return _delightDesignerList2ScrollableRegionHorizontalScrollbar;
            }
        }

        private static Template _delightDesignerList2ScrollableRegionHorizontalScrollbarBar;
        public static Template DelightDesignerList2ScrollableRegionHorizontalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerList2ScrollableRegionHorizontalScrollbarBar == null || _delightDesignerList2ScrollableRegionHorizontalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerList2ScrollableRegionHorizontalScrollbarBar == null)
#endif
                {
                    _delightDesignerList2ScrollableRegionHorizontalScrollbarBar = new Template(ListTemplates.ListScrollableRegionHorizontalScrollbarBar);
#if UNITY_EDITOR
                    _delightDesignerList2ScrollableRegionHorizontalScrollbarBar.Name = "DelightDesignerList2ScrollableRegionHorizontalScrollbarBar";
#endif
                }
                return _delightDesignerList2ScrollableRegionHorizontalScrollbarBar;
            }
        }

        private static Template _delightDesignerList2ScrollableRegionHorizontalScrollbarHandle;
        public static Template DelightDesignerList2ScrollableRegionHorizontalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerList2ScrollableRegionHorizontalScrollbarHandle == null || _delightDesignerList2ScrollableRegionHorizontalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_delightDesignerList2ScrollableRegionHorizontalScrollbarHandle == null)
#endif
                {
                    _delightDesignerList2ScrollableRegionHorizontalScrollbarHandle = new Template(ListTemplates.ListScrollableRegionHorizontalScrollbarHandle);
#if UNITY_EDITOR
                    _delightDesignerList2ScrollableRegionHorizontalScrollbarHandle.Name = "DelightDesignerList2ScrollableRegionHorizontalScrollbarHandle";
#endif
                }
                return _delightDesignerList2ScrollableRegionHorizontalScrollbarHandle;
            }
        }

        private static Template _delightDesignerList2ScrollableRegionVerticalScrollbar;
        public static Template DelightDesignerList2ScrollableRegionVerticalScrollbar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerList2ScrollableRegionVerticalScrollbar == null || _delightDesignerList2ScrollableRegionVerticalScrollbar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerList2ScrollableRegionVerticalScrollbar == null)
#endif
                {
                    _delightDesignerList2ScrollableRegionVerticalScrollbar = new Template(ListTemplates.ListScrollableRegionVerticalScrollbar);
#if UNITY_EDITOR
                    _delightDesignerList2ScrollableRegionVerticalScrollbar.Name = "DelightDesignerList2ScrollableRegionVerticalScrollbar";
#endif
                    Delight.Scrollbar.BarTemplateProperty.SetDefault(_delightDesignerList2ScrollableRegionVerticalScrollbar, DelightDesignerList2ScrollableRegionVerticalScrollbarBar);
                    Delight.Scrollbar.HandleTemplateProperty.SetDefault(_delightDesignerList2ScrollableRegionVerticalScrollbar, DelightDesignerList2ScrollableRegionVerticalScrollbarHandle);
                }
                return _delightDesignerList2ScrollableRegionVerticalScrollbar;
            }
        }

        private static Template _delightDesignerList2ScrollableRegionVerticalScrollbarBar;
        public static Template DelightDesignerList2ScrollableRegionVerticalScrollbarBar
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerList2ScrollableRegionVerticalScrollbarBar == null || _delightDesignerList2ScrollableRegionVerticalScrollbarBar.CurrentVersion != Template.Version)
#else
                if (_delightDesignerList2ScrollableRegionVerticalScrollbarBar == null)
#endif
                {
                    _delightDesignerList2ScrollableRegionVerticalScrollbarBar = new Template(ListTemplates.ListScrollableRegionVerticalScrollbarBar);
#if UNITY_EDITOR
                    _delightDesignerList2ScrollableRegionVerticalScrollbarBar.Name = "DelightDesignerList2ScrollableRegionVerticalScrollbarBar";
#endif
                }
                return _delightDesignerList2ScrollableRegionVerticalScrollbarBar;
            }
        }

        private static Template _delightDesignerList2ScrollableRegionVerticalScrollbarHandle;
        public static Template DelightDesignerList2ScrollableRegionVerticalScrollbarHandle
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerList2ScrollableRegionVerticalScrollbarHandle == null || _delightDesignerList2ScrollableRegionVerticalScrollbarHandle.CurrentVersion != Template.Version)
#else
                if (_delightDesignerList2ScrollableRegionVerticalScrollbarHandle == null)
#endif
                {
                    _delightDesignerList2ScrollableRegionVerticalScrollbarHandle = new Template(ListTemplates.ListScrollableRegionVerticalScrollbarHandle);
#if UNITY_EDITOR
                    _delightDesignerList2ScrollableRegionVerticalScrollbarHandle.Name = "DelightDesignerList2ScrollableRegionVerticalScrollbarHandle";
#endif
                }
                return _delightDesignerList2ScrollableRegionVerticalScrollbarHandle;
            }
        }

        private static Template _delightDesignerListItem2;
        public static Template DelightDesignerListItem2
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerListItem2 == null || _delightDesignerListItem2.CurrentVersion != Template.Version)
#else
                if (_delightDesignerListItem2 == null)
#endif
                {
                    _delightDesignerListItem2 = new Template(ListItemTemplates.ListItem);
#if UNITY_EDITOR
                    _delightDesignerListItem2.Name = "DelightDesignerListItem2";
#endif
                }
                return _delightDesignerListItem2;
            }
        }

        private static Template _delightDesignerLabel3;
        public static Template DelightDesignerLabel3
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerLabel3 == null || _delightDesignerLabel3.CurrentVersion != Template.Version)
#else
                if (_delightDesignerLabel3 == null)
#endif
                {
                    _delightDesignerLabel3 = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _delightDesignerLabel3.Name = "DelightDesignerLabel3";
#endif
                    Delight.Label.FontSizeProperty.SetDefault(_delightDesignerLabel3, 16f);
                    Delight.Label.FontProperty.SetDefault(_delightDesignerLabel3, Assets.TMP_FontAssets["Segoe UI SDF"]);
                    Delight.Label.HeightProperty.SetDefault(_delightDesignerLabel3, new ElementSize(24f, ElementSizeUnit.Pixels));
                    Delight.Label.FontColorProperty.SetDefault(_delightDesignerLabel3, new UnityEngine.Color(0f, 0f, 0f, 1f));
                    Delight.Label.WidthProperty.SetDefault(_delightDesignerLabel3, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Label.MarginProperty.SetDefault(_delightDesignerLabel3, new ElementMargin(new ElementSize(16f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                    Delight.Label.EnableWordWrappingProperty.SetDefault(_delightDesignerLabel3, false);
                    Delight.Label.OverflowModeProperty.SetDefault(_delightDesignerLabel3, TMPro.TextOverflowModes.Truncate);
                    Delight.Label.ExtraPaddingProperty.SetDefault(_delightDesignerLabel3, true);
                    Delight.Label.TextProperty.SetHasBinding(_delightDesignerLabel3);
                }
                return _delightDesignerLabel3;
            }
        }

        private static Template _delightDesignerGroup2;
        public static Template DelightDesignerGroup2
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerGroup2 == null || _delightDesignerGroup2.CurrentVersion != Template.Version)
#else
                if (_delightDesignerGroup2 == null)
#endif
                {
                    _delightDesignerGroup2 = new Template(GroupTemplates.Group);
#if UNITY_EDITOR
                    _delightDesignerGroup2.Name = "DelightDesignerGroup2";
#endif
                    Delight.Group.OrientationProperty.SetDefault(_delightDesignerGroup2, Delight.ElementOrientation.Horizontal);
                    Delight.Group.SpacingProperty.SetDefault(_delightDesignerGroup2, new ElementSize(8f, ElementSizeUnit.Pixels));
                    Delight.Group.AlignmentProperty.SetDefault(_delightDesignerGroup2, Delight.ElementAlignment.BottomRight);
                    Delight.Group.OffsetProperty.SetDefault(_delightDesignerGroup2, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(10f, ElementSizeUnit.Pixels), new ElementSize(10f, ElementSizeUnit.Pixels)));
                }
                return _delightDesignerGroup2;
            }
        }

        private static Template _delightDesignerButton2;
        public static Template DelightDesignerButton2
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerButton2 == null || _delightDesignerButton2.CurrentVersion != Template.Version)
#else
                if (_delightDesignerButton2 == null)
#endif
                {
                    _delightDesignerButton2 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _delightDesignerButton2.Name = "DelightDesignerButton2";
#endif
                    Delight.Button.WidthProperty.SetDefault(_delightDesignerButton2, new ElementSize(90f, ElementSizeUnit.Pixels));
                    Delight.Button.HeightProperty.SetDefault(_delightDesignerButton2, new ElementSize(30f, ElementSizeUnit.Pixels));
                    Delight.Button.LabelTemplateProperty.SetDefault(_delightDesignerButton2, DelightDesignerButton2Label);
                }
                return _delightDesignerButton2;
            }
        }

        private static Template _delightDesignerButton2Label;
        public static Template DelightDesignerButton2Label
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerButton2Label == null || _delightDesignerButton2Label.CurrentVersion != Template.Version)
#else
                if (_delightDesignerButton2Label == null)
#endif
                {
                    _delightDesignerButton2Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _delightDesignerButton2Label.Name = "DelightDesignerButton2Label";
#endif
                    Delight.Label.TextProperty.SetDefault(_delightDesignerButton2Label, "Yes");
                    Delight.Label.FontSizeProperty.SetDefault(_delightDesignerButton2Label, 16f);
                }
                return _delightDesignerButton2Label;
            }
        }

        private static Template _delightDesignerButton3;
        public static Template DelightDesignerButton3
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerButton3 == null || _delightDesignerButton3.CurrentVersion != Template.Version)
#else
                if (_delightDesignerButton3 == null)
#endif
                {
                    _delightDesignerButton3 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _delightDesignerButton3.Name = "DelightDesignerButton3";
#endif
                    Delight.Button.WidthProperty.SetDefault(_delightDesignerButton3, new ElementSize(90f, ElementSizeUnit.Pixels));
                    Delight.Button.HeightProperty.SetDefault(_delightDesignerButton3, new ElementSize(30f, ElementSizeUnit.Pixels));
                    Delight.Button.LabelTemplateProperty.SetDefault(_delightDesignerButton3, DelightDesignerButton3Label);
                }
                return _delightDesignerButton3;
            }
        }

        private static Template _delightDesignerButton3Label;
        public static Template DelightDesignerButton3Label
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerButton3Label == null || _delightDesignerButton3Label.CurrentVersion != Template.Version)
#else
                if (_delightDesignerButton3Label == null)
#endif
                {
                    _delightDesignerButton3Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _delightDesignerButton3Label.Name = "DelightDesignerButton3Label";
#endif
                    Delight.Label.TextProperty.SetDefault(_delightDesignerButton3Label, "No");
                    Delight.Label.FontSizeProperty.SetDefault(_delightDesignerButton3Label, 16f);
                }
                return _delightDesignerButton3Label;
            }
        }

        private static Template _delightDesignerButton4;
        public static Template DelightDesignerButton4
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerButton4 == null || _delightDesignerButton4.CurrentVersion != Template.Version)
#else
                if (_delightDesignerButton4 == null)
#endif
                {
                    _delightDesignerButton4 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _delightDesignerButton4.Name = "DelightDesignerButton4";
#endif
                    Delight.Button.WidthProperty.SetDefault(_delightDesignerButton4, new ElementSize(90f, ElementSizeUnit.Pixels));
                    Delight.Button.HeightProperty.SetDefault(_delightDesignerButton4, new ElementSize(30f, ElementSizeUnit.Pixels));
                    Delight.Button.LabelTemplateProperty.SetDefault(_delightDesignerButton4, DelightDesignerButton4Label);
                }
                return _delightDesignerButton4;
            }
        }

        private static Template _delightDesignerButton4Label;
        public static Template DelightDesignerButton4Label
        {
            get
            {
#if UNITY_EDITOR
                if (_delightDesignerButton4Label == null || _delightDesignerButton4Label.CurrentVersion != Template.Version)
#else
                if (_delightDesignerButton4Label == null)
#endif
                {
                    _delightDesignerButton4Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _delightDesignerButton4Label.Name = "DelightDesignerButton4Label";
#endif
                    Delight.Label.TextProperty.SetDefault(_delightDesignerButton4Label, "Cancel");
                    Delight.Label.FontSizeProperty.SetDefault(_delightDesignerButton4Label, 16f);
                }
                return _delightDesignerButton4Label;
            }
        }

        #endregion
    }

    #endregion
}

#endif
