using InfinityScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfinityScript;
using System.Threading;

namespace ClanWarSystem
{
    public class ClanWarSystem : BaseScript
    {
        public override EventEat OnSay3(Entity player, ChatType type, string name, ref string message)
        {
            if (player.GetField<string>("sessionteam") == "axis") // EE
            {
                var changed = "";
                changed +="^3" + player.Name;
                // ^9[^0E^1E^9] " +

                player.Name.Replace(player.Name, changed);          
            }

            if (player.GetField<string>("sessionteam") == "allies") // i7
            {
                var changed = "";
                changed += "^9[^5i7^9] " + "^5" + player.Name + "^0: ^5";

                player.Name.Replace(player.Name, changed);
            }





            if (message.StartsWith("!"))
            {
                try
                {
                    string[] Array = message.Split(new char[]
                   {
                        ' '
                   });

                    string Textmsg;
                    switch (Textmsg = message.Split(new char[]
                        {
                            ' '
                        })[0].ToLower().Remove(0, 1))
                    {
                        case "random":
                            List<string> MapList = new List<string>();
                            MapList.Add("Seatown");
                            MapList.Add("Dome");
                            MapList.Add("Arkaden");
                            MapList.Add("Resistance");
                            MapList.Add("Downturn");
                            MapList.Add("Bootleg");
                            MapList.Add("Carbon");
                            MapList.Add("Hardhat");
                            MapList.Add("Lockdown");
                            MapList.Add("Fallen");
                            MapList.Add("Interchange");
                            MapList.Add("Underground");
                            MapList.Add("Mission");
                            Random randNum = new Random();
                            int aRandomPos = randNum.Next(MapList.Count - 1);

                            string RandomMap = MapList[aRandomPos];
                            if(RandomMap.Equals("Seatown"))
                            {
                                Utilities.RawSayAll("^9[^5CW^9] ^2 Random map will be^0: ^3Seatown");
                                Utilities.RawSayAll("^2Changing in ^13 ^2seconds.");
                                Thread.Sleep(3000);
                                Utilities.ExecuteCommand("map mp_seatown");
                            }
                            if (RandomMap.Equals("Dome"))
                            {
                                Utilities.RawSayAll("^9[^5CW^9] ^2 Random map will be^0: ^3Dome");
                                Utilities.RawSayAll("^2Changing in ^13 ^2seconds.");
                                Thread.Sleep(3000);
                                Utilities.ExecuteCommand("map mp_dome");
                            }
                            if (RandomMap.Equals("Arkaden"))
                            {
                                Utilities.RawSayAll("^9[^5CW^9] ^2 Random map will be^0: ^3Arkaden");
                                Utilities.RawSayAll("^2Changing in ^13 ^2seconds.");
                                Thread.Sleep(3000);
                                Utilities.ExecuteCommand("map mp_plaza2");
                            }
                            if (RandomMap.Equals("Resistance"))
                            {
                                Utilities.RawSayAll("^9[^5CW^9] ^2 Random map will be^0: ^3Resistance");
                                Utilities.RawSayAll("^2Changing in ^13 ^2seconds.");
                                Thread.Sleep(3000);
                                Utilities.ExecuteCommand("map mp_paris");
                            }
                            if (RandomMap.Equals("Downturn"))
                            {
                                Utilities.RawSayAll("^9[^5CW^9] ^2 Random map will be^0: ^3Downturn");
                                Utilities.RawSayAll("^2Changing in ^13 ^2seconds.");
                                Thread.Sleep(3000);
                                Utilities.ExecuteCommand("map mp_exchange");
                            }
                            if (RandomMap.Equals("Bootleg"))
                            {
                                Utilities.RawSayAll("^9[^5CW^9] ^2 Random map will be^0: ^3Bootleg");
                                Utilities.RawSayAll("^2Changing in ^13 ^2seconds.");
                                Thread.Sleep(3000);
                                Utilities.ExecuteCommand("map mp_bootleg");
                            }
                            if (RandomMap.Equals("Carbon"))
                            {
                                Utilities.RawSayAll("^9[^5CW^9] ^2 Random map will be^0: ^3Carbon");
                                Utilities.RawSayAll("^2Changing in ^13 ^2seconds.");
                                Thread.Sleep(3000);
                                Utilities.ExecuteCommand("map mp_carbon");
                            }
                            if (RandomMap.Equals("Hardhat"))
                            {
                                Utilities.RawSayAll("^9[^5CW^9] ^2 Random map will be^0: ^3Hardhat");
                                Utilities.RawSayAll("^2Changing in ^13 ^2seconds.");
                                Thread.Sleep(3000);
                                Utilities.ExecuteCommand("map mp_hardhat");
                            }
                            if (RandomMap.Equals("Lockdown"))
                            {
                                Utilities.RawSayAll("^9[^5CW^9] ^2 Random map will be^0: ^3Lockdown");
                                Utilities.RawSayAll("^2Changing in ^13 ^2seconds.");
                                Thread.Sleep(3000);
                                Utilities.ExecuteCommand("map mp_alpha");
                            }
                            if (RandomMap.Equals("Fallen"))
                            {
                                Utilities.RawSayAll("^9[^5CW^9] ^2 Random map will be^0: ^3Fallen");
                                Utilities.RawSayAll("^2Changing in ^13 ^2seconds.");
                                Thread.Sleep(3000);
                                Utilities.ExecuteCommand("map mp_lambeth");
                            }
                            if (RandomMap.Equals("Interchange"))
                            {
                                Utilities.RawSayAll("^9[^5CW^9] ^2 Random map will be^0: ^3Interchange");
                                Utilities.RawSayAll("^2Changing in ^13 ^2seconds.");
                                Thread.Sleep(3000);
                                Utilities.ExecuteCommand("map mp_interchange");
                            }
                            if (RandomMap.Equals("Underground"))
                            {
                                Utilities.RawSayAll("^9[^5CW^9] ^2 Random map will be^0: ^3Underground");
                                Utilities.RawSayAll("^2Changing in ^13 ^2seconds.");
                                Thread.Sleep(3000);
                                Utilities.ExecuteCommand("map mp_underground");
                            }
                            if (RandomMap.Equals("Mission"))
                            {
                                Utilities.RawSayAll("^9[^5CW^9] ^2 Random map will be^0: ^3Mission");
                                Utilities.RawSayAll("^2Changing in ^13 ^2seconds.");
                                Thread.Sleep(3000);
                                Utilities.ExecuteCommand("map mp_bravo");
                            }

                            break;
                    }
                }
                catch(Exception ex)
                {
                    Utilities.RawSayAll(ex.Message);
                }
            }
            return base.OnSay3(player, type, name, ref message);
        }
    }
}
