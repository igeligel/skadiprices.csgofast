# skadiprices.csgofast Documentation

## SkadiCsGoFast

*Summary*
> Class to contact the csgofast pricing api.

- [public static ISkadiPriceList GetPrices()](#public-static-iskadipricelist-getprices)

---------------------------------

### public static ISkadiPriceList GetPrices()

*Summary*
> Method to get the prices by the api.

*Returns*
> A list of items which contains the markethashname.
>
>  For further reference lookup: [ISkadiPriceList](https://github.com/igeligel/skadiprices.csgofast/blob/master/src/skadiprices.csgofast/Interfaces/ISkadiPriceList.cs).

*Example*
```csharp
var prices = SkadiCsGoFast.GetPrices();
```

A sample of the the prices instance can be found [here](http://i.imgur.com/EMp0o9Z.png).
