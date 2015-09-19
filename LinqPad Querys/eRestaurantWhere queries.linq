<Query Kind="Expression">
  <Connection>
    <ID>4fa56b6d-c127-46cb-b4fa-c35277558bd5</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//where clause

//list all tables that hold more that 3 people
//query syntax
from row in Tables
where row.Capacity > 3
select row

// method syntax
Tables.Where(row => row.Capacity > 3)

// list all items with more than 500 calories

from food in Items
where food.Calories > 500
select food

Items.Where(food => food.Calories > 500)

// list all items with more than 500 malories and selling for more than $10

from food in Items 
where food.Calories > 500 && food.CurrentPrice > 10.00m
select food

Items.Where(food => food.Calories  > 500 && food.CurrentPrice > 10.00m)

// list all items with more than 500 calories and are Entrees on the menu
//HINT: navigational properties of the database are known by LinqPad
from food in Items
where food.Calories >500 && food.MenuCategory.Description.Equals("Entree") 
select food 