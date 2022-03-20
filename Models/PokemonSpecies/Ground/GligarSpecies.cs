using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Gligar Species to store common natural stats of all Gligars
	#region GligarSpecies
	public class GligarSpecies : PokemonSpecies
	{
#nullable enable
		private static GligarSpecies? _instance = null;
#nullable restore
        public static GligarSpecies Instance => _instance ?? (_instance = new GligarSpecies());

		#region GligarSpecies Constructor
		public GligarSpecies() : base(
			207,
			"Gligar",
			Ground.Instance, Flying.Instance,
			1.1,
			64.8,
			new PokemonStats(
				65, // HPs
				75, 105, // Attack & Defense
				35, 65, // Spacial Attack & Defense
				85 // Speed
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
				"Guillotine",
				"Razor-Wind",
				"Swords-Dance",
				"Cut",
				"Wing-Attack",
				"Sand-Attack",
				"Headbutt",
				"Double-Edge",
				"Poison-Sting",
				"Counter",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Mimic",
				"Screech",
				"Double-Team",
				"Harden",
				"Swift",
				"Dream-Eater",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Detect",
				"Sandstorm",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Rock-Tomb",
				"Sky-Uppercut",
				"Sand-Tomb",
				"Aerial-Ace",
				"Poison-Tail",
				"Roost",
				"Natural-Gift",
				"Feint",
				"Tailwind",
				"U-Turn",
				"Payback",
				"Fling",
				"Power-Trick",
				"Rock-Polish",
				"Poison-Jab",
				"Dark-Pulse",
				"Night-Slash",
				"Aqua-Tail",
				"X-Scissor",
				"Earth-Power",
				"Rock-Climb",
				"Defog",
				"Cross-Poison",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Bug-Bite",
				"Hone-Claws",
				"Venoshock",
				"Round",
				"Acrobatics",
				"Struggle-Bug",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}