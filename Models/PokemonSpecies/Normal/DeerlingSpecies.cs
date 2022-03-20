using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Deerling Species to store common natural stats of all Deerlings
	#region DeerlingSpecies
	public class DeerlingSpecies : PokemonSpecies
	{
#nullable enable
		private static DeerlingSpecies? _instance = null;
#nullable restore
        public static DeerlingSpecies Instance => _instance ?? (_instance = new DeerlingSpecies());

		#region DeerlingSpecies Constructor
		public DeerlingSpecies() : base(
			585,
			"Deerling",
			Normal.Instance, Grass.Instance,
			0.6,
			19.5,
			new PokemonStats(
				60, // HPs
				60, 50, // Attack & Defense
				40, 50, // Spacial Attack & Defense
				75 // Speed
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
				"Double-Kick",
				"Jump-Kick",
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Leech-Seed",
				"Solar-Beam",
				"Thunder-Wave",
				"Toxic",
				"Agility",
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
				"Baton-Pass",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Facade",
				"Nature-Power",
				"Secret-Power",
				"Camouflage",
				"Aromatherapy",
				"Fake-Tears",
				"Odor-Sleuth",
				"Grass-Whistle",
				"Bounce",
				"Natural-Gift",
				"Last-Resort",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Grass-Knot",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Wild-Charge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}