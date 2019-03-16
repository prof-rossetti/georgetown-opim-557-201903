# Software APIs Overview

> Please first read about [Computer Networks](computer-networks.md).

Today, the primary way humans interact with computer-based information systems is through visually- and spatially-oriented interfaces known as **Graphical User Interfaces (GUI)**. GUI interactions include clicking, dragging, tapping, and other gestures.

But many systems additionally or alternatively allow programmatic usage through textually-oriented interfaces known as **Application Programming Interfaces (APIs)**. APIs provide the instructions and mechanisms for a human or computer to programmatically interact with the system.

**Web Services** are APIs which facilitate the transmission of a system's data across the Internet. Web services provide one or more servers which usually accept HTTP requests at specified URLs and return responses containing textual information in a machine-readable format.

Some notable example web services and providers include:

 + [New York Times APIs](http://developer.nytimes.com/docs)
 + [Google APIs](https://developers.google.com/apis-explorer/#p/)
 + [Twitter APIs](https://dev.twitter.com/rest/public)
 + [Facebook Social Graph API](https://developers.facebook.com/docs/graph-api)
 + [Instagram API](https://instagram.com/developer/endpoints/)
 + [Foursquare API](https://developer.foursquare.com/docs/)
 + [GitHub API](https://developer.github.com/v3/)
 + [Yelp API](https://www.yelp.com/developers/documentation/v2/overview)
 + [Flickr API](https://www.flickr.com/services/api/)
 + [Getty Images API](http://developers.gettyimages.com/en/)
 + [US Federal Elections Commission API](https://api.open.fec.gov/developers)
 + [Alpha Vantage (Stock Market) API](https://www.alphavantage.co/documentation/)

### Authentication

Many web services require developers to first register to obtain valid credentials in the form of an **API Key** (i.e. a secret token string) and subsequently authenticate by providing the key alongside each API request. This allows the service provider to understand who is issuing each request, and can help prevent or mitigate abuse of the service.

### Response Formats

The most common format for API response data is JSON, but some APIs alternatively or additionally provide response data in XML or CSV format.

Example CSV:

```csv
city,name,league
New York,Mets,Major
New York,Yankees,Major
Boston,Red Sox,Major
Washington,Nationals,Major
New Haven,Ravens,Minor
```

Example JSON:

```js
[
  {"city": "New York", "name": "Yankees", "league":"Major"},
  {"city": "New York", "name": "Mets", "league":"Major"},
  {"city": "Boston", "name": "Red Sox", "league":"Major"},
  {"city": "Washington", "name": "Nationals", "league":"Major"},
  {"city": "New Haven", "name": "Ravens", "league":"Minor"}
]
```

Example XML:

```xml
<?xml version="1.0" encoding="UTF-8"?>
<teams>
  <team>
    <city>New York</city>
    <league>Major</league>
    <name>Yankees</name>
  </team>
  <team>
    <city>New York</city>
    <league>Major</league>
    <name>Mets</name>
  </team>
  <team>
    <city>Boston</city>
    <league>Major</league>
    <name>Red Sox</name>
  </team>
  <team>
    <city>Washington</city>
    <league>Major</league>
    <name>Nationals</name>
  </team>
  <team>
    <city>New Haven</city>
    <league>Minor</league>
    <name>Ravens</name>
  </team>
</teams>
```

### Request Parameters

Many APIs allow you to specify URL parameters along with your HTTP request. These URL parameters are appended to the end of the API's base URL, starting with a single question mark (`?`) to denote the rest of the URL contains parameters. Then each parameter follows a convention where the name of the parameter is followed by an equal sign (`=`), which is followed by the desired parameter value. If there are multiple parameters, subsequent parameters after the first are separated by the ampersand character `&`.

Example request URL: https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol=MSFT&outputsize=compact&apikey=demo.

In this example, `https://www.alphavantage.co/query` is the base URL. And `function`, `symbol`, `outputsize`, and `apikey` are the names of URL parameters.

> Note: you might have to register and specify your own API key if you are seeing a message like "The demo API key is for demo purposes only."
