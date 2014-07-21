namespace SimpleT4Template
{
	class MyClass
	{
				public int Item0 { get; set; }
				public int Item1 { get; set; }
				public int Item2 { get; set; }
				
		public int SumThreeNumbers(int one, int two, int three)
		 {
			var sum = 0;
			
			sum += one;                
			sum += two;
			sum += three;

			return sum;
	    }
    
		//I couldn't find how to pass the parameters when call the method
		//SumThreeNumbers(1, 2, 3);
		
	}
}