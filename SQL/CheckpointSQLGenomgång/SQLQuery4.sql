

--Select Church.Name, City.CityName, Church.YearBuilt from Church
--join City on City.ID = Church.CityID

--Select Person.FirstName, City.CityName from Person
--join City on Person.CityID = City.ID

--Select Person.FirstName, Church.Name, Church.YearBuilt from Person
--join Church on church.ID = Person.FavoriteChurchID

Select Person.FirstName, Church.Name, Church.YearBuilt from Person
join FavouriteChurch on	FavouriteChurch.PersonID = Person.ID
join Church on Church.ID = FavouriteChurch.ChurchID
