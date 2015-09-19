<Query Kind="Program">
  <Connection>
    <ID>4fa56b6d-c127-46cb-b4fa-c35277558bd5</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

void Main()
{
	var results = from food in Items
		where food.MenuCategory.Description.Equals("Entree")
		&& food.Active
		orderby food.CurrentPrice descending
		select new FoodMargins()
		{
			Price = food.CurrentPrice,
			Cost = food.CurrentCost,
			Profit = food.CurrentPrice - food.CurrentCost
		};
		results.Dump();
	//get all the bills and bill items for waiters in September of 2014
	//only those bills which were paid.
	
	var results2 = from orders in Bills
					where orders.PaidStatus && 
					(orders.BillDate.Month == 9 && orders.BillDate.Year == 2014)
					orderby orders.Waiter.LastName, orders.Waiter.FirstName
					select new 
					{
						BillID = orders.BillID,
						WaiterName = orders.Waiter.LastName + " " + orders.Waiter.FirstName,
						Orders = orders.BillItems
					};
				results2.Dump();
	
}// eop

// define other methods and classes here
//this is POCO class

public class FoodMargins
{
	public string Description {get; set;}
	public decimal Price {get; set;}
	public decimal Cost {get; set;}
	public decimal Profit {get; set;}
}

//this is a DTO Class
public class BillOrders 
{
	public int BillID{get;set;}
	public string WaiterName {get;set;}
	public BillItems Orders{get;set;}
}
