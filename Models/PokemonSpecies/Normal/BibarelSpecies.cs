using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Bibarel Species to store common natural stats of all Bibarels
	#region BibarelSpecies
	public class BibarelSpecies : PokemonSpecies
	{
#nullable enable
		private static BibarelSpecies? _instance = null;
#nullable restore
        public static BibarelSpecies Instance => _instance ?? (_instance = new BibarelSpecies());

		#region BibarelSpecies Constructor
		public BibarelSpecies() : base(
			400,
			"Bibarel",
			Normal.Instance, Water.Instance,
			1.0,
			31.5,
			new PokemonStats(
				79, // HPs
				85, 60, // Attack & Defense
				55, 60, // Spacial Attack & Defense
				71 // Speed
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
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Growl",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Double-Team",
				"Defense-Curl",
				"Waterfall",
				"Swift",
				"Amnesia",
				"Rest",
				"Hyper-Fang",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Superpower",
				"Yawn",
				"Secret-Power",
				"Dive",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Pluck",
				"Fling",
				"Last-Resort",
				"Aqua-Tail",
				"Giga-Impact",
				"Rock-Climb",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Aqua-Jet",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Rototiller",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}