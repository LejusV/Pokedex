using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Bergmite Species to store common natural stats of all Bergmites
	#region BergmiteSpecies
	public class BergmiteSpecies : PokemonSpecies
	{
#nullable enable
		private static BergmiteSpecies? _instance = null;
#nullable restore
        public static BergmiteSpecies Instance => _instance ?? (_instance = new BergmiteSpecies());

		#region BergmiteSpecies Constructor
		public BergmiteSpecies() : base(
			712,
			"Bergmite",
			Ice.Instance,
			1.0,
			99.5,
			new PokemonStats(
				55, // HPs
				69, 85, // Attack & Defense
				32, 35, // Spacial Attack & Defense
				28 // Speed
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
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Bite",
				"Mist",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Strength",
				"Toxic",
				"Double-Team",
				"Recover",
				"Harden",
				"Barrier",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Sharpen",
				"Substitute",
				"Snore",
				"Curse",
				"Powder-Snow",
				"Protect",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Rapid-Spin",
				"Hidden-Power",
				"Rain-Dance",
				"Mirror-Coat",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Secret-Power",
				"Ice-Ball",
				"Rock-Tomb",
				"Iron-Defense",
				"Water-Pulse",
				"Gyro-Ball",
				"Rock-Polish",
				"Avalanche",
				"Ice-Fang",
				"Flash-Cannon",
				"Stone-Edge",
				"After-You",
				"Round",
				"Frost-Breath",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}