using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Gliscor Species to store common natural stats of all Gliscors
	#region GliscorSpecies
	public class GliscorSpecies : PokemonSpecies
	{
#nullable enable
		private static GliscorSpecies? _instance = null;
#nullable restore
        public static GliscorSpecies Instance => _instance ?? (_instance = new GliscorSpecies());

		#region GliscorSpecies Constructor
		public GliscorSpecies() : base(
			472,
			"Gliscor",
			Ground.Instance, Flying.Instance,
			2.0,
			42.5,
			new PokemonStats(
				75, // HPs
				95, 125, // Attack & Defense
				45, 75, // Spacial Attack & Defense
				95 // Speed
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
				"Swords-Dance",
				"Cut",
				"Sand-Attack",
				"Headbutt",
				"Hyper-Beam",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Screech",
				"Double-Team",
				"Harden",
				"Swift",
				"Sky-Attack",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Mud-Slap",
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
				"Iron-Tail",
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
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Payback",
				"Fling",
				"Rock-Polish",
				"Poison-Jab",
				"Dark-Pulse",
				"Night-Slash",
				"Aqua-Tail",
				"X-Scissor",
				"Earth-Power",
				"Giga-Impact",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Defog",
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
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}