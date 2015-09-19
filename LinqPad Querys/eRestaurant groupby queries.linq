<Query Kind="Expression">
  <Connection>
    <ID>4fa56b6d-c127-46cb-b4fa-c35277558bd5</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

// groupby 
from food in Items
group food by food.MenuCategory.Description

// this creates a key with a value and the row collection for that key value

// more than one field
from food in Items
group food by new {food.MenuCategory.Description, food.CurrentPrice}