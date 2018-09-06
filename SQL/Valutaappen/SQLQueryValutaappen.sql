
--Insert into ExchangeRate ( Code, Rate, Date) 
--Values (@Code, @Rate, @Date)
--where Code=@Code

--Select Code, Country, Rate from ExchangeRate
--join CurrencyLocation on CurrencyLocation.CodeID = ExchangeRate.Code

--Select Top 1 Rate from ExchangeRate
--where code= 'AED'
--order by Date, Id desc