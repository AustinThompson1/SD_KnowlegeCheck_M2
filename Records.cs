﻿namespace SD_KnowledgeCheck_M2
{

    public abstract class Records
    {
        public String recordName { get; set; }
        public String recordType { get; set; }

        public override string ToString()
        {
            return recordName;
        }
    }
}
// Print out the list of records using Console.WriteLine()