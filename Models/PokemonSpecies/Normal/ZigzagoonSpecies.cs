using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Zigzagoon Species to store common natural stats of all Zigzagoons
	#region ZigzagoonSpecies
	public class ZigzagoonSpecies : PokemonSpecies
	{
#nullable enable
		private static ZigzagoonSpecies? _instance = null;
#nullable restore
        public static ZigzagoonSpecies Instance => _instance ?? (_instance = new ZigzagoonSpecies());

		#region ZigzagoonSpecies Constructor
		public ZigzagoonSpecies() : base(
			263,
			"Zigzagoon",
			Normal.Instance,
			0.4,
			17.5,
			new PokemonStats(
				38, // HPs
				30, 41, // Attack & Defense
				30, 41, // Spacial Attack & Defense
				60 // Speed
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
				"Cut",
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Pin-Missile",
				"Growl",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Swift",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Flail",
				"Protect",
				"Belly-Drum",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Extreme-Speed",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Secret-Power",
				"Mud-Sport",
				"Hyper-Voice",
				"Odor-Sleuth",
				"Tickle",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Last-Resort",
				"Seed-Bomb",
				"Rock-Climb",
				"Gunk-Shot",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Hone-Claws",
				"Simple-Beam",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Bestow",
				"Work-Up",
				"Confide",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion
}