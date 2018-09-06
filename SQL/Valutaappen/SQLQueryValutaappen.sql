
--Insert into ExchangeRate ( Code, Rate, Date) 
--Values (@Code, @Rate, @Date)
--where Code=@Code

Select Code, name, Rate, Date from ExchangeRate
join Country on Country.CodeID = ExchangeRate.Code
