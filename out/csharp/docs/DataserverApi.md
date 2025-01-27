# Org.OpenAPITools.Api.DataserverApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DataserverAirep**](DataserverApi.md#dataserverairep) | **GET** /api/data/dataserver?requestType&#x3D;retrieve&amp;dataSource&#x3D;aircraftreports | Dataserver for AIREPs and PIREPs |
| [**DataserverGairmet**](DataserverApi.md#dataservergairmet) | **GET** /api/data/dataserver?requestType&#x3D;retrieve&amp;dataSource&#x3D;gairmets | Dataserver for G-AIRMETs |
| [**DataserverMetars**](DataserverApi.md#dataservermetars) | **GET** /api/data/dataserver?requestType&#x3D;retrieve&amp;dataSource&#x3D;metars | Dataserver for METARs |
| [**DataserverSigmet**](DataserverApi.md#dataserversigmet) | **GET** /api/data/dataserver?requestType&#x3D;retrieve&amp;dataSource&#x3D;airsigmets | Dataserver for AIRMETs and SIGMETs |
| [**DataserverTafs**](DataserverApi.md#dataservertafs) | **GET** /api/data/dataserver?requestType&#x3D;retrieve&amp;dataSource&#x3D;tafs | Dataserver for TAFs |

<a id="dataserverairep"></a>
# **DataserverAirep**
> void DataserverAirep (string? startTime = null, string? endTime = null, decimal? hoursBeforeNow = null, string? format = null, string? boundingBox = null, string? radialDistance = null)

Dataserver for AIREPs and PIREPs

Return aircraft data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataserverAirepExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataserverApi(config);
            var startTime = ;  // string? | Start time  * `yyyymmdd_hhmm`  * `yyyy-mm-ddThh:mm:ssZ`  (optional) 
            var endTime = ;  // string? | End time  * `yyyymmdd_hhmm`  * `yyyy-mm-ddThh:mm:ssZ`  (optional) 
            var hoursBeforeNow = 8.14D;  // decimal? | Number of hours before now to search (optional) 
            var format = "xml";  // string? | Output format (optional)  (default to xml)
            var boundingBox = ;  // string? | Geographic bounding box (lat0, lon0, lat1, lon1) (optional) 
            var radialDistance = ;  // string? | Circular bounds defined by latitude, longitude and radial distance in statute miles\" (optional) 

            try
            {
                // Dataserver for AIREPs and PIREPs
                apiInstance.DataserverAirep(startTime, endTime, hoursBeforeNow, format, boundingBox, radialDistance);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataserverApi.DataserverAirep: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataserverAirepWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dataserver for AIREPs and PIREPs
    apiInstance.DataserverAirepWithHttpInfo(startTime, endTime, hoursBeforeNow, format, boundingBox, radialDistance);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataserverApi.DataserverAirepWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startTime** | **string?** | Start time  * &#x60;yyyymmdd_hhmm&#x60;  * &#x60;yyyy-mm-ddThh:mm:ssZ&#x60;  | [optional]  |
| **endTime** | **string?** | End time  * &#x60;yyyymmdd_hhmm&#x60;  * &#x60;yyyy-mm-ddThh:mm:ssZ&#x60;  | [optional]  |
| **hoursBeforeNow** | **decimal?** | Number of hours before now to search | [optional]  |
| **format** | **string?** | Output format | [optional] [default to xml] |
| **boundingBox** | **string?** | Geographic bounding box (lat0, lon0, lat1, lon1) | [optional]  |
| **radialDistance** | **string?** | Circular bounds defined by latitude, longitude and radial distance in statute miles\&quot; | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="dataservergairmet"></a>
# **DataserverGairmet**
> void DataserverGairmet (string? startTime = null, string? endTime = null, decimal? hoursBeforeNow = null, string? format = null, string? boundingBox = null)

Dataserver for G-AIRMETs

Return G-AIRMETs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataserverGairmetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataserverApi(config);
            var startTime = ;  // string? | Start time  * `yyyymmdd_hhmm`  * `yyyy-mm-ddThh:mm:ssZ`  (optional) 
            var endTime = ;  // string? | End time  * `yyyymmdd_hhmm`  * `yyyy-mm-ddThh:mm:ssZ`  (optional) 
            var hoursBeforeNow = 8.14D;  // decimal? | Number of hours before now to search (optional) 
            var format = "xml";  // string? | Output format (optional)  (default to xml)
            var boundingBox = ;  // string? | Geographic bounding box (lat0, lon0, lat1, lon1) (optional) 

            try
            {
                // Dataserver for G-AIRMETs
                apiInstance.DataserverGairmet(startTime, endTime, hoursBeforeNow, format, boundingBox);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataserverApi.DataserverGairmet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataserverGairmetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dataserver for G-AIRMETs
    apiInstance.DataserverGairmetWithHttpInfo(startTime, endTime, hoursBeforeNow, format, boundingBox);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataserverApi.DataserverGairmetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startTime** | **string?** | Start time  * &#x60;yyyymmdd_hhmm&#x60;  * &#x60;yyyy-mm-ddThh:mm:ssZ&#x60;  | [optional]  |
| **endTime** | **string?** | End time  * &#x60;yyyymmdd_hhmm&#x60;  * &#x60;yyyy-mm-ddThh:mm:ssZ&#x60;  | [optional]  |
| **hoursBeforeNow** | **decimal?** | Number of hours before now to search | [optional]  |
| **format** | **string?** | Output format | [optional] [default to xml] |
| **boundingBox** | **string?** | Geographic bounding box (lat0, lon0, lat1, lon1) | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="dataservermetars"></a>
# **DataserverMetars**
> void DataserverMetars (string? stationString = null, string? startTime = null, string? endTime = null, decimal? hoursBeforeNow = null, string? format = null, bool? mostRecent = null, string? mostRecentForEachStation = null, string? boundingBox = null)

Dataserver for METARs

METAR reports

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataserverMetarsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataserverApi(config);
            var stationString = "stationString_example";  // string? | Station ID(s) Note: must specify stationString or bounding box (minLat, ...) (optional) 
            var startTime = ;  // string? | Start time  * `yyyymmdd_hhmm`  * `yyyy-mm-ddThh:mm:ssZ`  (optional) 
            var endTime = ;  // string? | End time  * `yyyymmdd_hhmm`  * `yyyy-mm-ddThh:mm:ssZ`  (optional) 
            var hoursBeforeNow = 8.14D;  // decimal? | Number of hours before now to search (optional) 
            var format = "xml";  // string? | Output format (optional)  (default to xml)
            var mostRecent = true;  // bool? | Single most recent METAR (optional) 
            var mostRecentForEachStation = "constraint";  // string? | Most recent METAR per station (optional) 
            var boundingBox = ;  // string? | Geographic bounding box (lat0, lon0, lat1, lon1) (optional) 

            try
            {
                // Dataserver for METARs
                apiInstance.DataserverMetars(stationString, startTime, endTime, hoursBeforeNow, format, mostRecent, mostRecentForEachStation, boundingBox);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataserverApi.DataserverMetars: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataserverMetarsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dataserver for METARs
    apiInstance.DataserverMetarsWithHttpInfo(stationString, startTime, endTime, hoursBeforeNow, format, mostRecent, mostRecentForEachStation, boundingBox);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataserverApi.DataserverMetarsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stationString** | **string?** | Station ID(s) Note: must specify stationString or bounding box (minLat, ...) | [optional]  |
| **startTime** | **string?** | Start time  * &#x60;yyyymmdd_hhmm&#x60;  * &#x60;yyyy-mm-ddThh:mm:ssZ&#x60;  | [optional]  |
| **endTime** | **string?** | End time  * &#x60;yyyymmdd_hhmm&#x60;  * &#x60;yyyy-mm-ddThh:mm:ssZ&#x60;  | [optional]  |
| **hoursBeforeNow** | **decimal?** | Number of hours before now to search | [optional]  |
| **format** | **string?** | Output format | [optional] [default to xml] |
| **mostRecent** | **bool?** | Single most recent METAR | [optional]  |
| **mostRecentForEachStation** | **string?** | Most recent METAR per station | [optional]  |
| **boundingBox** | **string?** | Geographic bounding box (lat0, lon0, lat1, lon1) | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="dataserversigmet"></a>
# **DataserverSigmet**
> void DataserverSigmet (string? startTime = null, string? endTime = null, decimal? hoursBeforeNow = null, string? format = null, string? boundingBox = null)

Dataserver for AIRMETs and SIGMETs

Return AIRMETs and SIGMETs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataserverSigmetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataserverApi(config);
            var startTime = ;  // string? | Start time  * `yyyymmdd_hhmm`  * `yyyy-mm-ddThh:mm:ssZ`  (optional) 
            var endTime = ;  // string? | End time  * `yyyymmdd_hhmm`  * `yyyy-mm-ddThh:mm:ssZ`  (optional) 
            var hoursBeforeNow = 8.14D;  // decimal? | Number of hours before now to search (optional) 
            var format = "xml";  // string? | Output format (optional)  (default to xml)
            var boundingBox = ;  // string? | Geographic bounding box (lat0, lon0, lat1, lon1) (optional) 

            try
            {
                // Dataserver for AIRMETs and SIGMETs
                apiInstance.DataserverSigmet(startTime, endTime, hoursBeforeNow, format, boundingBox);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataserverApi.DataserverSigmet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataserverSigmetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dataserver for AIRMETs and SIGMETs
    apiInstance.DataserverSigmetWithHttpInfo(startTime, endTime, hoursBeforeNow, format, boundingBox);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataserverApi.DataserverSigmetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startTime** | **string?** | Start time  * &#x60;yyyymmdd_hhmm&#x60;  * &#x60;yyyy-mm-ddThh:mm:ssZ&#x60;  | [optional]  |
| **endTime** | **string?** | End time  * &#x60;yyyymmdd_hhmm&#x60;  * &#x60;yyyy-mm-ddThh:mm:ssZ&#x60;  | [optional]  |
| **hoursBeforeNow** | **decimal?** | Number of hours before now to search | [optional]  |
| **format** | **string?** | Output format | [optional] [default to xml] |
| **boundingBox** | **string?** | Geographic bounding box (lat0, lon0, lat1, lon1) | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="dataservertafs"></a>
# **DataserverTafs**
> void DataserverTafs (string? stationString = null, string? startTime = null, string? endTime = null, decimal? hoursBeforeNow = null, string? format = null, bool? mostRecent = null, string? mostRecentForEachStation = null, string? boundingBox = null)

Dataserver for TAFs

Return TAF data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataserverTafsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataserverApi(config);
            var stationString = ;  // string? | Station ID(s) Note: must specify stationString or bounding box (minLat, ...) (optional) 
            var startTime = ;  // string? | Start time  * `yyyymmdd_hhmm`  * `yyyy-mm-ddThh:mm:ssZ`  (optional) 
            var endTime = ;  // string? | End time  * `yyyymmdd_hhmm`  * `yyyy-mm-ddThh:mm:ssZ`  (optional) 
            var hoursBeforeNow = 8.14D;  // decimal? | Number of hours before now to search (optional) 
            var format = "xml";  // string? | Output format (optional)  (default to xml)
            var mostRecent = true;  // bool? | Single most recent TAF (optional) 
            var mostRecentForEachStation = "constraint";  // string? | Most recent TAF per station (optional) 
            var boundingBox = ;  // string? | Geographic bounding box (lat0, lon0, lat1, lon1) (optional) 

            try
            {
                // Dataserver for TAFs
                apiInstance.DataserverTafs(stationString, startTime, endTime, hoursBeforeNow, format, mostRecent, mostRecentForEachStation, boundingBox);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataserverApi.DataserverTafs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataserverTafsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dataserver for TAFs
    apiInstance.DataserverTafsWithHttpInfo(stationString, startTime, endTime, hoursBeforeNow, format, mostRecent, mostRecentForEachStation, boundingBox);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataserverApi.DataserverTafsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stationString** | **string?** | Station ID(s) Note: must specify stationString or bounding box (minLat, ...) | [optional]  |
| **startTime** | **string?** | Start time  * &#x60;yyyymmdd_hhmm&#x60;  * &#x60;yyyy-mm-ddThh:mm:ssZ&#x60;  | [optional]  |
| **endTime** | **string?** | End time  * &#x60;yyyymmdd_hhmm&#x60;  * &#x60;yyyy-mm-ddThh:mm:ssZ&#x60;  | [optional]  |
| **hoursBeforeNow** | **decimal?** | Number of hours before now to search | [optional]  |
| **format** | **string?** | Output format | [optional] [default to xml] |
| **mostRecent** | **bool?** | Single most recent TAF | [optional]  |
| **mostRecentForEachStation** | **string?** | Most recent TAF per station | [optional]  |
| **boundingBox** | **string?** | Geographic bounding box (lat0, lon0, lat1, lon1) | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

