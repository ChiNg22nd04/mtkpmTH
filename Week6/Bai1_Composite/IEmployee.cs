interface IEmployee {
	// To set an employee name
	string Name { get; set; }
	// To set an employee department
	string Dept { get; set; }
	// To set an employee designation
	string Designation { get; set; }
	// To display an employee details
	void DisplayDetails();
}