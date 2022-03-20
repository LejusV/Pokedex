using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Klinklang Species to store common natural stats of all Klinklangs
	#region KlinklangSpecies
	public class KlinklangSpecies : PokemonSpecies
	{
#nullable enable
		private static KlinklangSpecies? _instance = null;
#nullable restore
        public static KlinklangSpecies Instance => _instance ?? (_instance = new KlinklangSpecies());

		#region KlinklangSpecies Constructor
		public KlinklangSpecies() : base(
			601,
			"Klinklang",
			Steel.Instance,
			0.6,
			81.0,
			new PokemonStats(
				60, // HPs
				100, 115, // Attack & Defense
				70, 85, // Spacial Attack & Defense
				90 // Speed
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
				"Thunder",
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
				"Giga-Impact",
				"Mirror-Shot",
				"Flash-Cannon",
				"Trick-Room",
				"Discharge",
				"Charge-Beam",
				"Autotomize",
				"Round",
				"Shift-Gear",
				"Volt-Switch",
				"Wild-Charge",
				"Gear-Grind",
				"Confide",
				"Magnetic-Flux",
				"Gear-Up"
			};
		}
		#endregion
	}
	#endregion
}