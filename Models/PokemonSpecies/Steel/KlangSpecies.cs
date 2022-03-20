using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Klang Species to store common natural stats of all Klangs
	#region KlangSpecies
	public class KlangSpecies : PokemonSpecies
	{
#nullable enable
		private static KlangSpecies? _instance = null;
#nullable restore
        public static KlangSpecies Instance => _instance ?? (_instance = new KlangSpecies());

		#region KlangSpecies Constructor
		public KlangSpecies() : base(
			600,
			"Klang",
			Steel.Instance,
			0.6,
			51.0,
			new PokemonStats(
				60, // HPs
				80, 95, // Attack & Defense
				70, 85, // Spacial Attack & Defense
				50 // Speed
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