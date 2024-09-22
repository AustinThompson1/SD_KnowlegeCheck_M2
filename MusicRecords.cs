namespace SD_KnowledgeCheck_M2
{

    public class MusicRecords : Records
    {
        public string artist { get; set; }
        public int songAmount { get; set; }

        public override string ToString()
        {
            return artist;
        }
    }
    // Print out the list of records using Console.WriteLine()
}