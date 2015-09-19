<Query Kind="Expression">
  <Connection>
    <ID>4fa56b6d-c127-46cb-b4fa-c35277558bd5</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//anonymous data type queries
from food in Items
where food.MenuCategory.Description.Equals("Entree")
		&& food.Active
orderby food.CurrentPrice descending
select new 
	{
		Description = food.Description,
		Price = food.CurrentPrice,
		Cost = food.CurrentCost,
		Profit = food.CurrentPrice - food.CurrentCost
	}
	
	
from food in Items
where food.MenuCategory.Description.Equals("Entree")
		&& food.Active
orderby food.CurrentPrice descending
select new 
	{
		food.Description,
		food.CurrentPrice,
		food.CurrentCost
		//Profit = food.CurrentPrice - food.CurrentCost
	}
	
	
	from food in Items
where food.MenuCategory.Description.Equals("Entree")
		&& food.Active
orderby food.CurrentPrice descending
select new //POCOObjectName
	{
		Description = food.Description,
		Price = food.CurrentPrice,
		Cost = food.CurrentCost,
		Profit = food.CurrentPrice - food.CurrentCost
	}