﻿namespace Orchard.Azure {

    public class Constants {
        public const string ShellSettingsStorageConnectionStringSettingName = "Orchard.Azure.Settings.StorageConnectionString";
        public const string ShellSettingsContainerName = "sites"; // Container names must be lower case.
        public const string ShellSettingsFileName = "Settings.txt";

        public const string MediaStorageFeatureName = "Orchard.Azure";
        public const string MediaStorageStorageConnectionStringSettingName = "Orchard.Azure.Media.StorageConnectionString";
        public const string MediaStorageContainerName = "media"; // Container names must be lower case.

        public const string OutputCacheFeatureName = "Orchard.Azure.OutputCache";
        public const string OutputCacheSettingNamePrefix = "Orchard.Azure.OutputCache.";
        public const string DatabaseCacheFeatureName = "Orchard.Azure.DatabaseCache";
        public const string DatabaseCacheSettingNamePrefix = "Orchard.Azure.DatabaseCache.";

        public const string CacheHostIdentifierSettingName = "HostIdentifier";
        public const string CacheCacheNameSettingName = "CacheName";
        public const string CacheAuthorizationTokenSettingName = "AuthorizationToken";
    }
}