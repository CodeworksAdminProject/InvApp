using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.DirectoryServices;
using System.Windows.Forms;

namespace AppealsOfMarathonBY
{
    class LDAPAuthentication
    {
       
       private String _path = null;
       private String _filterAttribute = null;
       private String _userName;
       private String _pwd;
       private String domain = "MARA.LOCAL";
       private String GroupAD = "mn_admin_CDW";
            


      private void LdapAuthenticationPast(string path, string filtr)
            {
                _path = path;
                _filterAttribute = filtr;               
            }

      private void LdapAuthenticationPast(string pwd, string user, string filtr  )
            {
            _pwd = pwd;
            _userName = user;
            _filterAttribute = filtr;
            }

      public bool IsAuthenticated(String domain, String username, String pwd)
             {
                String domainAndUsername = domain + @"\" + username;
                DirectoryEntry entry = new DirectoryEntry("LDAP://" + domain, username, pwd);

                try
                {
                    Object obj = entry.NativeObject;
                    DirectorySearcher search = new DirectorySearcher(entry);
                
                    search.Filter = "(SAMAccountName=" + username + ")";
                    search.PropertiesToLoad.Add("cn");
                    SearchResult result = search.FindOne();
                              
                    if (null == result)
                        return false;
                
                    LdapAuthenticationPast(result.Path, ((String)result.Properties["cn"][0]));
                    LdapAuthenticationPast(pwd, username, ((String)result.Properties["cn"][0]));
                }

                catch (Exception ex)
                {
                     MessageBox.Show(_path + "путь \n" + _filterAttribute + "фильтр \n");
                     MessageBox.Show("домен" + domain + "\n юзер " + username +"\n пароль" + pwd ); 
                     MessageBox.Show("Error authenticating user. " + ex.Message, "Неверные данные  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                MessageBox.Show(_path + "путь \n" + _filterAttribute + "фильтр \n");
                MessageBox.Show("домен" + domain + "\n юзер " + username + "\n пароль" + pwd);
                return true;
            }
      
      public bool testUserAD(string username, string pwd)
            {
                DirectoryEntry entry = new DirectoryEntry("LDAP://" + domain, username, pwd);
                DirectorySearcher search = new DirectorySearcher(entry);
                search.Filter = "(cn=" + _filterAttribute + ")";
                search.PropertiesToLoad.Add("memberOf");
                StringBuilder groupNames = new StringBuilder();
                string testAD;

                try
                {
                    SearchResult result = search.FindOne();

                    int propertyCount = result.Properties["memberOf"].Count;

                    String dn;
                    int equalsIndex, commaIndex;

                    for (int propertyCounter = 0; propertyCounter < propertyCount; propertyCounter++)
                    {

                        dn = (String)result.Properties["memberOf"][propertyCounter];

                        equalsIndex = dn.IndexOf("=", 1);
                        commaIndex = dn.IndexOf(",", 1);
                        testAD = (dn.Substring((equalsIndex + 1), (commaIndex - equalsIndex) - 1));

                        if (testAD == GroupAD)
                        {
                            return true;
                        }

                        if (-1 == equalsIndex)
                        {
                           return false;
                        }

                        testAD = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error obtaining group names. " + ex.Message);
                
                }
                    return false;
                }

      public bool testUserAD(string UserDomain)
        {
            string filter = string.Format("(&(ObjectClass={0})(sAMAccountName={1}))", "person", UserDomain);
            string[] properties = new string[] { "fullname" };

            DirectoryEntry adRoot = new DirectoryEntry("LDAP://" + domain, null, null, AuthenticationTypes.Secure);
            DirectorySearcher search = new DirectorySearcher(adRoot);
           
            search.Filter = filter;
            search.PropertiesToLoad.Add("memberOf");
            StringBuilder groupNames = new StringBuilder();
            string testAD;

            try
            {
                SearchResult result = search.FindOne();

                int propertyCount = result.Properties["memberOf"].Count;

                String dn;
                int equalsIndex, commaIndex;

                for (int propertyCounter = 0; propertyCounter < propertyCount; propertyCounter++)
                {

                    dn = (String)result.Properties["memberOf"][propertyCounter];

                    equalsIndex = dn.IndexOf("=", 1);
                    commaIndex = dn.IndexOf(",", 1);
                    testAD = (dn.Substring((equalsIndex + 1), (commaIndex - equalsIndex) - 1));

                    if (testAD == GroupAD)
                    {
                        return true;
                    }

                    if (-1 == equalsIndex)
                    {
                        return false;
                    }

                    testAD = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error obtaining group names. " + ex.Message);
            }
            return false;
        }

      public string getUser(string UserDomain)
        {
            string filter = string.Format("(&(ObjectClass={0})(sAMAccountName={1}))", "person", UserDomain);
            string[] properties = new string[] { "fullname" };

            try
            {
                DirectoryEntry adRoot = new DirectoryEntry("LDAP://" + domain, null, null, AuthenticationTypes.Secure);
                DirectorySearcher searcher = new DirectorySearcher(adRoot);
                searcher.SearchScope = SearchScope.Subtree;
                searcher.ReferralChasing = ReferralChasingOption.All;
                searcher.PropertiesToLoad.AddRange(properties);
                searcher.Filter = filter;

                SearchResult result = searcher.FindOne();
                DirectoryEntry directoryEntry = result.GetDirectoryEntry();

                string displayName = directoryEntry.Properties["displayName"][0].ToString();
                return displayName;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error obtaining group names. " + ex.Message);
            }
            return null;
        }

      public string getUser()
        {
            string filter = string.Format("(&(ObjectClass={0})(sAMAccountName={1}))", "person", _userName);
            string[] properties = new string[] { "fullname" };

            try
            {
                DirectoryEntry adRoot = new DirectoryEntry("LDAP://" + domain, _userName,_pwd);
                DirectorySearcher searcher = new DirectorySearcher(adRoot);
                searcher.SearchScope = SearchScope.Subtree;
                searcher.ReferralChasing = ReferralChasingOption.All;
                searcher.PropertiesToLoad.AddRange(properties);
                searcher.Filter = filter;

                SearchResult result = searcher.FindOne();
                DirectoryEntry directoryEntry = result.GetDirectoryEntry();

                string displayName = directoryEntry.Properties["displayName"][0].ToString();
                return displayName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error obtaining group names. " + ex.Message);
            }
            return null;
        }

      public string propertiesTitleUser(string UserDomain)
        {
            string filter = string.Format("(&(ObjectClass={0})(sAMAccountName={1}))", "person", UserDomain);
            string[] properties = new string[] {"title"};

            try
            {
                DirectoryEntry adRoot = new DirectoryEntry("LDAP://" + domain, null, null, AuthenticationTypes.Secure);
                DirectorySearcher searcher = new DirectorySearcher(adRoot);
                searcher.SearchScope = SearchScope.Subtree;
                searcher.ReferralChasing = ReferralChasingOption.All;
                searcher.PropertiesToLoad.AddRange(properties);
                searcher.Filter = filter;

                SearchResult result = searcher.FindOne();
                DirectoryEntry directoryEntry = result.GetDirectoryEntry();

                string TitleUser = directoryEntry.Properties["title"][0].ToString();
                if (TitleUser == "")
                     TitleUser = "НЕ прописано в AD ";

                return TitleUser;
            }
           catch (Exception ex)
            {
               MessageBox.Show("Error obtaining group names. " + ex.Message);
            }
            return null;
        }

      public string propertiesTitleUser()
        {
            string filter = string.Format("(&(ObjectClass={0})(sAMAccountName={1}))", "person", _userName);
            string[] properties = new string[] {"title"};
try { 
            DirectoryEntry adRoot = new DirectoryEntry("LDAP://" + domain, _userName, _pwd);
            DirectorySearcher searcher = new DirectorySearcher(adRoot);
            searcher.SearchScope = SearchScope.Subtree;
            searcher.ReferralChasing = ReferralChasingOption.All;
            searcher.PropertiesToLoad.AddRange(properties);
            searcher.Filter = filter;

            SearchResult result = searcher.FindOne();
            DirectoryEntry directoryEntry = result.GetDirectoryEntry();

                string TitleUser = directoryEntry.Properties["title"][0].ToString();
                if (TitleUser == "")
                    TitleUser = "НЕ прописано в AD ";

                return TitleUser;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error obtaining group names. " + ex.Message);
            }
            return null;
        }

      public string propertiesDepartamentUser(string UserDomain)
        {
            string filter = string.Format("(&(ObjectClass={0})(sAMAccountName={1}))", "person", UserDomain);
            string[] properties = new string[] { "department" };

            try
            {
                DirectoryEntry adRoot = new DirectoryEntry("LDAP://" + domain, null, null, AuthenticationTypes.Secure);
                DirectorySearcher searcher = new DirectorySearcher(adRoot);
                searcher.SearchScope = SearchScope.Subtree;
                searcher.ReferralChasing = ReferralChasingOption.All;
                searcher.PropertiesToLoad.AddRange(properties);
                searcher.Filter = filter;

                SearchResult result = searcher.FindOne();
                DirectoryEntry directoryEntry = result.GetDirectoryEntry();

                string DepartamentUser = directoryEntry.Properties["Department"][0].ToString();
                if (DepartamentUser == "")
                    DepartamentUser = "НЕ прописано в AD ";

                return DepartamentUser;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error obtaining group names. " + ex.Message);
            }
            return null;
        }
        
      public string propertiesDepartamentUser()
        {
            string filter = string.Format("(&(ObjectClass={0})(sAMAccountName={1}))", "person", _userName);
            string[] properties = new string[] { "departament" };
            try
            {
                DirectoryEntry adRoot = new DirectoryEntry("LDAP://" + domain, _userName, _pwd);
                DirectorySearcher searcher = new DirectorySearcher(adRoot);
                searcher.SearchScope = SearchScope.Subtree;
                searcher.ReferralChasing = ReferralChasingOption.All;
                searcher.PropertiesToLoad.AddRange(properties);
                searcher.Filter = filter;

                SearchResult result = searcher.FindOne();
                DirectoryEntry directoryEntry = result.GetDirectoryEntry();

                string DepartamentUser = directoryEntry.Properties["Department"][0].ToString();
                if (DepartamentUser == "")
                    DepartamentUser = "НЕ прописано в AD ";

                return DepartamentUser;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error obtaining group names. " + ex.Message);
            }
            return null;
        }
    } 
    }

