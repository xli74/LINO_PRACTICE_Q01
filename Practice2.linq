<Query Kind="Statements">
  <Connection>
    <ID>6e0bf7ec-18ee-4525-b776-9ea5d0848dbd</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from x in Artists
              where x.ArtistId == 1
			  orderby x.Name
			  select new
			  {
			      Artist =x.Name,
				  Albums = from t in x.Albums
				           orderby t.Title
						   select new
				   {
				       Title = t.Title,
					   Tracks = from tr in t.Tracks
					            select new
					    {
					         TrackName = tr.Name,
						     Genre = tr.Genre.Name,
							 MediaType = tr.MediaType.Name,
						     Composer = tr.Composer,
						     Milliseconds = tr.Milliseconds
			            }
				    }
			    };
results.Dump();