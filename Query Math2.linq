<Query Kind="Statements">
  <Connection>
    <ID>6e0bf7ec-18ee-4525-b776-9ea5d0848dbd</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
              where g.Name.Equals("Heavy Metal")
			  select new
			  {
			     TracksCount = g.Tracks.Count(),
				 Tracks = from t in g.Tracks
				          select new
				{
				     TrackName = t.Name,
					 AlbumName = t.Album.Title,
					 Milliseconds = t.Milliseconds,
					 Size = (t.Bytes / 1000) + " kb ",
					 Price = t.UnitPrice
				}
			};
results.Dump();