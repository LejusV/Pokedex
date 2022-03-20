using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Drapion Species to store common natural stats of all Drapions
	#region DrapionSpecies
	public class DrapionSpecies : PokemonSpecies
	{
#nullable enable
		private static DrapionSpecies? _instance = null;
#nullable restore
        public static DrapionSpecies Instance => _instance ?? (_instance = new DrapionSpecies());

		#region DrapionSpecies Constructor
		public DrapionSpecies() : base(
			452,
			"Drapion",
			Poison.Instance, Dark.Instance,
			1.3,
			61.5,
			new PokemonStats(
				70, // HPs
				90, 110, // Attack & Defense
				60, 75, // Spacial Attack & Defense
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
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Poison-Sting",
				"Pin-Missile",
				"Leer",
				"Bite",
				"Roar",
				"Hyper-Beam",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Scary-Face",
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
				"Giga-Impact",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Rock-Climb",
				"Cross-Poison",
				"Captivate",
				"Bug-Bite",
				"Hone-Claws",
				"Venoshock",
				"Round",
				"Retaliate",
				"Struggle-Bug",
				"Bulldoze",
				"Snarl",
				"Fell-Stinger",
				"Confide",
				"Infestation",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}