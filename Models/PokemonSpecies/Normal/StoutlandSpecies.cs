using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Stoutland Species to store common natural stats of all Stoutlands
	#region StoutlandSpecies
	public class StoutlandSpecies : PokemonSpecies
	{
#nullable enable
		private static StoutlandSpecies? _instance = null;
#nullable restore
        public static StoutlandSpecies Instance => _instance ?? (_instance = new StoutlandSpecies());

		#region StoutlandSpecies Constructor
		public StoutlandSpecies() : base(
			508,
			"Stoutland",
			Normal.Instance,
			1.2,
			61.0,
			new PokemonStats(
				85, // HPs
				110, 90, // Attack & Defense
				45, 90, // Spacial Attack & Defense
				80 // Speed
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
				"Leer",
				"Bite",
				"Roar",
				"Surf",
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Double-Team",
				"Rest",
				"Substitute",
				"Snore",
				"Reversal",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Shadow-Ball",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Helping-Hand",
				"Superpower",
				"Secret-Power",
				"Hyper-Voice",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Aerial-Ace",
				"Covet",
				"Shock-Wave",
				"Payback",
				"Last-Resort",
				"Giga-Impact",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Iron-Head",
				"After-You",
				"Round",
				"Retaliate",
				"Work-Up",
				"Wild-Charge",
				"Snarl",
				"Play-Rough",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}