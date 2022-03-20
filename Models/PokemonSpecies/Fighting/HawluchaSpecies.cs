using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Hawlucha Species to store common natural stats of all Hawluchas
	#region HawluchaSpecies
	public class HawluchaSpecies : PokemonSpecies
	{
#nullable enable
		private static HawluchaSpecies? _instance = null;
#nullable restore
        public static HawluchaSpecies Instance => _instance ?? (_instance = new HawluchaSpecies());

		#region HawluchaSpecies Constructor
		public HawluchaSpecies() : base(
			701,
			"Hawlucha",
			Fighting.Instance, Flying.Instance,
			0.8,
			21.5,
			new PokemonStats(
				78, // HPs
				92, 75, // Attack & Defense
				74, 63, // Spacial Attack & Defense
				118 // Speed
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
				"Karate-Chop",
				"Fire-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Wing-Attack",
				"Fly",
				"Tackle",
				"Low-Kick",
				"Strength",
				"Dig",
				"Toxic",
				"Agility",
				"Double-Team",
				"High-Jump-Kick",
				"Sky-Attack",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Detect",
				"False-Swipe",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Encore",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Feather-Dance",
				"Mud-Sport",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bulk-Up",
				"Bounce",
				"Roost",
				"Feint",
				"Tailwind",
				"U-Turn",
				"Payback",
				"Fling",
				"Me-First",
				"Last-Resort",
				"Poison-Jab",
				"X-Scissor",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Zen-Headbutt",
				"Iron-Head",
				"Stone-Edge",
				"Grass-Knot",
				"Hone-Claws",
				"Low-Sweep",
				"Entrainment",
				"Round",
				"Quick-Guard",
				"Ally-Switch",
				"Sky-Drop",
				"Acrobatics",
				"Retaliate",
				"Work-Up",
				"Dual-Chop",
				"Flying-Press",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}