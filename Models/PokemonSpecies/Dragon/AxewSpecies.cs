using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Axew Species to store common natural stats of all Axews
	#region AxewSpecies
	public class AxewSpecies : PokemonSpecies
	{
#nullable enable
		private static AxewSpecies? _instance = null;
#nullable restore
        public static AxewSpecies Instance => _instance ?? (_instance = new AxewSpecies());

		#region AxewSpecies Constructor
		public AxewSpecies() : base(
			610,
			"Axew",
			Dragon.Instance,
			0.6,
			18.0,
			new PokemonStats(
				46, // HPs
				87, 60, // Attack & Defense
				30, 40, // Spacial Attack & Defense
				57 // Speed
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
				"Scratch",
				"Guillotine",
				"Razor-Wind",
				"Swords-Dance",
				"Cut",
				"Leer",
				"Roar",
				"Counter",
				"Strength",
				"Dragon-Rage",
				"Dig",
				"Toxic",
				"Double-Team",
				"Harden",
				"Focus-Energy",
				"Rest",
				"Slash",
				"Substitute",
				"Snore",
				"Reversal",
				"Protect",
				"Scary-Face",
				"Outrage",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Taunt",
				"Superpower",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Dragon-Dance",
				"Shock-Wave",
				"Payback",
				"Assurance",
				"Fling",
				"Poison-Jab",
				"Night-Slash",
				"Aqua-Tail",
				"X-Scissor",
				"Dragon-Pulse",
				"Giga-Impact",
				"Draco-Meteor",
				"Hone-Claws",
				"Round",
				"Incinerate",
				"Dual-Chop",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}