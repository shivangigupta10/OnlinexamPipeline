Denial of service

abc ReadLine(a
abc ReadToEnd(
-----------------------------------------------
Cross site Scripting

Response.Write(abc) //D
Response.Write("abc", ) //ND
Response.WriteFile(abc) //D
Response.WriteFile("abc", ) //ND
Response.WriteFile("abc",abc)  //new rule after comma something should be there.
Response.Output.Write(0) //D
Response.Output.Write("dfy", //ND
Response.Output.WriteLine() //ND as in blacklist
Response.Output.WriteLine("dfy",  //ND
Response.Write( //ND
-------------------------------------------------------
Cross Site Scripting PFP

//Response.Write(abc) //D
//Response.Write("abc", ) //ND
//Response.WriteFile(abc) //D
//Response.WriteFile("abc", ) //ND
//Response.WriteFile("abc",abc)  //new rule after comma something should be there.
//Response.Output.Write(0) //D
//Response.Output.Write("dfy", //ND
//Response.Output.WriteLine() //ND as in blacklist
//Response.Output.WriteLine("dfy",  //ND
//Response.Write( //ND