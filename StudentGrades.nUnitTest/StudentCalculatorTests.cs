namespace StudentGrades.nUnitTest
{
	public class StudentCalculatorTests
	{
		private GradeCalculator _gradeCalculator { get; set; } = null;
		[SetUp]
		public void Setup()
		{
			_gradeCalculator = new GradeCalculator();
		}

		[TestCase(91)]
		[TestCase(95)]
		[TestCase(97)]
		[TestCase(99)]
		
		
		public void GetGradeByPercentage_EqualTest(int percentage)
		{

			// assign
			// var percentage = 99;

			// act
			var grade = _gradeCalculator.GetGradeByPercentage(percentage);

			// assert
			Assert.That(grade, Is.EqualTo("A"));
		}
	}
}
