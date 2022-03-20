using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Dedenne Species to store common natural stats of all Dedennes
	#region DedenneSpecies
	public class DedenneSpecies : PokemonSpecies
	{
#nullable enable
		private static DedenneSpecies? _instance = null;
#nullable restore
        public static DedenneSpecies Instance => _instance ?? (_instance = new DedenneSpecies());

		#region DedenneSpecies Constructor
		public DedenneSpecies() : base(
			702,
			"Dedenne",
			Electric.Instance, Fairy.Instance,
			0.2,
			2.2,
			new PokemonStats(
				67, // HPs
				58, 57, // Attack & Defense
				81, 67, // Spacial Attack & Defense
				101 // Speed
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
				"Thunder-Punch",
				"Cut",
				"Tackle",
				"Tail-Whip",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Double-Team",
				"Flash",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Facade",
				"Charge",
				"Helping-Hand",
				"Recycle",
				"Secret-Power",
				"Signal-Beam",
				"Aerial-Ace",
				"Covet",
				"Shock-Wave",
				"Natural-Gift",
				"U-Turn",
				"Fling",
				"Last-Resort",
				"Magnet-Rise",
				"Giga-Impact",
				"Discharge",
				"Grass-Knot",
				"Charge-Beam",
				"Entrainment",
				"Round",
				"Retaliate",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Parabolic-Charge",
				"Play-Rough",
				"Confide",
				"Eerie-Impulse",
				"Nuzzle",
				"Tearful-Look"
			};
		}
		#endregion
	}
	#endregion
}