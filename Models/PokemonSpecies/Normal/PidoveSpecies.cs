using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Pidove Species to store common natural stats of all Pidoves
	#region PidoveSpecies
	public class PidoveSpecies : PokemonSpecies
	{
#nullable enable
		private static PidoveSpecies? _instance = null;
#nullable restore
        public static PidoveSpecies Instance => _instance ?? (_instance = new PidoveSpecies());

		#region PidoveSpecies Constructor
		public PidoveSpecies() : base(
			519,
			"Pidove",
			Normal.Instance, Flying.Instance,
			0.3,
			2.1,
			new PokemonStats(
				50, // HPs
				55, 50, // Attack & Defense
				36, 30, // Spacial Attack & Defense
				43 // Speed
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
				"Razor-Wind",
				"Gust",
				"Fly",
				"Leer",
				"Growl",
				"Toxic",
				"Hypnosis",
				"Quick-Attack",
				"Double-Team",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Detect",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Morning-Sun",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Uproar",
				"Heat-Wave",
				"Facade",
				"Taunt",
				"Wish",
				"Secret-Power",
				"Feather-Dance",
				"Air-Cutter",
				"Aerial-Ace",
				"Roost",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Lucky-Chant",
				"Night-Slash",
				"Air-Slash",
				"Round",
				"Echoed-Voice",
				"Bestow",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}