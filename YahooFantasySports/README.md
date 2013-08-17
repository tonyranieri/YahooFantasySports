# Yahoo Fantasy Sports oAuth Sample

To use you will need to add a file in the root of the web project "oAuth.keys.config" which should contain this:

```
<oAuthConfig 
	YahooConsumerKey="**YOUR CONSUMER KEY**" 
	YahooConsumerSecret="**YOUR CONSUMER SECRET**" />
```

##How To Use This Code
1. Add the oAuthConfig as noted above.
2. Run the application
3. Click the button to authenticate with Yahoo
4. Agree to the data access
5. Use the notes below to query your Fantasy Sports League

##Sample Query
**http://fantasysports.yahooapis.com/fantasy/v2/leagues;league_keys=GAMEKEY.l.LEAGUEID**


###League Id:
Look at the URL to one of your fantasy leagues, for example this baseball league's URL is: 
[http://baseball.fantasysports.yahoo.com/b1/#####](http://baseball.fantasysports.yahoo.com/b1/##### "http://baseball.fantasysports.yahoo.com/b1/#####")
The **#####** at the end of the URL is your League Id.


###Game Key:
Since we already know this is a baseball league, we can simply use the "mlb" key.

Alternatively you can use the numeric Game ID from Yahoo. This can be useful to look at data from a specific year of your league

[http://developer.yahoo.com/fantasysports/guide/game-resource.html#game-resource-key_format](http://developer.yahoo.com/fantasysports/guide/game-resource.html#game-resource-key_format "http://developer.yahoo.com/fantasysports/guide/game-resource.html#game-resource-key_format")