using System;
using System.IO;
using System.Collections.Generic;

namespace SecurityAnalysisTool
{
	public class Parser
	{

		public List<Result> Parse ()
		{
			StreamReader reader = new StreamReader ("results.csv");
			String line;
			List<Result> retVal = new List<Result>();
			string[] delimiterChars = {",", @"\", "\""};

			while ((line = reader.ReadLine()) != null) {
				string[] cols = line.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

				if (cols[0].Equals("Survey-Response Set")){
					continue;
				}

				Age a = AgeParser(cols[2]);
				Sex s = SexParser(cols[3]);
				Profession p = ProfessionParser(cols[4]);
				Education e = EducationParser (cols[5]);
				YesNo citizen = YesNoParser(cols[6]);
				List<Technology> techList = TechnologyListParser(cols[7], cols[8], cols[9], cols[10], cols[11], cols[12]);
				Frequency pubComp = FrequencyParser(cols[13]);
				Frequency compHome = FrequencyParser(cols[14]);
				NumPass numPass = NumPassParser(cols[15]);
				List<PassType> passList = PassTypeParser(cols[16], cols[17], cols[18], cols[19], cols[20], cols[21], cols[22], cols[23], cols[24], cols[25]);
				Frequency changePass = FrequencyParser(cols[26]);
				YesNo sharePass = YesNoParser(cols[27]);
				YesNo passSecure = YesNoParser(cols[28]);
				YesNo passCompLogin = YesNoParser(cols[29]);
				YesNo passMobile = YesNoParser(cols[30]);
				YesNo wifiPass = YesNoParser (cols[31]);
				YesNo firewall = YesNoParser (cols[32]);
				YesNo virusSoft = YesNoParser(cols[33]);
				YesNo softUpdate = YesNoParser(cols[34]);
				SecureLevel secLevel = SecureLevelParser(cols[35]);
				SharePersonalInfo sharePersonal = SharePersonalInfoParser(cols[36]);
				Frequency pubWifi = FrequencyParser(cols[37]);

				Result r = new Result(a,s,p,e,citizen,techList,pubComp,compHome,numPass,passList,changePass,
				                      sharePass,passSecure, passCompLogin, passMobile, wifiPass, firewall, virusSoft,
				                      softUpdate, secLevel, sharePersonal, pubWifi);

				retVal.Add(r);
			}
			return retVal;
		}

		public Frequency FrequencyParser (String val)
		{
			Frequency retVal;
			if (val.Equals("Daily")) {
				retVal = Frequency.Daily;
			} else if (val.Equals("Weekly")) {
				retVal = Frequency.Weekly;
			} else if (val.Equals("Monthly")) {
				retVal = Frequency.Monthly;
			} else if (val.Equals("Yearly")) {
				retVal = Frequency.Yearly;
			} else if (val.Equals("Never")) {
				retVal = Frequency.Never;
			} else {
				retVal = Frequency.NoAnswer;
			}
			return retVal;
		}

		public YesNo YesNoParser (String val)
		{
			YesNo retVal;
			if (val.Equals("Yes")) {
				retVal = YesNo.Yes;
			} else if (val.Equals("No")) {
				retVal = YesNo.No;
			} else if (val.Equals("Not Sure")) {
				retVal = YesNo.NotSure;
			} else{
				retVal = YesNo.NoAnswer;
			}
			return retVal;
		}

		public Education EducationParser (String val)
		{
			Education retVal;
			if (val.Equals("Some High School")) {
				retVal = Education.SomeHigh;
			} else if (val.Equals("Some College (non-computer related)")) {
				retVal = Education.SomeNonComputerCollege;
			} else if (val.Equals("Some College (computer related)")) {
				retVal = Education.SomeComputerCollege;
			} else if (val.Equals("Undergraduate (non-computer related)")) {
				retVal = Education.NonComputerUndergrad;
			} else if (val.Equals("Undergraduate (computer related)")) {
				retVal = Education.ComputerUndergrad;
			} else if (val.Equals("Graduate (non-computer related)")) {
				retVal = Education.NonComputerGrad;
			} else if (val.Equals("Graduate (computer related)")) {
				retVal = Education.ComputerGrad;
			} else {
				retVal = Education.NoAnswer;
			}
			return retVal;
		}

		public Age AgeParser (String val)
		{
			Age retVal;
			if (val.Equals ("18 or less")) {
				retVal = Age.AgeLess18;
			} else if (val.Equals ("19 to 23")) {
				retVal = Age.Age19To23;
			} else if (val.Equals ("24 to 30")) {
				retVal = Age.Age24To30;
			} else if (val.Equals ("31 to 40")) {
				retVal = Age.Age31To40;
			} else if (val.Equals ("41 to 60")) {
				retVal = Age.Age41To60;
			} else if (val.Equals ("61 and above")) {
				retVal = Age.Age61Plus;
			} else {
				retVal = Age.NoAnswer;
			}
			return retVal;
		}

