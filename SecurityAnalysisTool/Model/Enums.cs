using System;

namespace SecurityAnalysisTool
{
	public enum Frequency
	{
		Daily,
		Weekly,
		Monthly,
		Yearly,
		Never,
		NoAnswer
	};

	public enum Education
	{
		SomeHigh,
		High,
		SomeNonComputerCollege,
		SomeComputerCollege,
		NonComputerUndergrad,
		ComputerUndergrad,
		NonComputerGrad,
		ComputerGrad,
		NoAnswer
	};

	public enum Age
	{
		AgeLess18,
		Age19To23,
		Age24To30,
		Age31To40,
		Age41To60,
		Age61Plus,
		NoAnswer
	};

	public enum Sex
	{
		Male,
		Female,
		NoAnswer
	};

	public enum Profession
	{
		Technology,
		Healthcare,
		Student,
		Unemployed,
		Office,
		Management,
		Other,
		NoAnswer
	};

	public enum Technology
	{
		Laptop,
		Tablet,
		Desktop,
		NonSmartphone,
		Smartphone,
		Other,
		NoAnswer
	};

	public enum NumPass
	{
		SingleCommon,
		MultipleDistinct,
		NoAnswer
	};

	public enum PassType
	{
		CommonUsedPass,
		Alphabetic,
		Numeric,
		SpecialSymbols,
		MoreThan8,
		LessThan8,
		RealWords,
		PetNames,
		UpperLower,
		Random,
		NoAnswer
	};

	public enum YesNo
	{
		Yes,
		No,
		NotSure,
		NoAnswer
	}

	public enum SecureLevel
	{
		Poor,
		Fair,
		Good,
		Better,
		Best,
		NoAnswer
	}

	public enum SharePersonalInfo
	{
		YesBoth,
		SocialOnly,
		ProOnly,
		No,
		NoAnswer
	}
}

