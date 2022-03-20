using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Vanilluxe Species to store common natural stats of all Vanilluxes
	#region VanilluxeSpecies
	public class VanilluxeSpecies : PokemonSpecies
	{
#nullable enable
		private static VanilluxeSpecies? _instance = null;
#nullable restore
        public static VanilluxeSpecies Instance => _instance ?? (_instance = new VanilluxeSpecies());

		#region VanilluxeSpecies Constructor
		public VanilluxeSpecies() : base(
			584,
			"Vanilluxe",
			Ice.Instance,
			1.3,
			57.5,
			new PokemonStats(
				71, // HPs
				95, 85, // Attack & Defense
				110, 95, // Spacial Attack & Defense
				79 // Speed
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
				"Mist",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Toxic",
				"Double-Team",
				"Harden",
				"Light-Screen",
				"Acid-Armor",
				"Explosion",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Mirror-Coat",
				"Uproar",
				"Hail",
				"Facade",
				"Taunt",
				"Magic-Coat",
				"Secret-Power",
				"Astonish",
				"Weather-Ball",
				"Signal-Beam",
				"Sheer-Cold",
				"Icicle-Spear",
				"Iron-Defense",
				"Water-Pulse",
				"Magnet-Rise",
				"Giga-Impact",
				"Avalanche",
				"Mirror-Shot",
				"Flash-Cannon",
				"Round",
				"Frost-Breath",
				"Freeze-Dry",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}