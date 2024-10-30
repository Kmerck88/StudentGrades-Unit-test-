using StudentGrades;

// Get Percentage from user
var gradeCalculator = new GradeCalculator();

Console.writeLine("Enter the percentage : ");
var percentage = Convert.ToInt32(Console.ReadLine());

var grade = gradeCalculator.GetGradeByPercentage(percentage);

// Display the grade
Console.WriteLine($"The grade is {grade}");
