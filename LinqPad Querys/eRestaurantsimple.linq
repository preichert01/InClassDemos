<Query Kind="Statements">
  <Connection>
    <ID>4fa56b6d-c127-46cb-b4fa-c35277558bd5</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//Simplest form for dumping a n entity
Waiters;

// Simple query syntax
from person in Waiters
select person

//simple method syntax
Waiters.Select(person => person);

// inside our project we will be writting C# statement
var results = from person in Waiters
				select person;
// to display the contents of the variable in LinqPad use the .Dump() method
results.Dump();
// implemented inside a VS project's class library BLL method
[DataObjectMethod(DataObjectMethodType.Select,false)]
public List<Waiters> SomeMethodName ()
{
	//you will need to connect to your DAL object 
	//this will be done using a new xxxx() constructor 
	//assume your connection variable is called contextvariable
	
	//do your query
	var results = from person in contextvariable.Waiters
				select person;
	//return your results
	return results.ToList();
}