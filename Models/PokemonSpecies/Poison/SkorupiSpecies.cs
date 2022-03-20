using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Skorupi Species to store common natural stats of all Skorupis
	#region SkorupiSpecies
	public class SkorupiSpecies : PokemonSpecies
	{
#nullable enable
		private static SkorupiSpecies? _instance = null;
#nullable restore
        public static SkorupiSpecies Instance => _instance ?? (_instance = new SkorupiSpecies());

		#region SkorupiSpecies Constructor
		public SkorupiSpecies() : base(
			451,
			"Skorupi",
			Poison.Instance, Bug.Instance,
			0.8,
			12.0,
			new PokemonStats(
				40, // HPs
				50, 90, // Attack & Defense
				30, 55, // Spacial Attack & Defense
				65 // Speed
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
				"Swords-Dance",
				"Cut",
				"Whirlwind",
				"Sand-Attack",
				"Headbutt",
				"Poison-Sting",
				"Twineedle",
				"Pin-Missile",
				"Leer",
				"Bite",
				"Strength",
				"Dig",
				"Toxic",
				"Agility",
				"Screech",
				"Double-Team",
				"Confuse-Ray",
				"Flash",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Scary-Face",
				"Feint-Attack",
				"Sludge-Bomb",
				"Mud-Slap",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Shadow-Ball",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Poison-Fang",
				"Rock-Tomb",
				"Aerial-Ace",
				"Poison-Tail",
				"Natural-Gift",
				"Acupressure",
				"Payback",
				"Fling",
				"Toxic-Spikes",
				"Poison-Jab",
				"Dark-Pulse",
				"Night-Slash",
				"Aqua-Tail",
				"X-Scissor",
				"Cross-Poison",
				"Captivate",
				"Bug-Bite",
				"Hone-Claws",
				"Venoshock",
				"Round",
				"Struggle-Bug",
				"Fell-Stinger",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}