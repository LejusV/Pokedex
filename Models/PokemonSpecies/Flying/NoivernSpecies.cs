using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Noivern Species to store common natural stats of all Noiverns
	#region NoivernSpecies
	public class NoivernSpecies : PokemonSpecies
	{
#nullable enable
		private static NoivernSpecies? _instance = null;
#nullable restore
        public static NoivernSpecies Instance => _instance ?? (_instance = new NoivernSpecies());

		#region NoivernSpecies Constructor
		public NoivernSpecies() : base(
			715,
			"Noivern",
			Flying.Instance, Dragon.Instance,
			1.5,
			85.0,
			new PokemonStats(
				85, // HPs
				70, 80, // Attack & Defense
				97, 80, // Spacial Attack & Defense
				123 // Speed
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
				"Flamethrower",
				"Hyper-Beam",
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
				"Moonlight",
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
				"Dragon-Claw",
				"Water-Pulse",
				"Roost",
				"Tailwind",
				"U-Turn",
				"Dark-Pulse",
				"Air-Slash",
				"X-Scissor",
				"Dragon-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Draco-Meteor",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Acrobatics",
				"Wild-Charge",
				"Hurricane",
				"Boomburst",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}