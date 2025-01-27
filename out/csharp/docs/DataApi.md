# Org.OpenAPITools.Api.DataApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DataAirport**](DataApi.md#dataairport) | **GET** /api/data/airport | Airport info |
| [**DataAreaFcst**](DataApi.md#dataareafcst) | **GET** /api/data/areafcst | US Area Forecasts |
| [**DataCWA**](DataApi.md#datacwa) | **GET** /api/data/cwa | CWSU Center Advisories |
| [**DataFcstDisc**](DataApi.md#datafcstdisc) | **GET** /api/data/fcstdisc | US Forecast Discussions |
| [**DataFeature**](DataApi.md#datafeature) | **GET** /api/data/feature | Feature info |
| [**DataFix**](DataApi.md#datafix) | **GET** /api/data/fix | Naviagtional fix info |
| [**DataGAIRMET**](DataApi.md#datagairmet) | **GET** /api/data/gairmet | US Graphical AIRMETs |
| [**DataMIS**](DataApi.md#datamis) | **GET** /api/data/mis | Meteorological Information Statement |
| [**DataMetars**](DataApi.md#datametars) | **GET** /api/data/metar | METARs |
| [**DataNavaid**](DataApi.md#datanavaid) | **GET** /api/data/navaid | Navigational aid info |
| [**DataObstacle**](DataApi.md#dataobstacle) | **GET** /api/data/obstacle | Obstacle info |
| [**DataPIREPPHP**](DataApi.md#datapirepphp) | **GET** /api/data/pirep | Pilot Reports |
| [**DataSIGMET**](DataApi.md#datasigmet) | **GET** /api/data/airsigmet | Domestic AIRMETs/SIGMETs |
| [**DataStationInfo**](DataApi.md#datastationinfo) | **GET** /api/data/stationinfo | Station info |
| [**DataTaf**](DataApi.md#datataf) | **GET** /api/data/taf | TAFs |
| [**DataWindTemp**](DataApi.md#datawindtemp) | **GET** /api/data/windtemp | Wind/Temp Point Data |
| [**DataiSIGMET**](DataApi.md#dataisigmet) | **GET** /api/data/isigmet | International SIGMETs |

<a id="dataairport"></a>
# **DataAirport**
> void DataAirport (string? ids = null, string? bbox = null, string? format = null)

Airport info

Information about airports

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataAirportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataApi(config);
            var ids = KMCI;  // string? | Station ID(s) (optional) 
            var bbox = ;  // string? | Geographic bounding box (lat0, lon0, lat1, lon1) (optional) 
            var format = "decoded";  // string? | Format (optional) 

            try
            {
                // Airport info
                apiInstance.DataAirport(ids, bbox, format);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.DataAirport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataAirportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Airport info
    apiInstance.DataAirportWithHttpInfo(ids, bbox, format);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.DataAirportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | **string?** | Station ID(s) | [optional]  |
| **bbox** | **string?** | Geographic bounding box (lat0, lon0, lat1, lon1) | [optional]  |
| **format** | **string?** | Format | [optional]  |

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
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="dataareafcst"></a>
# **DataAreaFcst**
> void DataAreaFcst (string region)

US Area Forecasts

Text Area Forecasts for the United States outside the contiguous states

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataAreaFcstExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataApi(config);
            var region = "gulf";  // string | Date  * `gulf` - Gulf of Mexico  * `hawaii` - Hawaii  * `aknorth` - Northern half of Alaska  * `akcentral` - Interior Alaska  * `aksouth` - Southcentral Alaska  * `aksouthwest` - Alaska Penninsula  * `aksoutheast` - Eastern Gulf of Alaska  * `akpanhandle` - Alaska 

            try
            {
                // US Area Forecasts
                apiInstance.DataAreaFcst(region);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.DataAreaFcst: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataAreaFcstWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // US Area Forecasts
    apiInstance.DataAreaFcstWithHttpInfo(region);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.DataAreaFcstWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **region** | **string** | Date  * &#x60;gulf&#x60; - Gulf of Mexico  * &#x60;hawaii&#x60; - Hawaii  * &#x60;aknorth&#x60; - Northern half of Alaska  * &#x60;akcentral&#x60; - Interior Alaska  * &#x60;aksouth&#x60; - Southcentral Alaska  * &#x60;aksouthwest&#x60; - Alaska Penninsula  * &#x60;aksoutheast&#x60; - Eastern Gulf of Alaska  * &#x60;akpanhandle&#x60; - Alaska  |  |

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
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datacwa"></a>
# **DataCWA**
> string DataCWA (string? hazard = null, string? date = null)

CWSU Center Advisories

Center Weather Advisories issued by NWS Center Weather Service Units (CWSUs)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataCWAExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataApi(config);
            var hazard = "ts";  // string? | Hazard (optional) 
            var date = ;  // string? | Date  * `yyyymmdd_hhmm`  * `yyyy-mm-ddThh:mm:ssZ`  (optional) 

            try
            {
                // CWSU Center Advisories
                string result = apiInstance.DataCWA(hazard, date);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.DataCWA: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataCWAWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CWSU Center Advisories
    ApiResponse<string> response = apiInstance.DataCWAWithHttpInfo(hazard, date);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.DataCWAWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hazard** | **string?** | Hazard | [optional]  |
| **date** | **string?** | Date  * &#x60;yyyymmdd_hhmm&#x60;  * &#x60;yyyy-mm-ddThh:mm:ssZ&#x60;  | [optional]  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, text/html, application/xml, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datafcstdisc"></a>
# **DataFcstDisc**
> void DataFcstDisc (string? cwa = null, string? type = null)

US Forecast Discussions

Aviation Forecast Discussions issued by NWS Weather Forecast Offices

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataFcstDiscExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataApi(config);
            var cwa = ;  // string? | County Warning Area (WFO) (optional) 
            var type = "afd";  // string? | Type of output:  * `afd` - aviation discussion  * `af` - full discussion  (optional) 

            try
            {
                // US Forecast Discussions
                apiInstance.DataFcstDisc(cwa, type);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.DataFcstDisc: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataFcstDiscWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // US Forecast Discussions
    apiInstance.DataFcstDiscWithHttpInfo(cwa, type);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.DataFcstDiscWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cwa** | **string?** | County Warning Area (WFO) | [optional]  |
| **type** | **string?** | Type of output:  * &#x60;afd&#x60; - aviation discussion  * &#x60;af&#x60; - full discussion  | [optional]  |

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
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datafeature"></a>
# **DataFeature**
> void DataFeature (string? bbox = null, string? format = null)

Feature info

Additional geographic features

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataFeatureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataApi(config);
            var bbox = ;  // string? | Geographic bounding box (lat0, lon0, lat1, lon1) (optional) 
            var format = "raw";  // string? | Format (optional) 

            try
            {
                // Feature info
                apiInstance.DataFeature(bbox, format);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.DataFeature: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataFeatureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Feature info
    apiInstance.DataFeatureWithHttpInfo(bbox, format);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.DataFeatureWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bbox** | **string?** | Geographic bounding box (lat0, lon0, lat1, lon1) | [optional]  |
| **format** | **string?** | Format | [optional]  |

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
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datafix"></a>
# **DataFix**
> void DataFix (string? ids = null, string? bbox = null, string? format = null)

Naviagtional fix info

Naviagtional fix data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataFixExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataApi(config);
            var ids = ;  // string? | 5 letter Fix ID(s) (optional) 
            var bbox = ;  // string? | Geographic bounding box (lat0, lon0, lat1, lon1) (optional) 
            var format = "raw";  // string? | Format (optional) 

            try
            {
                // Naviagtional fix info
                apiInstance.DataFix(ids, bbox, format);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.DataFix: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataFixWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Naviagtional fix info
    apiInstance.DataFixWithHttpInfo(ids, bbox, format);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.DataFixWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | **string?** | 5 letter Fix ID(s) | [optional]  |
| **bbox** | **string?** | Geographic bounding box (lat0, lon0, lat1, lon1) | [optional]  |
| **format** | **string?** | Format | [optional]  |

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
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datagairmet"></a>
# **DataGAIRMET**
> string DataGAIRMET (string? type = null, string? format = null, string? hazard = null, string? date = null)

US Graphical AIRMETs

Decoded G-AIRMETs for the contiguous United States

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataGAIRMETExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataApi(config);
            var type = "sierra";  // string? | Product type (optional) 
            var format = "decoded";  // string? | Format (optional) 
            var hazard = "turb-hi";  // string? | Hazard (optional) 
            var date = ;  // string? | Date (yyyymmdd_hhmm) (optional) 

            try
            {
                // US Graphical AIRMETs
                string result = apiInstance.DataGAIRMET(type, format, hazard, date);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.DataGAIRMET: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataGAIRMETWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // US Graphical AIRMETs
    ApiResponse<string> response = apiInstance.DataGAIRMETWithHttpInfo(type, format, hazard, date);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.DataGAIRMETWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | **string?** | Product type | [optional]  |
| **format** | **string?** | Format | [optional]  |
| **hazard** | **string?** | Hazard | [optional]  |
| **date** | **string?** | Date (yyyymmdd_hhmm) | [optional]  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, text/html, application/xml, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datamis"></a>
# **DataMIS**
> void DataMIS (string? loc = null)

Meteorological Information Statement

Meteorological Information Statements issued by NWS Center Weather Service Units (CWSU)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataMISExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataApi(config);
            var loc = ;  // string? | CWSU (optional) 

            try
            {
                // Meteorological Information Statement
                apiInstance.DataMIS(loc);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.DataMIS: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataMISWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Meteorological Information Statement
    apiInstance.DataMISWithHttpInfo(loc);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.DataMISWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loc** | **string?** | CWSU | [optional]  |

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
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datametars"></a>
# **DataMetars**
> void DataMetars (string? ids = null, string? format = null, bool? taf = null, decimal? hours = null, string? bbox = null, string? date = null)

METARs

Decoded aviation weather observations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataMetarsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataApi(config);
            var ids = ;  // string? | Station ID(s) (optional) 
            var format = "raw";  // string? | Format (optional) 
            var taf = true;  // bool? | Include TAF (optional) 
            var hours = 8.14D;  // decimal? | Hours back to search (optional) 
            var bbox = ;  // string? | Geographic bounding box (lat0, lon0, lat1, lon1) (optional) 
            var date = ;  // string? | Date  * `yyyymmdd_hhmm`  * `yyyy-mm-ddThh:mm:ssZ`  (optional) 

            try
            {
                // METARs
                apiInstance.DataMetars(ids, format, taf, hours, bbox, date);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.DataMetars: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataMetarsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // METARs
    apiInstance.DataMetarsWithHttpInfo(ids, format, taf, hours, bbox, date);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.DataMetarsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | **string?** | Station ID(s) | [optional]  |
| **format** | **string?** | Format | [optional]  |
| **taf** | **bool?** | Include TAF | [optional]  |
| **hours** | **decimal?** | Hours back to search | [optional]  |
| **bbox** | **string?** | Geographic bounding box (lat0, lon0, lat1, lon1) | [optional]  |
| **date** | **string?** | Date  * &#x60;yyyymmdd_hhmm&#x60;  * &#x60;yyyy-mm-ddThh:mm:ssZ&#x60;  | [optional]  |

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
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datanavaid"></a>
# **DataNavaid**
> void DataNavaid (string? ids = null, string? bbox = null, string? format = null)

Navigational aid info

Navigational aid data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataNavaidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataApi(config);
            var ids = ;  // string? | 5 letter Fix ID(s) (optional) 
            var bbox = ;  // string? | Geographic bounding box (lat0, lon0, lat1, lon1) (optional) 
            var format = "raw";  // string? | Format (optional) 

            try
            {
                // Navigational aid info
                apiInstance.DataNavaid(ids, bbox, format);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.DataNavaid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataNavaidWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Navigational aid info
    apiInstance.DataNavaidWithHttpInfo(ids, bbox, format);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.DataNavaidWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | **string?** | 5 letter Fix ID(s) | [optional]  |
| **bbox** | **string?** | Geographic bounding box (lat0, lon0, lat1, lon1) | [optional]  |
| **format** | **string?** | Format | [optional]  |

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
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="dataobstacle"></a>
# **DataObstacle**
> void DataObstacle (string? bbox = null, string? format = null)

Obstacle info

Aviation obstacle information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataObstacleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataApi(config);
            var bbox = ;  // string? | Geographic bounding box (lat0, lon0, lat1, lon1) (optional) 
            var format = "raw";  // string? | Format (optional) 

            try
            {
                // Obstacle info
                apiInstance.DataObstacle(bbox, format);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.DataObstacle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataObstacleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Obstacle info
    apiInstance.DataObstacleWithHttpInfo(bbox, format);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.DataObstacleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bbox** | **string?** | Geographic bounding box (lat0, lon0, lat1, lon1) | [optional]  |
| **format** | **string?** | Format | [optional]  |

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
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datapirepphp"></a>
# **DataPIREPPHP**
> void DataPIREPPHP (string? id = null, string? format = null, decimal? age = null, decimal? distance = null, decimal? level = null, string? inten = null, string? date = null)

Pilot Reports

Pilot reports issued in PIREP or AIREP format

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataPIREPPHPExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataApi(config);
            var id = "id_example";  // string? | Station ID (optional) 
            var format = "raw";  // string? | Format (optional) 
            var age = 8.14D;  // decimal? | Hours Back (optional) 
            var distance = 8.14D;  // decimal? | Distance (optional) 
            var level = 8.14D;  // decimal? | Level +-3000' to search (optional) 
            var inten = "lgt";  // string? | Minimum intensity (optional) 
            var date = ;  // string? | Date  * `yyyymmdd_hhmm`  * `yyyy-mm-ddThh:mm:ssZ`  (optional) 

            try
            {
                // Pilot Reports
                apiInstance.DataPIREPPHP(id, format, age, distance, level, inten, date);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.DataPIREPPHP: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataPIREPPHPWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Pilot Reports
    apiInstance.DataPIREPPHPWithHttpInfo(id, format, age, distance, level, inten, date);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.DataPIREPPHPWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string?** | Station ID | [optional]  |
| **format** | **string?** | Format | [optional]  |
| **age** | **decimal?** | Hours Back | [optional]  |
| **distance** | **decimal?** | Distance | [optional]  |
| **level** | **decimal?** | Level +-3000&#39; to search | [optional]  |
| **inten** | **string?** | Minimum intensity | [optional]  |
| **date** | **string?** | Date  * &#x60;yyyymmdd_hhmm&#x60;  * &#x60;yyyy-mm-ddThh:mm:ssZ&#x60;  | [optional]  |

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
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasigmet"></a>
# **DataSIGMET**
> void DataSIGMET (string? format = null, string? type = null, string? hazard = null, decimal? level = null, string? date = null)

Domestic AIRMETs/SIGMETs

Domestic SIGMETs and AIRMETs for the United States. Does not include SIGMETs issued by the US in international format. Domestic AIRMETs to be discontinued in January 2025.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataSIGMETExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataApi(config);
            var format = "raw";  // string? | Format (optional) 
            var type = "sigmet";  // string? | Product type (optional) 
            var hazard = "conv";  // string? | Hazard (optional) 
            var level = 8.14D;  // decimal? | The level +-3000' to search (optional) 
            var date = ;  // string? | Date  * `yyyymmdd_hhmm`  * `yyyy-mm-ddThh:mm:ssZ`  (optional) 

            try
            {
                // Domestic AIRMETs/SIGMETs
                apiInstance.DataSIGMET(format, type, hazard, level, date);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.DataSIGMET: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataSIGMETWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Domestic AIRMETs/SIGMETs
    apiInstance.DataSIGMETWithHttpInfo(format, type, hazard, level, date);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.DataSIGMETWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | **string?** | Format | [optional]  |
| **type** | **string?** | Product type | [optional]  |
| **hazard** | **string?** | Hazard | [optional]  |
| **level** | **decimal?** | The level +-3000&#39; to search | [optional]  |
| **date** | **string?** | Date  * &#x60;yyyymmdd_hhmm&#x60;  * &#x60;yyyy-mm-ddThh:mm:ssZ&#x60;  | [optional]  |

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
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datastationinfo"></a>
# **DataStationInfo**
> void DataStationInfo (string? ids = null, string? bbox = null, string? format = null)

Station info

Station observation location information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataStationInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataApi(config);
            var ids = ;  // string? | Station ID(s) (optional) 
            var bbox = 35,-90,45,-80;  // string? | Geographic bounding box (lat0, lon0, lat1, lon1) (optional) 
            var format = "raw";  // string? | Format (optional) 

            try
            {
                // Station info
                apiInstance.DataStationInfo(ids, bbox, format);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.DataStationInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataStationInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Station info
    apiInstance.DataStationInfoWithHttpInfo(ids, bbox, format);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.DataStationInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | **string?** | Station ID(s) | [optional]  |
| **bbox** | **string?** | Geographic bounding box (lat0, lon0, lat1, lon1) | [optional]  |
| **format** | **string?** | Format | [optional]  |

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
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datataf"></a>
# **DataTaf**
> void DataTaf (string? ids = null, string? format = null, bool? metar = null, string? bbox = null, string? time = null, string? date = null)

TAFs

Decoded Terminal Aerodrome Forecast products

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataTafExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataApi(config);
            var ids = ;  // string? | Station ID(s) (optional) 
            var format = "raw";  // string? | Format (optional) 
            var metar = true;  // bool? | Include METAR (optional) 
            var bbox = ;  // string? | Geographic bounding box (lat0, lon0, lat1, lon1) (optional) 
            var time = "valid";  // string? | Process time by valid (default) or issuance time (optional) 
            var date = ;  // string? | Date  * `yyyymmdd_hhmm`  * `yyyy-mm-ddThh:mm:ssZ`  (optional) 

            try
            {
                // TAFs
                apiInstance.DataTaf(ids, format, metar, bbox, time, date);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.DataTaf: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataTafWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // TAFs
    apiInstance.DataTafWithHttpInfo(ids, format, metar, bbox, time, date);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.DataTafWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | **string?** | Station ID(s) | [optional]  |
| **format** | **string?** | Format | [optional]  |
| **metar** | **bool?** | Include METAR | [optional]  |
| **bbox** | **string?** | Geographic bounding box (lat0, lon0, lat1, lon1) | [optional]  |
| **time** | **string?** | Process time by valid (default) or issuance time | [optional]  |
| **date** | **string?** | Date  * &#x60;yyyymmdd_hhmm&#x60;  * &#x60;yyyy-mm-ddThh:mm:ssZ&#x60;  | [optional]  |

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
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datawindtemp"></a>
# **DataWindTemp**
> void DataWindTemp (string? region = null, string? level = null, string? fcst = null)

Wind/Temp Point Data

Wind and temperature information from the legacy FD winds

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataWindTempExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataApi(config);
            var region = "us";  // string? | Region:  * `all` - All sites  * `bos` - Northeast  * `mia` - Southeast  * `chi` - North central  * `dfw` - South central  * `slc` - Rocky Mountain  * `sfo` - Pacific Coast  * `alaska` - Alaska  * `hawaii` - Hawaii  * `other_pac` - Western Pacific  (optional) 
            var level = "low";  // string? | Level (optional) 
            var fcst = "06";  // string? | Forecast cycle (optional) 

            try
            {
                // Wind/Temp Point Data
                apiInstance.DataWindTemp(region, level, fcst);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.DataWindTemp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataWindTempWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Wind/Temp Point Data
    apiInstance.DataWindTempWithHttpInfo(region, level, fcst);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.DataWindTempWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **region** | **string?** | Region:  * &#x60;all&#x60; - All sites  * &#x60;bos&#x60; - Northeast  * &#x60;mia&#x60; - Southeast  * &#x60;chi&#x60; - North central  * &#x60;dfw&#x60; - South central  * &#x60;slc&#x60; - Rocky Mountain  * &#x60;sfo&#x60; - Pacific Coast  * &#x60;alaska&#x60; - Alaska  * &#x60;hawaii&#x60; - Hawaii  * &#x60;other_pac&#x60; - Western Pacific  | [optional]  |
| **level** | **string?** | Level | [optional]  |
| **fcst** | **string?** | Forecast cycle | [optional]  |

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
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="dataisigmet"></a>
# **DataiSIGMET**
> void DataiSIGMET (string? format = null, string? hazard = null, decimal? level = null, string? date = null)

International SIGMETs

Decoded international SIGMETs. This does not include SIGMETs from the United States in domestic format.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataiSIGMETExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataApi(config);
            var format = "raw";  // string? | Format (optional) 
            var hazard = "turb";  // string? | Hazard (optional) 
            var level = 8.14D;  // decimal? | Level +-3000' to search (optional) 
            var date = ;  // string? | Date  * `yyyymmdd_hhmm`  * `yyyy-mm-ddThh:mm:ssZ`  (optional) 

            try
            {
                // International SIGMETs
                apiInstance.DataiSIGMET(format, hazard, level, date);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.DataiSIGMET: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataiSIGMETWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // International SIGMETs
    apiInstance.DataiSIGMETWithHttpInfo(format, hazard, level, date);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.DataiSIGMETWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | **string?** | Format | [optional]  |
| **hazard** | **string?** | Hazard | [optional]  |
| **level** | **decimal?** | Level +-3000&#39; to search | [optional]  |
| **date** | **string?** | Date  * &#x60;yyyymmdd_hhmm&#x60;  * &#x60;yyyy-mm-ddThh:mm:ssZ&#x60;  | [optional]  |

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
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

