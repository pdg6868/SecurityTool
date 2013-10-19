using System;
using System.Collections.Generic;

namespace SecurityAnalysisTool
{
	public class Result
	{
		public Result (Age a, Sex s, Profession p, Education e, YesNo cit, 
		               List<Technology> tech, Frequency pub, Frequency home,
		               NumPass single, List<PassType> passType, Frequency pChange,
		               YesNo sharePass,YesNo pSecure, YesNo passHome,YesNo pMobile, 
		               YesNo hWifiPass, YesNo hWifiFire, YesNo hVirusSoftware, YesNo softUpdate, 
		               SecureLevel sLevel, SharePersonalInfo postPersonal, Frequency pWifi)
		{
			m_age = a;
			m_sex = s;
			m_profession = p;
			m_education = e;
			m_usCitizen = cit;
			m_technologyList = tech;
			m_publicComputer = pub;
			m_homeComputer = home;
			m_singlePass = single;
			m_passType = passType;
			m_passChangeFreq = pChange;
			m_sharePassword = sharePass;
			m_passSecure = pSecure;
			m_passHomePC = passHome;
			m_passForMobile = pMobile;
			m_homeWifiPass = hWifiPass;
			m_homeWifiFirewall = hWifiFire;
			m_homeVirusSoftware = hVirusSoftware;
			m_softwareUpdates = softUpdate;
			m_securityLevel = sLevel;
			m_postPersonalInfo = postPersonal;
			m_publicWifi = pWifi;
		}

		public Age age {
			get {
				return m_age;
			}
		}

		public Sex sex {
			get {
				return m_sex;
			}
		}

		public Profession profession {
			get {
				return m_profession;
			}
		}

		public Education education {
			get {
				return m_education;
			}
		}

		public YesNo usCitizen {
			get {
				return m_usCitizen;
			}
		}

		public List<Technology> technologyList {
			get {
				return m_technologyList;
			}
		}

		public Frequency publicComputer {
			get {
				return m_publicComputer;
			}
		}

		public Frequency homeComputer {
			get {
				return m_homeComputer;
			}
		}

		public NumPass singlePass {
			get {
				return m_singlePass;
			}
		}

		public List<PassType> passType {
			get {
				return m_passType;
			}
		}

		public Frequency passChangeFreq {
			get {
				return m_passChangeFreq;
			}
		}

		public YesNo sharePassword {
			get {
				return m_sharePassword;
			}
		}

		public YesNo passSecure {
			get {
				return m_passSecure;
			}
		}

		public YesNo passHomePC {
			get {
				return m_passHomePC;
			}
		}

		public YesNo passForMobile {
			get {
				return m_passForMobile;
			}
		}

		public YesNo homeWifiPass {
			get {
				return m_homeWifiPass;
			}
		}

		public YesNo homeWifiFirewall {
			get {
				return m_homeWifiFirewall;
			}
		}

		public YesNo homeVirusSoftware {
			get {
				return m_homeVirusSoftware;
			}
		}

		public YesNo softwareUpdates {
			get {
				return m_softwareUpdates;
			}
		}

		public SecureLevel securityLevel {
			get {
				return m_securityLevel;
			}
		}

		public SharePersonalInfo postPersonalInfo {
			get {
				return m_postPersonalInfo;
			}
		}

		public Frequency publicWifi {
			get {
				return m_publicWifi;
			}
		}

		private Age m_age;
		private Sex m_sex;
		private Profession m_profession;
		private Education m_education;
		private YesNo m_usCitizen;
		private List<Technology> m_technologyList;
		private Frequency m_publicComputer;
		private Frequency m_homeComputer;
		private NumPass m_singlePass;
		private List<PassType> m_passType;
		private Frequency m_passChangeFreq;
		private YesNo m_sharePassword;
		private YesNo m_passSecure;
		private YesNo m_passHomePC;
		private YesNo m_passForMobile;
		private YesNo m_homeWifiPass;
		private YesNo m_homeWifiFirewall;
		private YesNo m_homeVirusSoftware;
		private YesNo m_softwareUpdates;
		private SecureLevel m_securityLevel;
		private SharePersonalInfo m_postPersonalInfo;
		private Frequency m_publicWifi;
	}
}

