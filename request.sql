select t.ProductId, COUNT(min_date)
from 
	(
		select ProductId, MIN(DateCreated) AS min_date
		from Sales
		group by CustomerId
	)t
group by ProductId	
	