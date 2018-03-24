# Sample implementation of linear ordering in C#

## Example data

|Name|Price [zł]|RAM [GB]|Hard drive space [GB]|Screen resolution (width) [px]|Screen size ["]|Weight [kg]|
|:-------------:|:-------------:|:-------------:|:-------------:|:-------------:|:-------------:|:-------------:|
|Legion Y520|3499|8|1000|1920|15.6|2.4|
|INSPIRON 5570|3399|12|1128|1920|15.6|2.56|
|INSPIRON 5577|3329|8|1256|1920|15.6|2.56|
|Ideapad 320|2999|8|128|1920|15.6|2.2|
|VivoBook S14|3749|12|256|1920|14|1.43|
|Zenbook UX430UA|3899|8|256|1920|14|1.3|
|Latitude E5440|1499|8|240|1366|14|2.295|

## Example results

### Selected weights:

|Price [zł]|RAM [GB]|Hard drive space [GB]|Screen resolution (width) [px]|Screen size ["]|Weight [kg]|
|:-------------:|:-------------:|:-------------:|:-------------:|:-------------:|:-------------:|
|0.3|0.2|0.05|0.2|0.2|0.05|

### Normalization function: Standardization

### Distance function: Euclidean

### Ranking:

|Name|Distance|
|:-------------:|:-------------:|
|INSPIRON 5570| 1.51656808310594|
|Ideapad 320| 1.63661253516627|
|INSPIRON 5577| 1.7704062682985|
|Legion Y520| 1.8502270516242|
|VivoBook S14| 1.95139275789584|
|Latitude E5440| 1.97177429000403|
|Zenbook UX430UA| 2.27220182688449|
