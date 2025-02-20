# OneSignalApi - the C# library for the OneSignal

A powerful way to send personalized messages at scale and build effective customer engagement strategies. Learn more at onesignal.com

- API version: 1.4.0
- SDK version: 2.2.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://onesignal.com](https://onesignal.com)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;
```
<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {
            // Configure configuration with user_key Bearer token for authorization to access endpoints
            // that require the OneSignal User Auth Key.
            var userConfig = new Configuration();
            userConfig.BasePath = "https://api.onesignal.com";
            userConfig.AccessToken = "USER_AUTH_KEY";
            
            var userInstance = new DefaultApi(userConfig);

            try
            {
                // Create a new app
                var app = new App(name: "Sample App");
                var result = userInstance.CreateApp(app);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateApp: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }


            // Configure configuration with app_key Bearer token for authorization to access endpoints
            // that require the OneSignal App REST API Key.
            var appConfig = new Configuration();
            appConfig.BasePath = "https://api.onesignal.com";
            appConfig.AccessToken = "REST_API_KEY";
            
            var appInstance = new DefaultApi(appConfig);

            var appId = "appId_example";  // string | 
            var notificationId = "notificationId_example";  // string | 
            try
            {
                // Stop a scheduled or currently outgoing notification
                var result = appInstance.CancelNotification(appId, notificationId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.CancelNotification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.onesignal.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DefaultApi* | [**BeginLiveActivity**](docs/DefaultApi.md#beginliveactivity) | **POST** /apps/{app_id}/live_activities/{activity_id}/token | Start Live Activity
*DefaultApi* | [**CancelNotification**](docs/DefaultApi.md#cancelnotification) | **DELETE** /notifications/{notification_id} | Stop a scheduled or currently outgoing notification
*DefaultApi* | [**CreateApp**](docs/DefaultApi.md#createapp) | **POST** /apps | Create an app
*DefaultApi* | [**CreateNotification**](docs/DefaultApi.md#createnotification) | **POST** /notifications | Create notification
*DefaultApi* | [**CreatePlayer**](docs/DefaultApi.md#createplayer) | **POST** /players | Add a device
*DefaultApi* | [**CreateSegments**](docs/DefaultApi.md#createsegments) | **POST** /apps/{app_id}/segments | Create Segments
*DefaultApi* | [**CreateSubscription**](docs/DefaultApi.md#createsubscription) | **POST** /apps/{app_id}/users/by/{alias_label}/{alias_id}/subscriptions | 
*DefaultApi* | [**CreateUser**](docs/DefaultApi.md#createuser) | **POST** /apps/{app_id}/users | 
*DefaultApi* | [**DeleteAlias**](docs/DefaultApi.md#deletealias) | **DELETE** /apps/{app_id}/users/by/{alias_label}/{alias_id}/identity/{alias_label_to_delete} | 
*DefaultApi* | [**DeletePlayer**](docs/DefaultApi.md#deleteplayer) | **DELETE** /players/{player_id} | Delete a user record
*DefaultApi* | [**DeleteSegments**](docs/DefaultApi.md#deletesegments) | **DELETE** /apps/{app_id}/segments/{segment_id} | Delete Segments
*DefaultApi* | [**DeleteSubscription**](docs/DefaultApi.md#deletesubscription) | **DELETE** /apps/{app_id}/subscriptions/{subscription_id} | 
*DefaultApi* | [**DeleteUser**](docs/DefaultApi.md#deleteuser) | **DELETE** /apps/{app_id}/users/by/{alias_label}/{alias_id} | 
*DefaultApi* | [**EndLiveActivity**](docs/DefaultApi.md#endliveactivity) | **DELETE** /apps/{app_id}/live_activities/{activity_id}/token/{subscription_id} | Stop Live Activity
*DefaultApi* | [**ExportEvents**](docs/DefaultApi.md#exportevents) | **POST** /notifications/{notification_id}/export_events?app_id&#x3D;{app_id} | Export CSV of Events
*DefaultApi* | [**ExportPlayers**](docs/DefaultApi.md#exportplayers) | **POST** /players/csv_export?app_id&#x3D;{app_id} | Export CSV of Players
*DefaultApi* | [**FetchAliases**](docs/DefaultApi.md#fetchaliases) | **GET** /apps/{app_id}/subscriptions/{subscription_id}/user/identity | 
*DefaultApi* | [**FetchUser**](docs/DefaultApi.md#fetchuser) | **GET** /apps/{app_id}/users/by/{alias_label}/{alias_id} | 
*DefaultApi* | [**FetchUserIdentity**](docs/DefaultApi.md#fetchuseridentity) | **GET** /apps/{app_id}/users/by/{alias_label}/{alias_id}/identity | 
*DefaultApi* | [**GetApp**](docs/DefaultApi.md#getapp) | **GET** /apps/{app_id} | View an app
*DefaultApi* | [**GetApps**](docs/DefaultApi.md#getapps) | **GET** /apps | View apps
*DefaultApi* | [**GetEligibleIams**](docs/DefaultApi.md#geteligibleiams) | **GET** /apps/{app_id}/subscriptions/{subscription_id}/iams | 
*DefaultApi* | [**GetNotification**](docs/DefaultApi.md#getnotification) | **GET** /notifications/{notification_id} | View notification
*DefaultApi* | [**GetNotificationHistory**](docs/DefaultApi.md#getnotificationhistory) | **POST** /notifications/{notification_id}/history | Notification History
*DefaultApi* | [**GetNotifications**](docs/DefaultApi.md#getnotifications) | **GET** /notifications | View notifications
*DefaultApi* | [**GetOutcomes**](docs/DefaultApi.md#getoutcomes) | **GET** /apps/{app_id}/outcomes | View Outcomes
*DefaultApi* | [**GetPlayer**](docs/DefaultApi.md#getplayer) | **GET** /players/{player_id} | View device
*DefaultApi* | [**GetPlayers**](docs/DefaultApi.md#getplayers) | **GET** /players | View devices
*DefaultApi* | [**IdentifyUserByAlias**](docs/DefaultApi.md#identifyuserbyalias) | **PATCH** /apps/{app_id}/users/by/{alias_label}/{alias_id}/identity | 
*DefaultApi* | [**IdentifyUserBySubscriptionId**](docs/DefaultApi.md#identifyuserbysubscriptionid) | **PATCH** /apps/{app_id}/subscriptions/{subscription_id}/user/identity | 
*DefaultApi* | [**TransferSubscription**](docs/DefaultApi.md#transfersubscription) | **PATCH** /apps/{app_id}/subscriptions/{subscription_id}/owner | 
*DefaultApi* | [**UpdateApp**](docs/DefaultApi.md#updateapp) | **PUT** /apps/{app_id} | Update an app
*DefaultApi* | [**UpdateLiveActivity**](docs/DefaultApi.md#updateliveactivity) | **POST** /apps/{app_id}/live_activities/{activity_id}/notifications | Update a Live Activity via Push
*DefaultApi* | [**UpdatePlayer**](docs/DefaultApi.md#updateplayer) | **PUT** /players/{player_id} | Edit device
*DefaultApi* | [**UpdatePlayerTags**](docs/DefaultApi.md#updateplayertags) | **PUT** /apps/{app_id}/users/{external_user_id} | Edit tags with external user id
*DefaultApi* | [**UpdateSubscription**](docs/DefaultApi.md#updatesubscription) | **PATCH** /apps/{app_id}/subscriptions/{subscription_id} | 
*DefaultApi* | [**UpdateUser**](docs/DefaultApi.md#updateuser) | **PATCH** /apps/{app_id}/users/by/{alias_label}/{alias_id} | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.App](docs/App.md)
 - [Model.BasicNotification](docs/BasicNotification.md)
 - [Model.BasicNotificationAllOf](docs/BasicNotificationAllOf.md)
 - [Model.BasicNotificationAllOfAndroidBackgroundLayout](docs/BasicNotificationAllOfAndroidBackgroundLayout.md)
 - [Model.BeginLiveActivityRequest](docs/BeginLiveActivityRequest.md)
 - [Model.Button](docs/Button.md)
 - [Model.CancelNotificationSuccessResponse](docs/CancelNotificationSuccessResponse.md)
 - [Model.CreateNotificationSuccessResponse](docs/CreateNotificationSuccessResponse.md)
 - [Model.CreatePlayerSuccessResponse](docs/CreatePlayerSuccessResponse.md)
 - [Model.CreateSegmentConflictResponse](docs/CreateSegmentConflictResponse.md)
 - [Model.CreateSegmentSuccessResponse](docs/CreateSegmentSuccessResponse.md)
 - [Model.CreateSubscriptionRequestBody](docs/CreateSubscriptionRequestBody.md)
 - [Model.CreateUserConflictResponse](docs/CreateUserConflictResponse.md)
 - [Model.CreateUserConflictResponseErrorsInner](docs/CreateUserConflictResponseErrorsInner.md)
 - [Model.CreateUserConflictResponseErrorsItemsMeta](docs/CreateUserConflictResponseErrorsItemsMeta.md)
 - [Model.DeletePlayerNotFoundResponse](docs/DeletePlayerNotFoundResponse.md)
 - [Model.DeletePlayerSuccessResponse](docs/DeletePlayerSuccessResponse.md)
 - [Model.DeleteSegmentNotFoundResponse](docs/DeleteSegmentNotFoundResponse.md)
 - [Model.DeleteSegmentSuccessResponse](docs/DeleteSegmentSuccessResponse.md)
 - [Model.DeliveryData](docs/DeliveryData.md)
 - [Model.ExportEventsSuccessResponse](docs/ExportEventsSuccessResponse.md)
 - [Model.ExportPlayersRequestBody](docs/ExportPlayersRequestBody.md)
 - [Model.ExportPlayersSuccessResponse](docs/ExportPlayersSuccessResponse.md)
 - [Model.Filter](docs/Filter.md)
 - [Model.FilterExpressions](docs/FilterExpressions.md)
 - [Model.GenericError](docs/GenericError.md)
 - [Model.GenericErrorErrorsInner](docs/GenericErrorErrorsInner.md)
 - [Model.GetNotificationRequestBody](docs/GetNotificationRequestBody.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InlineResponse2003](docs/InlineResponse2003.md)
 - [Model.InlineResponse201](docs/InlineResponse201.md)
 - [Model.InlineResponse202](docs/InlineResponse202.md)
 - [Model.InvalidIdentifierError](docs/InvalidIdentifierError.md)
 - [Model.Notification](docs/Notification.md)
 - [Model.Notification200Errors](docs/Notification200Errors.md)
 - [Model.NotificationAllOf](docs/NotificationAllOf.md)
 - [Model.NotificationHistorySuccessResponse](docs/NotificationHistorySuccessResponse.md)
 - [Model.NotificationSlice](docs/NotificationSlice.md)
 - [Model.NotificationTarget](docs/NotificationTarget.md)
 - [Model.NotificationWithMeta](docs/NotificationWithMeta.md)
 - [Model.NotificationWithMetaAllOf](docs/NotificationWithMetaAllOf.md)
 - [Model.Operator](docs/Operator.md)
 - [Model.OutcomeData](docs/OutcomeData.md)
 - [Model.OutcomesData](docs/OutcomesData.md)
 - [Model.PlatformDeliveryData](docs/PlatformDeliveryData.md)
 - [Model.PlatformDeliveryDataEmailAllOf](docs/PlatformDeliveryDataEmailAllOf.md)
 - [Model.PlatformDeliveryDataSmsAllOf](docs/PlatformDeliveryDataSmsAllOf.md)
 - [Model.Player](docs/Player.md)
 - [Model.PlayerNotificationTarget](docs/PlayerNotificationTarget.md)
 - [Model.PlayerNotificationTargetIncludeAliases](docs/PlayerNotificationTargetIncludeAliases.md)
 - [Model.PlayerSlice](docs/PlayerSlice.md)
 - [Model.PropertiesDeltas](docs/PropertiesDeltas.md)
 - [Model.PropertiesObject](docs/PropertiesObject.md)
 - [Model.Purchase](docs/Purchase.md)
 - [Model.RateLimiterError](docs/RateLimiterError.md)
 - [Model.Segment](docs/Segment.md)
 - [Model.SegmentNotificationTarget](docs/SegmentNotificationTarget.md)
 - [Model.StringMap](docs/StringMap.md)
 - [Model.SubscriptionObject](docs/SubscriptionObject.md)
 - [Model.TransferSubscriptionRequestBody](docs/TransferSubscriptionRequestBody.md)
 - [Model.UpdateLiveActivityRequest](docs/UpdateLiveActivityRequest.md)
 - [Model.UpdateLiveActivitySuccessResponse](docs/UpdateLiveActivitySuccessResponse.md)
 - [Model.UpdatePlayerSuccessResponse](docs/UpdatePlayerSuccessResponse.md)
 - [Model.UpdatePlayerTagsRequestBody](docs/UpdatePlayerTagsRequestBody.md)
 - [Model.UpdatePlayerTagsSuccessResponse](docs/UpdatePlayerTagsSuccessResponse.md)
 - [Model.UpdateSubscriptionRequestBody](docs/UpdateSubscriptionRequestBody.md)
 - [Model.UpdateUserRequest](docs/UpdateUserRequest.md)
 - [Model.User](docs/User.md)
 - [Model.UserIdentityRequestBody](docs/UserIdentityRequestBody.md)
 - [Model.UserIdentityResponse](docs/UserIdentityResponse.md)
 - [Model.UserSubscriptionOptions](docs/UserSubscriptionOptions.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="app_key"></a>
### app_key

- **Type**: Bearer Authentication

<a name="user_key"></a>
### user_key

- **Type**: Bearer Authentication

