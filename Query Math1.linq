<Query Kind="Statements">
  <Connection>
    <ID>6e0bf7ec-18ee-4525-b776-9ea5d0848dbd</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
              orderby g.Name
			  select new
			  {
			      Grnre = g.Name,
				  TracksCount = g.Tracks.Count()
			  };
results.Dump("Query Math");