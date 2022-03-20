using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Noibat Species to store common natural stats of all Noibats
	#region NoibatSpecies
	public class NoibatSpecies : PokemonSpecies
	{
#nullable enable
		private static NoibatSpecies? _instance = null;
#nullable restore
        public static NoibatSpecies Instance => _instance ?? (_instance = new NoibatSpecies());

		#region NoibatSpecies Constructor
		public NoibatSpecies() : base(
			714,
			"Noibat",
			Flying.Instance, Dragon.Instance,
			0.5,
			8.0,
			new PokemonStats(
				40, // HPs
				30, 35, // Attack & Defense
				45, 40, // Spacial Attack & Defense
				55 // Speed
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
				"Cut",
				"Gust",
				"Wing-Attack",
				"Whirlwind",
				"Fly",
				"Tackle",
				"Bite",
				"Supersonic",
				"Absorb",
				"Solar-Beam",
				"Toxic",
				"Psychic",
				"Agility",
				"Screech",
				"Double-Team",
				"Dream-Eater",
				"Leech-Life",
				"Sky-Attack",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Outrage",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Shadow-Ball",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Air-Cutter",
				"Aerial-Ace",
				"Water-Pulse",
				"Roost",
				"Tailwind",
				"U-Turn",
				"Dark-Pulse",
				"Air-Slash",
				"X-Scissor",
				"Dragon-Pulse",
				"Switcheroo",
				"Shadow-Claw",
				"Draco-Meteor",
				"Round",
				"Echoed-Voice",
				"Acrobatics",
				"Wild-Charge",
				"Hurricane",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}