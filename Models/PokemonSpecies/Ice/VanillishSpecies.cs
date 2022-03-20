using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Vanillish Species to store common natural stats of all Vanillishs
	#region VanillishSpecies
	public class VanillishSpecies : PokemonSpecies
	{
#nullable enable
		private static VanillishSpecies? _instance = null;
#nullable restore
        public static VanillishSpecies Instance => _instance ?? (_instance = new VanillishSpecies());

		#region VanillishSpecies Constructor
		public VanillishSpecies() : base(
			583,
			"Vanillish",
			Ice.Instance,
			1.1,
			41.0,
			new PokemonStats(
				51, // HPs
				65, 65, // Attack & Defense
				80, 75, // Spacial Attack & Defense
				59 // Speed
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
				"Signal-Beam",
				"Sheer-Cold",
				"Icicle-Spear",
				"Iron-Defense",
				"Water-Pulse",
				"Magnet-Rise",
				"Avalanche",
				"Mirror-Shot",
				"Flash-Cannon",
				"Round",
				"Frost-Breath",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}