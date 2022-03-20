using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Vivillon Species to store common natural stats of all Vivillons
	#region VivillonSpecies
	public class VivillonSpecies : PokemonSpecies
	{
#nullable enable
		private static VivillonSpecies? _instance = null;
#nullable restore
        public static VivillonSpecies Instance => _instance ?? (_instance = new VivillonSpecies());

		#region VivillonSpecies Constructor
		public VivillonSpecies() : base(
			666,
			"Vivillon",
			Bug.Instance, Flying.Instance,
			1.2,
			17.0,
			new PokemonStats(
				80, // HPs
				52, 50, // Attack & Defense
				90, 50, // Spacial Attack & Defense
				89 // Speed
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
				"Gust",
				"Supersonic",
				"Psybeam",
				"Hyper-Beam",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Facade",
				"Endeavor",
				"Secret-Power",
				"Aromatherapy",
				"Signal-Beam",
				"Aerial-Ace",
				"Calm-Mind",
				"Roost",
				"Tailwind",
				"U-Turn",
				"Bug-Buzz",
				"Energy-Ball",
				"Giga-Impact",
				"Bug-Bite",
				"Quiver-Dance",
				"Round",
				"Acrobatics",
				"Struggle-Bug",
				"Electroweb",
				"Hurricane",
				"Draining-Kiss",
				"Confide",
				"Powder",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}