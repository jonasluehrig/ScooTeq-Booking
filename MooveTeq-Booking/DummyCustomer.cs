using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest {
    class DummyCustomer {
        private static string _firstnames = @"Liam
Noah
Oliver
Elijah
William
James
Benjamin
Lucas
Henry
Alexander
Mason
Michael
Ethan
Daniel
Jacob
Logan
Jackson
Levi
Sebastian
Mateo
Jack
Owen
Theodore
Aiden
Samuel
Joseph
John
David
Wyatt
Matthew
Luke
Asher
Carter
Julian
Grayson
Leo
Jayden
Gabriel
Isaac
Lincoln
Anthony
Hudson
Dylan
Ezra
Thomas
Charles
Christopher
Jaxon
Maverick
Josiah
Isaiah
Andrew
Elias
Joshua
Nathan
Caleb
Ryan
Adrian
Miles
Eli
Nolan
Christian
Aaron
Cameron
Ezekiel
Colton
Luca
Landon
Hunter
Jonathan
Santiago
Axel
Easton
Cooper
Jeremiah
Angel
Roman
Connor
Jameson
Robert
Greyson
Jordan
Ian
Carson
Jaxson
Leonardo
Nicholas
Dominic
Austin
Everett
Brooks
Xavier
Kai
Jose
Parker
Adam
Jace
Wesley
Kayden
Silas";

        public static DataTypes.Customer GetRandomDummy(Random rnd = null) {
            var stringArray = _firstnames.Split('\n');
            var chosenFirstname = stringArray[
                (rnd ?? new Random()).Next(0,stringArray.Length-1)
            ];

            return new DataTypes.Customer() {
                UserName = chosenFirstname.ToLower().Substring(0,3) + "_dummy",
                FirstName = chosenFirstname,
                LastName = "Dummyuser",
                PasswordHash = string.Empty,
                IsAdmin = false
            };
        }
    }
}
