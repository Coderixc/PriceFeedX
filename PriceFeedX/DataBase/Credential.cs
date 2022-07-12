using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataBase
{
    class Credential
    {

        public static string mHost = @"127.0.0.1";
        public static string mUser = @"root";
        public static string mPassword = @"123456";
        public static string mSchema = @"pricedata";

        public const string mTable = @"pricedataprev";

        public const string mTable_BhavCopyPrice = @"bhavcopyprice";

    }
}

/*

 * CREATE TABLE `pricedataprev` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Class` varchar(45) DEFAULT '-1',
  `Symbol` varchar(45) NOT NULL,
  `Ltp` double DEFAULT '-1',
  `prev1` double DEFAULT '-1',
  `prev2` double DEFAULT '-1',
  `prev3` double DEFAULT '-1',
  `prev4` double DEFAULT '-1',
  `prev5` double DEFAULT '-1',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

 
 */
