namespace Xamarin.Forms
{
    /// <summary>
    /// V 1.0.0 - 2020-1-3 17:08:37
    /// 首次创建
    /// </summary>
    public static class BindableObjectExtensions
    {
        public static T GetValue<T>(this BindableObject bindableObject, BindableProperty property)
        {
            return (T)bindableObject.GetValue(property);
        }
    }
}