using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Sawsbuck Species to store common natural stats of all Sawsbucks
	#region SawsbuckSpecies
	public class SawsbuckSpecies : PokemonSpecies
	{
#nullable enable
		private static SawsbuckSpecies? _instance = null;
#nullable restore
        public static SawsbuckSpecies Instance => _instance ?? (_instance = new SawsbuckSpecies());

		#region SawsbuckSpecies Constructor
		public SawsbuckSpecies() : base(
			586,
			"Sawsbuck",
			Normal.Instance, Grass.Instance,
			1.9,
			92.5,
			new PokemonStats(
				80, // HPs
				100, 70, // Attack & Defense
				60, 70, // Spacial Attack & Defense
				95 // Speed
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
				"Double-Kick",
				"Jump-Kick",
				"Sand-Attack",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Hyper-Beam",
				"Leech-Seed",
				"Solar-Beam",
				"Thunder-Wave",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Giga-Drain",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Megahorn",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Secret-Power",
				"Camouflage",
				"Aromatherapy",
				"Bounce",
				"Last-Resort",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Grass-Knot",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Wild-Charge",
				"Horn-Leech",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}