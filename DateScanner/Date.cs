namespace DateScanner
{
    class Date
    {
        public string Day { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }

        public Date(string date)
        {
                string[] dateParts = date.Split('.');
                Day = dateParts[0];
                Month = dateParts[1];
                Year = dateParts[2];
        }
    }
}
