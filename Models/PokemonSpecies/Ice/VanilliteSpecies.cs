using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Vanillite Species to store common natural stats of all Vanillites
	#region VanilliteSpecies
	public class VanilliteSpecies : PokemonSpecies
	{
#nullable enable
		private static VanilliteSpecies? _instance = null;
#nullable restore
        public static VanilliteSpecies Instance => _instance ?? (_instance = new VanilliteSpecies());

		#region VanilliteSpecies Constructor
		public VanilliteSpecies() : base(
			582,
			"Vanillite",
			Ice.Instance,
			0.4,
			5.7,
			new PokemonStats(
				36, // HPs
				50, 50, // Attack & Defense
				65, 60, // Spacial Attack & Defense
				44 // Speed
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
				"Toxic",
				"Double-Team",
				"Harden",
				"Light-Screen",
				"Acid-Armor",
				"Explosion",
				"Rest",
				"Substitute",
				"Snore",
				"Powder-Snow",
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
				"Imprison",
				"Secret-Power",
				"Astonish",
				"Signal-Beam",
				"Sheer-Cold",
				"Icicle-Spear",
				"Iron-Defense",
				"Water-Pulse",
				"Natural-Gift",
				"Magnet-Rise",
				"Avalanche",
				"Ice-Shard",
				"Mirror-Shot",
				"Flash-Cannon",
				"Autotomize",
				"Round",
				"Frost-Breath",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}