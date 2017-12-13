namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext
{
    public class CustomField
    {
        /// <summary>
        /// string
        /// </summary>
        public static CustomField SaasClientLabelAnx { get; } = new CustomField(15, 19);

        /// <summary>
        /// date
        /// </summary>
        public static CustomField SaasExpirationPerYear { get; } = new CustomField(15, 20);

        /// <summary>
        /// string
        /// </summary>
        public static CustomField ClientStatusWmbx { get; } = new CustomField(15, 3);

        /// <summary>
        /// string
        /// </summary>
        public static CustomField ClientTypeDwbf { get; } = new CustomField(15, 4);

        /// <summary>
        /// number
        /// </summary>
        public static CustomField WarrentyAmount { get; } = new CustomField(15, 5);

        /// <summary>
        /// date
        /// </summary>
        public static CustomField WarrDue { get; } = new CustomField(15, 6);

        /// <summary>
        /// date
        /// </summary>
        public static CustomField WarrTo { get; } = new CustomField(15, 7);

        /// <summary>
        /// date
        /// </summary>
        public static CustomField WarrFrom { get; } = new CustomField(15, 8);

        /// <summary>
        /// string
        /// </summary>
        public static CustomField ClientLabelAnx { get; } = new CustomField(15, 9);
        
        
        /// <summary>
        /// the table number
        /// </summary>
        public int TableNumber {get;}

        /// <summary>
        /// the column sequence
        /// </summary>
        public int ColumnSequence { get; }

        /// <summary>
        /// creates a custom field with the given table number and column sequence
        /// </summary>
        /// <param name="tableNumber">the table number</param>
        /// <param name="colSeq">the column sequence</param>
        private CustomField(int tableNumber, int colSeq)
        {
            TableNumber = tableNumber;
            ColumnSequence = colSeq;
        }


    }
}