		public Sex SexParser (String val)
		{
			Sex retVal;
			if (val.Equals ("Male")) {
				retVal = Sex.Male;
			} else if (val.Equals ("Female")) {
				retVal = Sex.Female;
			} else {
				retVal = Sex.NoAnswer;
			}
			return retVal;
		}

		public Profession ProfessionParser (String val)
		{
			Profession retVal;
			if (val.Equals ("Student")) {
				retVal = Profession.Student;
			} else if (val.Equals ("Healthcare")) {
				retVal = Profession.Healthcare;
			} else if (val.Equals ("Technology")) {
				retVal = Profession.Technology;
			} else if (val.Equals ("Management")) {
				retVal = Profession.Management;
			} else if (val.Equals ("Office/Clerical")) {
				retVal = Profession.Office;
			} else if (val.Equals ("Other")) {
				retVal = Profession.Other;
			} else if (val.Equals ("Unemployed")) {
				retVal = Profession.Unemployed;
			} else {
				retVal = Profession.NoAnswer;
			}
			return retVal;
		}

		public NumPass NumPassParser (String val)
		{
			NumPass retVal;
			if (val.Equals ("One Commonly Used")) {
				retVal = NumPass.SingleCommon;
			} else if (val.Equals ("Multiple Distinct Used")) {
				retVal = NumPass.MultipleDistinct;
			} else {
				retVal = NumPass.NoAnswer;
			}
			return retVal;
		}

		public SecureLevel SecureLevelParser (String val)
		{
			SecureLevel retVal;
			if (val.Equals ("Poor")) {
				retVal = SecureLevel.Poor;
			} else if (val.Equals ("Fair")) {
				retVal = SecureLevel.Fair;
			} else if (val.Equals ("Good")) {
				retVal = SecureLevel.Good;
			} else if (val.Equals ("Better")) {
				retVal = SecureLevel.Better;
			} else if (val.Equals ("Best")) {
				retVal = SecureLevel.Best;
			} else {
				retVal = SecureLevel.NoAnswer;
			}
			return retVal;
		}

		public SharePersonalInfo SharePersonalInfoParser(String val)
		{
			SharePersonalInfo retVal;
			if (val.Equals ("Yes, both")) {
				retVal = SharePersonalInfo.YesBoth;
			} else if (val.Equals ("Yes, professional only")) {
				retVal = SharePersonalInfo.ProOnly;
			} else if (val.Equals ("Yes, social media only")) {
				retVal = SharePersonalInfo.SocialOnly;
			} else if (val.Equals ("No")) {
				retVal = SharePersonalInfo.No;
			} else {
				retVal = SharePersonalInfo.NoAnswer;
			}
			return retVal;
		}

		public List<Technology> TechnologyListParser (String laptop, String tablet, String desktop, String nSmartphone, String smartphone, String other)
		{
			List<Technology> retVal = new List<Technology> ();
			if (laptop.Equals ("1")) {
				retVal.Add(Technology.Laptop);
			} else if (tablet.Equals ("1")) {
				retVal.Add(Technology.Tablet);
			} else if (desktop.Equals ("1")) {
				retVal.Add(Technology.Desktop);
			} else if (nSmartphone.Equals ("1")) {
				retVal.Add(Technology.NonSmartphone);
			} else if (smartphone.Equals ("1")) {
				retVal.Add(Technology.Smartphone);
			} else if (other.Equals ("1")) {
				retVal.Add(Technology.Other);
			}
			return retVal;
		}

		public List<PassType> PassTypeParser (String common, String alphabetic, String numeric, String symbols, 
		                                      String many, String few, String realWords, String petFamily, 
		                                      String mixUpperLower, String random)
		{
			List<PassType> retVal = new List<PassType>();

			if (common.Equals("1")){
				retVal.Add (PassType.CommonUsedPass);
			} else if (alphabetic.Equals("1")){
				retVal.Add(PassType.Alphabetic);
			} else if (numeric.Equals("1")){
				retVal.Add(PassType.Numeric);
			} else if (symbols.Equals("1")){
				retVal.Add(PassType.SpecialSymbols);
			} else if (many.Equals("1")){
				retVal.Add(PassType.MoreThan8);
			} else if (few.Equals("1")){
				retVal.Add(PassType.LessThan8);
			} else if (realWords.Equals("1")){
				retVal.Add(PassType.RealWords);
			} else if (petFamily.Equals("1")){
				retVal.Add(PassType.PetNames);
			} else if (mixUpperLower.Equals("1")){
				retVal.Add(PassType.UpperLower);
			} else if (random.Equals("1")){
				retVal.Add(PassType.Random);
			}
			return retVal;
		}
	}
}

