using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Magby Species to store common natural stats of all Magbys
	#region MagbySpecies
	public class MagbySpecies : PokemonSpecies
	{
#nullable enable
		private static MagbySpecies? _instance = null;
#nullable restore
        public static MagbySpecies Instance => _instance ?? (_instance = new MagbySpecies());

		#region MagbySpecies Constructor
		public MagbySpecies() : base(
			240,
			"Magby",
			Fire.Instance,
			0.7,
			21.4,
			new PokemonStats(
				45, // HPs
				75, 37, // Attack & Defense
				70, 55, // Spacial Attack & Defense
				83 // Speed
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
				"Karate-Chop",
				"Mega-Punch",
				"Fire-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Ember",
				"Flamethrower",
				"Counter",
				"Seismic-Toss",
				"Fire-Spin",
				"Toxic",
				"Psychic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Smokescreen",
				"Confuse-Ray",
				"Barrier",
				"Focus-Energy",
				"Smog",
				"Fire-Blast",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mach-Punch",
				"Feint-Attack",
				"Belly-Drum",
				"Mud-Slap",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Cross-Chop",
				"Sunny-Day",
				"Rock-Smash",
				"Uproar",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Brick-Break",
				"Secret-Power",
				"Overheat",
				"Covet",
				"Natural-Gift",
				"Fling",
				"Power-Swap",
				"Flare-Blitz",
				"Lava-Plume",
				"Captivate",
				"Flame-Burst",
				"Flame-Charge",
				"Round",
				"Clear-Smog",
				"Incinerate",
				"Dual-Chop",
				"Belch",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}