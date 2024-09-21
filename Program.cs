namespace SD_KnowledgeCheck_M2
{
    internal partial class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many records would you like to add");
            int numberOfRecords = Convert.ToInt32(Console.ReadLine());

            List<Records> recordList = new List<Records>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                OtherRecords inputOtherRecord = new OtherRecords();
                MusicRecords inputMusicRecord = new MusicRecords();
                PodcastRecords inputPodcastRecord = new PodcastRecords();

                Console.WriteLine("Press 0 to exit.\n Press 1 to view all records\n Press 2 to add a MusicRecord\n Press 3 to add a PodcastRecord\n Press 4 to add OtherRecord \n Please enter a number.");
                int userInput = Convert.ToInt32(Console.ReadLine());
                while (userInput != 0)
                {
                    if (userInput == 1)
                    {
                        foreach (var Records in recordList)
                        {
                            Console.WriteLine(recordList);
                        }
                    }



                    if (userInput == 2)
                    {
                        inputMusicRecord.recordType = "Music";

                        Console.WriteLine($"Enter the new artist.");
                        inputMusicRecord.recordName = Console.ReadLine();
                        Console.WriteLine($"You entered {inputMusicRecord.recordName}.");


                        Console.WriteLine($"How many songs would you like to add to {inputMusicRecord.recordName}?");
                        inputMusicRecord.songAmount = Convert.ToInt32(Console.ReadLine());
                        recordList.Add(inputMusicRecord);
                        Console.WriteLine("Record has been added press 0 to exit.");
                    }
                    if (userInput == 3)
                    {
                        inputPodcastRecord.recordType = "Podcast";

                        Console.WriteLine($"Enter the new title.");
                        inputPodcastRecord.recordName = Console.ReadLine();
                        Console.WriteLine($"You entered {inputPodcastRecord.recordName}.");
                        Console.WriteLine($"What are the hosts in the podcast {inputPodcastRecord.recordName}");
                        inputPodcastRecord.podcastHosts = Console.ReadLine();
                        recordList.Add(inputPodcastRecord);
                        Console.WriteLine("Record has been added press 0 to exit.");
                    }
                    if (userInput == 4)
                    {
                        Console.WriteLine($"Enter the Title.");
                        inputOtherRecord.recordName = Console.ReadLine();
                        Console.WriteLine($"You entered {inputOtherRecord.recordName}.");
                        recordList.Add(inputOtherRecord);
                        Console.WriteLine("Record has been added press 0 to exit.");

                    }
                }
            }
        }
    }
}
    // Print out the list of records using Console.WriteLine()