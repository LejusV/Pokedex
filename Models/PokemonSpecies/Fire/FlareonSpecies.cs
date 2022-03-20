using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Flareon Species to store common natural stats of all Flareons
	#region FlareonSpecies
	public class FlareonSpecies : PokemonSpecies
	{
#nullable enable
		private static FlareonSpecies? _instance = null;
#nullable restore
        public static FlareonSpecies Instance => _instance ?? (_instance = new FlareonSpecies());

		#region FlareonSpecies Constructor
		public FlareonSpecies() : base(
			136,
			"Flareon",
			Fire.Instance,
			0.9,
			25.0,
			new PokemonStats(
				65, // HPs
				130, 60, // Attack & Defense
				95, 110, // Spacial Attack & Defense
				65 // Speed
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
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Leer",
				"Bite",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Fire-Spin",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Smog",
				"Fire-Blast",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Helping-Hand",
				"Superpower",
				"Secret-Power",
				"Hyper-Voice",
				"Overheat",
				"Covet",
				"Natural-Gift",
				"Last-Resort",
				"Flare-Blitz",
				"Giga-Impact",
				"Fire-Fang",
				"Lava-Plume",
				"Captivate",
				"Flame-Charge",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion
}