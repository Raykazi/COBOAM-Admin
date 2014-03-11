namespace COBOAM_Admin
{
    abstract class Queries
    {
        public static string ToString(QueryIndex queryIndex)
        {
            switch (queryIndex)
            {
                case QueryIndex.Login1:
                    return "SELECT COUNT(*) FROM `login` WHERE `Username` = '{0}' AND `Password2` = '{1}';";
                case QueryIndex.Login2:
                    return "SELECT * FROM `login` WHERE `Username` = '{0}' AND `Password2` = '{1}';";
                case QueryIndex.Devotion1:
                    return "SELECT * FROM `devotion` ORDER BY `ID` DESC;";
                case QueryIndex.Logs1:
                    return "SELECT * FROM coboam.log ORDER BY `ID` DESC";
                case QueryIndex.Logs2:
                    return "SELECT * FROM `log` WHERE `Type`='{0}' ORDER BY `ID` DESC";
                case QueryIndex.Logs3:
                    return "INSERT INTO `log`(`Type`,`Date`,`IP`,`Msg`) VALUES('{0}','{1}','{2}','{3}');";
                case QueryIndex.Devotion2:
                    return "INSERT INTO `devotion` (`Month`,`Year`,`Quote`,`Scripture`,`Text`) VALUES('{0}','{1}','{2}','{3}','{4}');";
                case QueryIndex.Devotion3:
                    return "UPDATE `devotion` SET `Quote`='{1}', `Scripture`='{2}', `Text`='{3}', `Month`='{4}', `Year`='{5}' WHERE `ID` = '{0}'";
                    case QueryIndex.Devotion4:
                    return "DELETE FROM `devotion` WHERE `Month`='{0}' AND `Year`='{1}'";
            }
            return "";
        }
    }

    public enum QueryIndex
    {
        Login1,
        Login2,
        Logs1,
        Logs2,
        Logs3,
        Devotion1,
        Devotion2,
        Devotion3,
        Devotion4
    }
}
