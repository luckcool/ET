namespace ET.Client
{
    public static class TextHelper
    {
        public static string GetText(Entity entity, string sid, string defaultValue = default)
        {
            return entity.Root().GetComponent<LocalizeComponent>().GetText(sid, defaultValue);
        }
        
        public static string GetText(Entity entity, int id, string defaultValue = default)
        {
            return entity.Root().GetComponent<LocalizeComponent>().GetText(id, defaultValue);
        }
    }
}