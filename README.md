# Labb4API

### Hämta alla personer i systemet
Get
https://localhost:44363/api/People/

### Hämta alla intressen som är kopplade till en specifik person
Get
https://localhost:44363/api/interest/1
Hämtar alla Intressen som personen med Id 1 har.

### Hämta alla länkar som är kopplade till en specifik person
Get
https://localhost:44363/api/Link/1
Hämtar alla länkar där person Id är 1.

### Koppla en person till ett nytt intresse



### Lägga in nya länkar för en specifik person och ett specifikt intresse

https://localhost:44363/api/Link/
Post
En Json som ser ut som följer
{ 
"LinksId":4,
"LinkAdress": "www.fest.se", 
"PersonId": 1,
"InterestId": 1
}
