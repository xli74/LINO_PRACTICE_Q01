<Query Kind="Statements">
  <Connection>
    <ID>6e0bf7ec-18ee-4525-b776-9ea5d0848dbd</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from m in MediaTypes
              select new
			  {
			      Name = m.Name,
				  Tracks = from t in m.Tracks
				           select new
				{
				       TrackName =  t.Name,
					   Album = t.Album.Title,
					   Artist = t.Album.Artist.Name,
					   Genre = t.Genre.Name,
					   ReleaseYear = t.Album.ReleaseYear,
					   ReleaseLabel = t.Album.ReleaseLabel,
					   
				}
			};
results.Dump();
			   