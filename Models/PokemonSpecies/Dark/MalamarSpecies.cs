using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Malamar Species to store common natural stats of all Malamars
	#region MalamarSpecies
	public class MalamarSpecies : PokemonSpecies
	{
#nullable enable
		private static MalamarSpecies? _instance = null;
#nullable restore
        public static MalamarSpecies Instance => _instance ?? (_instance = new MalamarSpecies());

		#region MalamarSpecies Constructor
		public MalamarSpecies() : base(
			687,
			"Malamar",
			Dark.Instance, Psychic.Instance,
			1.5,
			47.0,
			new PokemonStats(
				86, // HPs
				92, 88, // Attack & Defense
				68, 75, // Spacial Attack & Defense
				73 // Speed
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
				"Hyper-Beam",
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
				"Reversal",
				"Spite",
				"Protect",
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
				"Facade",
				"Taunt",
				"Role-Play",
				"Superpower",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Signal-Beam",
				"Aerial-Ace",
				"Block",
				"Calm-Mind",
				"Pluck",
				"Payback",
				"Embargo",
				"Fling",
				"Dark-Pulse",
				"Night-Slash",
				"Switcheroo",
				"Giga-Impact",
				"Psycho-Cut",
				"Trick-Room",
				"Psyshock",
				"Foul-Play",
				"Round",
				"Retaliate",
				"Topsy-Turvy",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}