namespace CodeExample
{
    using System.Windows;
    public static class ModernWindowBehavior
    {
        public static readonly DependencyProperty FrameTopContentProperty = DependencyProperty.RegisterAttached(
            "FrameTopContent",
            typeof(object),
            typeof(ModernWindowBehavior),
            new PropertyMetadata(default(object)));

        public static readonly DependencyProperty FrameBottomContentProperty = DependencyProperty.RegisterAttached(
            "FrameBottomContent",
            typeof(object),
            typeof(ModernWindowBehavior),
            new PropertyMetadata(default(object)));

        public static readonly DependencyProperty ToolsContentProperty = DependencyProperty.RegisterAttached(
            "ToolsContent",
            typeof(object),
            typeof(ModernWindowBehavior),
            new PropertyMetadata(default(object)));

        public static void SetFrameTopContent(DependencyObject element, object value)
        {
            element.SetValue(FrameTopContentProperty, value);
        }

        public static object GetFrameTopContent(DependencyObject element)
        {
            return (object)element.GetValue(FrameTopContentProperty);
        }

        public static void SetFrameBottomContent(DependencyObject element, object value)
        {
            element.SetValue(FrameBottomContentProperty, value);
        }

        public static object GetFrameBottomContent(DependencyObject element)
        {
            return (object)element.GetValue(FrameBottomContentProperty);
        }

        public static void SetToolsContent(DependencyObject element, object value)
        {
            element.SetValue(ToolsContentProperty, value);
        }

        public static object GetToolsContent(DependencyObject element)
        {
            return (object)element.GetValue(ToolsContentProperty);
        }
    }
}
