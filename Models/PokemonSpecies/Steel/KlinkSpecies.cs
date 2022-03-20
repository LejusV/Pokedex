using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Klink Species to store common natural stats of all Klinks
	#region KlinkSpecies
	public class KlinkSpecies : PokemonSpecies
	{
#nullable enable
		private static KlinkSpecies? _instance = null;
#nullable restore
        public static KlinkSpecies Instance => _instance ?? (_instance = new KlinkSpecies());

		#region KlinkSpecies Constructor
		public KlinkSpecies() : base(
			599,
			"Klink",
			Steel.Instance,
			0.3,
			21.0,
			new PokemonStats(
				40, // HPs
				55, 70, // Attack & Defense
				45, 60, // Spacial Attack & Defense
				30 // Speed
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
				"Vice-Grip",
				"Bind",
				"Hyper-Beam",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Toxic",
				"Screech",
				"Double-Team",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Zap-Cannon",
				"Lock-On",
				"Sandstorm",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Charge",
				"Magic-Coat",
				"Recycle",
				"Secret-Power",
				"Metal-Sound",
				"Signal-Beam",
				"Iron-Defense",
				"Shock-Wave",
				"Gravity",
				"Magnet-Rise",
				"Rock-Polish",
				"Mirror-Shot",
				"Flash-Cannon",
				"Discharge",
				"Charge-Beam",
				"Autotomize",
				"Round",
				"Shift-Gear",
				"Volt-Switch",
				"Wild-Charge",
				"Gear-Grind",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}