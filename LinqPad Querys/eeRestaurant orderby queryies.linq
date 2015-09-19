<Query Kind="Expression">
  <Connection>
    <ID>4fa56b6d-c127-46cb-b4fa-c35277558bd5</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//order by
// default is ascending
from food in Items
orderby food.Description
select food
// descending has to be specified.
from food in Items 
orderby food.CurrentPrice descending
select food

// can use both ascending and descending
from food in Items 
orderby food.CurrentPrice descending, food.Calories ascending
select food

// you can use wheere and orderby together
from food in Items
where food.MenuCategory.Description.Equals("Entree")
orderby food.CurrentPrice descending, food.Calories ascending 

select food