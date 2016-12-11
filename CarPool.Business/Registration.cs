namespace CarPool.Business
{
    public class Registration
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string EmployeeId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string Register()
        {
            if (IsValid())
            {
                return "Registration successful";
            }

            return "Invalid registration details";
        }

        private bool IsValid()
        {
            if (Email.Contains("@"))
            {
                return true;
            }

            return false;
        }
    }
}