using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Galvantula Species to store common natural stats of all Galvantulas
	#region GalvantulaSpecies
	public class GalvantulaSpecies : PokemonSpecies
	{
#nullable enable
		private static GalvantulaSpecies? _instance = null;
#nullable restore
        public static GalvantulaSpecies Instance => _instance ?? (_instance = new GalvantulaSpecies());

		#region GalvantulaSpecies Constructor
		public GalvantulaSpecies() : base(
			596,
			"Galvantula",
			Bug.Instance, Electric.Instance,
			0.8,
			14.3,
			new PokemonStats(
				70, // HPs
				77, 60, // Attack & Defense
				97, 60, // Spacial Attack & Defense
				108 // Speed
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
				"Cut",
				"Hyper-Beam",
				"Absorb",
				"String-Shot",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Agility",
				"Screech",
				"Double-Team",
				"Light-Screen",
				"Leech-Life",
				"Flash",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Spider-Web",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Facade",
				"Secret-Power",
				"Signal-Beam",
				"Bounce",
				"Shock-Wave",
				"Gastro-Acid",
				"Sucker-Punch",
				"Magnet-Rise",
				"Poison-Jab",
				"X-Scissor",
				"Bug-Buzz",
				"Energy-Ball",
				"Giga-Impact",
				"Discharge",
				"Bug-Bite",
				"Charge-Beam",
				"Electro-Ball",
				"Round",
				"Volt-Switch",
				"Struggle-Bug",
				"Electroweb",
				"Wild-Charge",
				"Sticky-Web",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}