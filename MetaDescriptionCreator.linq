<Query Kind="Program" />

void Main()
{
	Directory.SetCurrentDirectory (Path.GetDirectoryName (Util.CurrentQueryPath));
	var worldList = File.ReadAllLines(@"worldcities.csv");
	var phrases = File.ReadAllLines(@"phrases.txt");
	var metaDescriptions = new List<string>();
	
	for (int i = 1; i < worldList.Length; i++)
	{
		var location = worldList[i].Split(',');
		var city = location[1];
		var country = location[4];
		for (int j = 0;	j < phrases.Length; j++)
		{
			metaDescriptions.Add($"{phrases[j]} - Experience {city}, {country} with P360 from TeliportMe.com");
		}
	}
	
	metaDescriptions.Count.Dump("Meta Descriptions Generated");
}
