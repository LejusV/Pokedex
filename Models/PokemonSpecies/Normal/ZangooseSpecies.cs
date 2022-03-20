using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Zangoose Species to store common natural stats of all Zangooses
	#region ZangooseSpecies
	public class ZangooseSpecies : PokemonSpecies
	{
#nullable enable
		private static ZangooseSpecies? _instance = null;
#nullable restore
        public static ZangooseSpecies Instance => _instance ?? (_instance = new ZangooseSpecies());

		#region ZangooseSpecies Constructor
		public ZangooseSpecies() : base(
			335,
			"Zangoose",
			Normal.Instance,
			1.3,
			40.3,
			new PokemonStats(
				73, // HPs
				115, 60, // Attack & Defense
				60, 60, // Spacial Attack & Defense
				90 // Speed
			)			
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Scratch",
				"Razor-Wind",
				"Swords-Dance",
				"Double-Kick",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Roar",
				"Disable",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Fire-Blast",
				"Swift",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Belly-Drum",
				"Mud-Slap",
				"Icy-Wind",
				"Detect",
				"Giga-Drain",
				"Endure",
				"Rollout",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Pursuit",
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Crush-Claw",
				"Rock-Tomb",
				"Aerial-Ace",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Feint",
				"Close-Combat",
				"Payback",
				"Embargo",
				"Fling",
				"Last-Resort",
				"Poison-Jab",
				"Night-Slash",
				"X-Scissor",
				"Focus-Blast",
				"Shadow-Claw",
				"Rock-Climb",
				"Captivate",
				"Double-Hit",
				"Hone-Claws",
				"Round",
				"Quick-Guard",
				"Incinerate",
				"Retaliate",
				"Final-Gambit",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}