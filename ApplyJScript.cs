public void ApplyJScriptFix()
{
    var xmlSerializerType = typeof(XmlSerializer);
    const BindingFlags bindingAttr = BindingFlags.Default | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static;

    var method = xmlSerializerType.GetMethod("set_Mode", bindingAttr);
    method?.Invoke(null, new object[] { 1 });
}
