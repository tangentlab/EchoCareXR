namespace ECHO
{
	public class UserInfo
	{
		public string userID = "default_user";
		public string userName = "Default User";

		public UserInfo(string name = "Default User", string id = "default_user")
		{
			userName = name;
			userID = id;

			// Constructor logic can be added here if needed
		}
	}
}