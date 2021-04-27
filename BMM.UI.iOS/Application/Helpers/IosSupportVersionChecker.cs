﻿using BMM.Core.Helpers;
using BMM.Core.Implementations.Device;
using BMM.Core.Implementations.FeatureToggles;
using BMM.Core.Implementations.FirebaseRemoteConfig;

namespace BMM.UI.iOS.Helpers
{
    public class IosSupportVersionChecker : IDeviceSupportVersionChecker
    {
        private readonly IDeviceInfo _deviceInfo;
        private readonly IFirebaseRemoteConfig _remoteConfig;
        private readonly SemanticVersionParser _semanticVersionParser;
        private readonly SemanticVersionComparer _semanticVersionComparer;

        private readonly SemanticVersion _currentDeviceVersion;
        private readonly SemanticVersion _minimumRequiredVersion;
        private readonly SemanticVersion _versionToBeUnsupported;

        public IosSupportVersionChecker(
            IDeviceInfo deviceInfo,
            IFirebaseRemoteConfig remoteConfig,
            SemanticVersionParser semanticVersionParser,
            SemanticVersionComparer semanticVersionComparer)
        {
            _deviceInfo = deviceInfo;
            _remoteConfig = remoteConfig;
            _semanticVersionParser = semanticVersionParser;
            _semanticVersionComparer = semanticVersionComparer;

            _currentDeviceVersion = _semanticVersionParser.ParseStringToSemanticVersionObject(_deviceInfo.VersionString);
            _minimumRequiredVersion = _remoteConfig.MinimumRequiredIosVersion;
            _versionToBeUnsupported = _remoteConfig.IosVersionPlannedToBeUnsupported;
        }

        public bool IsCurrentDeviceVersionSupported()
        {
            return _semanticVersionComparer.SatisfiesMinVersion(_currentDeviceVersion, _minimumRequiredVersion);
        }

        public bool IsCurrentDeviceVersionPlannedToBeUnsupported()
        {
            return _semanticVersionComparer.LessThanOrEqual(_currentDeviceVersion, _versionToBeUnsupported);
        }
    }
}
