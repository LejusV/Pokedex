using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Inkay Species to store common natural stats of all Inkays
	#region InkaySpecies
	public class InkaySpecies : PokemonSpecies
	{
#nullable enable
		private static InkaySpecies? _instance = null;
#nullable restore
        public static InkaySpecies Instance => _instance ?? (_instance = new InkaySpecies());

		#region InkaySpecies Constructor
		public InkaySpecies() : base(
			686,
			"Inkay",
			Dark.Instance, Psychic.Instance,
			0.4,
			3.5,
			new PokemonStats(
				53, // HPs
				54, 53, // Attack & Defense
				37, 46, // Spacial Attack & Defense
				45 // Speed
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
				"Bind",
				"Tackle",
				"Flamethrower",
				"Psybeam",
				"Peck",
				"Thunderbolt",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Constrict",
				"Flash",
				"Psywave",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Destiny-Bond",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Torment",
				"Flatter",
				"Facade",
				"Taunt",
				"Role-Play",
				"Superpower",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Camouflage",
				"Aerial-Ace",
				"Calm-Mind",
				"Pluck",
				"Payback",
				"Embargo",
				"Fling",
				"Guard-Swap",
				"Dark-Pulse",
				"Night-Slash",
				"Switcheroo",
				"Psycho-Cut",
				"Trick-Room",
				"Power-Split",
				"Foul-Play",
				"Simple-Beam",
				"Round",
				"Retaliate",
				"Topsy-Turvy",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}