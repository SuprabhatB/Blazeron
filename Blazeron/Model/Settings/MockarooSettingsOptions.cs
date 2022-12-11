namespace Blazeron.Model.Settings
{
    using Blazeron.Framework.Configuration;

    public abstract class MockarooSettingsOptions : ConfigurationOptions
    {
        public const string SECTION = "Mockaroo";

        public string Key { get; set; }
    }
}
