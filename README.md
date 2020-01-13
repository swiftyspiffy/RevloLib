Revlo is no longer running. This project is archived.
-------------------------
# RevloLib

## About
RevloLib is a simple C# library that implements all of the endpoints supported by the Revlo API.


## Implementing
Below is a basic implementation of RevloLib.
#### TwitchClient
```csharp
RevloLib.Core.APIKey = "my-revlo-api-key";

// GetRewards
var response = await RevloLib.Core.Rewards.GetRewards();

// GetRedemptions
var response = await RevloLib.Core.Redemptions.GetRedemptions();

// GetRedemption by Id
var response = await RevloLib.Core.Redemptions.GetRedemption(int redemption_id);

// PatchRedemption
var response = await RevloLib.Core.Redemptions.PatchRedemption(int redemption_id, bool completed);

// GetFanPoints
var response = await RevloLib.Core.Fans.GetFanPoints(string username);

// ModifyFanPoints
var response = await RevloLib.Core.Fans.ModifyFanPoints(string username, int points);
```

## Installation

### [NuGet](https://www.nuget.org/packages/RevloLib/)

To install this library via NuGet via NuGet console, use:
```
Install-Package RevloLib
```
and via Package Manager, simply search:
```
RevloLib
```
You are also more than welcome to clone/fork this repo and build the library yourself!

## Dependencies

* Newtonsoft.Json 10.0.1+ ([nuget link](https://www.nuget.org/packages/Newtonsoft.Json/10.0.1))

## License

This project is available under the MIT license. See the LICENSE file for more info.
